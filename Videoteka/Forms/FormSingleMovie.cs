using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Videoteka {
    public partial class FormSingleMovie : TemplatedForm {

        public const int itemsPerPage = 5;
        public Control[] reviews = new Control[itemsPerPage];
        public int id = -1;
        public MovieData movieData;
        public ReviewData reviewData;
        private Point reviewsLocation;
        private int reviewsHeight;

        public FormSingleMovie(int id) {
            this.id = id;
            InitializeComponent();
        }

        // Events
        private void OnLoad(object sender, EventArgs e) {
            Paint += OnPaint;
            FormClosing += OnClosing;
            CreateControlsFromTemplate(panelReviews.Controls[0], panelReviews, "review", reviews, itemsPerPage);
            labelRatingValue.DataBindings.Add("Text", reviewRating, "Value");
            buttonAddToWatchlist.DataBindings.Add("Enabled", Profile.IsLoggedIn, "Checked");
            buttonDeleteMovie.DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
            buttonDeleteMovie.DataBindings.Add("Visible", Profile.IsAdmin, "Checked");
            reviewsLocation = panelReviews.Location;
            reviewsHeight = panelReviews.Height;
            LoadData();
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            Debug.WriteLine(panelReviews.Location.Y);
            DrawDividers(panelReviews, e.Graphics);
        }

        private void OnClosing(object sender, EventArgs e) {
            Program.RemoveFormFromOpened(this);
        }

        // Methods
        public void LoadData() {
            try {
                movieData = DB.GetMovies(1, 0, "id = " + id)[0];
            }
            catch {
                Program.ShowErrorBox("Movie doesn't exist in the database", "Failed to open movie");
                Close();
                return;
            }

            var savedScrollValue = panelReviews.VerticalScroll.Value;
            panelReviews.VerticalScroll.Value = 0;

            poster.Image = ImageManager.FormatPoster(movieData.poster, poster.Width, poster.Height);
            Text = movieData.title;
            groupMovie.Text = movieData.title;
            textMovieInfo.Text = movieData.FormatInfo();
            textMovieRating.Text = movieData.FormatRating();
            textMovieDescription.Text = movieData.description;
            textMovieDirector.Text = movieData.director;
            textMovieStars.Text = movieData.stars;

            if (Profile.IsLoggedIn.Checked) {

                groupMyReview.Show();

                LoadOwnReview();

                panelReviews.Location = reviewsLocation;
                panelReviews.Height = reviewsHeight;
            }
            else {
                groupMyReview.Hide();
                reviewRating.Enabled = false;
                reviewText.Enabled = false;

                panelReviews.Location = new Point(reviewsLocation.X, groupMyReview.Location.Y);
                panelReviews.Height = reviewsHeight + groupMyReview.Height;
            }
            LoadReviews();
            ResizeReviews();
            panelReviews.VerticalScroll.Value = savedScrollValue;
            PerformLayout();
            Refresh();
        }

        public void LoadOwnReview() {
            var reviewsData = DB.GetReviews(1, 0, "movie_id = " + id + " and user_id = " + Profile.UID);

            if (reviewsData.Count > 0) {
                reviewData = reviewsData[0];
                groupMyReviewPublished.Show();
                groupMyReviewPublished.Text = reviewData.FormatUsername();
                publishedReviewText.Text = reviewData.text == "" ? "No review provided." : reviewData.text;
                publishedReviewRating.Text = reviewData.FormatRating();

                buttonDeleteReview.Enabled = true;
                reviewRating.Enabled = false;
                reviewText.Enabled = false;
                reviewPublish.Enabled = false;
            }
            else {
                groupMyReviewPublished.Hide();
                buttonDeleteReview.Enabled = false;
                reviewRating.Enabled = true;
                reviewText.Enabled = true;
                reviewPublish.Enabled = true;
            }
        }

        public void LoadReviews() {
            var filterStr = "movie_id = " + id + " and user_id != " + Profile.UID + " and review != ''";
            UpdatePagination(DB.GetReviewsCount(filterStr), itemsPerPage, buttonPrev, buttonNext, labelPagination);
            var reviewsData = DB.GetReviews(itemsPerPage, currentPage * itemsPerPage, filterStr, "id", "DESC");
            for (int i = 0; i < itemsPerPage; i++) {
                var review = reviews[i];
                if (i >= reviewsData.Count) {
                    review.Hide();
                    continue;
                }
                var reviewData = reviewsData[i];
                review.Text = reviewData.username;
                review.Controls["labelReviewMovieRating"].Text = reviewData.FormatRating();
                review.Controls["textReview"].Text = reviewData.text;
                review.Show();
            }
        }

        private void ResizeReviews() {
            var baseOffset = reviews[0].Location.Y;
            var offset = baseOffset;
            for (int i = 0; i < itemsPerPage; i++) {
                var review = reviews[i];
                if (!review.Visible) {
                    continue;
                }
                review.Location = new Point(review.Location.X, offset);
                offset += baseOffset + review.Height;
            }
        }


        // Click events
        private void buttonDeleteMovie_Click(object sender, EventArgs e) {
            MovieManager.DeleteMovie(id);
        }

        private void reviewPublish_Click(object sender, EventArgs e) {
            if (ReviewManager.AddReview(id, reviewRating.Value, reviewText.Text) != -1) {
                reviewText.ResetText();
                reviewRating.Value = 5;
            }
            LoadData();
        }

        private void buttonPublishRevview_Click(object sender, EventArgs e) {
            ReviewManager.DeleteReview(reviewData.id);
            LoadData();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            currentPage++;
            LoadData();
        }

        private void buttonPrev_Click(object sender, EventArgs e) {
            currentPage--;
            LoadData();
        }
    }
}
