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
        public bool isEditing = false;

        public FormSingleMovie(int id) {
            this.id = id;

            FormClosing += OnClosing;
            Paint += OnResize;

            InitializeComponent();
            InitializeTemplatedForm();
        }

        // Events
        void OnLoad(object sender, EventArgs e) {
            CreateControlsFromTemplate(template, panelReviews, "review", reviews, itemsPerPage);

            labelRatingValue.DataBindings.Add("Text", reviewRating, "Value");
            buttonEditMovie.DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
            buttonEditMovie.DataBindings.Add("Visible", Profile.IsAdmin, "Checked");

            Height = Program.formHeight;

            reviewsLocation = panelReviews.Location;
            reviewsHeight = panelReviews.Height;

            LoadData();
        }

        private void OnClosing(object sender, EventArgs e) {
            Program.RemoveMovieFormFromOpened(this);
        }

        private void OnResize(object sender, EventArgs e) {
            if (Profile.IsLoggedIn.Checked) {
                reviewsHeight = panelReviews.Height;
            }
        }

        // Methods
        public void LoadData() {

            if (!LoadMovie()) return;

            var savedScrollValue = panelReviews.VerticalScroll.Value;
            panelReviews.VerticalScroll.Value = 0;

            if (Profile.IsLoggedIn.Checked) {
                groupMyReview.Show();

                LoadOwnReview();

                panelReviews.Location = reviewsLocation;
                panelReviews.Height = reviewsHeight;

                buttonAddToWatchlist.Enabled = movieData.watchlistId == 0;
                buttonAddToWatchlist.Text = buttonAddToWatchlist.Enabled ? MovieManager.NotInWatchlistText : (movieData.isWatched ? MovieManager.WatchedText : MovieManager.InWatchlistText);
            }
            else {
                groupMyReview.Hide();

                isEditing = false;
                reviewText.ResetText();
                reviewRating.Value = 5;
                reviewRating.Enabled = false;
                reviewText.Enabled = false;

                panelReviews.Location = new Point(reviewsLocation.X, groupMyReview.Location.Y);
                panelReviews.Height = reviewsHeight + groupMyReview.Height;

                buttonAddToWatchlist.Enabled = false;
                buttonAddToWatchlist.Text = MovieManager.NotInWatchlistText;
            }

            LoadReviews();
            ResizeReviews();

            panelReviews.VerticalScroll.Value = savedScrollValue;

            PerformLayout();
            Refresh();
        }

        public bool LoadMovie() {
            try {
                movieData = DB.GetMovies(1, 0, "movies.id = " + id)[0];
            }
            catch {
                Program.ShowErrorBox("Movie doesn't exist in the database", "Failed to open movie");
                Close();
                return false;
            }

            poster.Image = ImageManager.FormatPoster(movieData.poster, poster.Width, poster.Height);
            Text = movieData.title;
            groupMovie.Text = movieData.title;
            textMovieInfo.Text = movieData.FormatInfo();
            textMovieRating.Text = movieData.FormatRating();
            textMovieDescription.Text = movieData.description;
            textMovieDirector.Text = movieData.director;
            textMovieStars.Text = movieData.stars;

            return true;
        }

        public void LoadOwnReview() {
            var reviewsData = DB.GetReviews(1, 0, "movie_id = " + id + " and user_id = " + Profile.UID);

            if (reviewsData.Count > 0) {
                reviewData = reviewsData[0];

                if (!isEditing) {
                    groupMyReviewPublished.Show();
                }

                buttonDeleteReview.Enabled = !isEditing;
                reviewRating.Enabled = isEditing;
                reviewText.Enabled = isEditing;
                reviewPublish.Enabled = isEditing;
                buttonCancelReview.Enabled = isEditing;

                groupMyReviewPublished.Text = reviewData.FormatUsername();
                publishedReviewText.Text = reviewData.text == "" ? "No review provided." : reviewData.text;
                publishedReviewRating.Text = reviewData.FormatRating();
            }
            else {
                isEditing = false;

                groupMyReviewPublished.Hide();

                buttonDeleteReview.Enabled = false;
                buttonCancelReview.Enabled = true;
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
            new FormAddMovie(id).ShowDialog();
        }

        private void reviewPublish_Click(object sender, EventArgs e) {
            var success = false;

            if (isEditing) {
                success = ReviewManager.UpdateReview(reviewData.id, id, reviewRating.Value, reviewText.Text);
            }
            else { 
                success = ReviewManager.AddReview(id, reviewRating.Value, reviewText.Text) != -1;
            }
            if (success) {

                if (isEditing) {
                    isEditing = false;
                    Program.ReloadForms();
                }

                reviewText.ResetText();
                reviewRating.Value = 5;
            }
        }

        private void buttonPublishRevview_Click(object sender, EventArgs e) {
            ReviewManager.DeleteReview(reviewData.id);
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            currentPage++;
            LoadData();
        }

        private void buttonPrev_Click(object sender, EventArgs e) {
            currentPage--;
            LoadData();
        }

        private void buttonAddToWatchlist_Click(object sender, EventArgs e) {
            MovieManager.AddToWatchList(id);
        }

        private void buttonEditReview_Click(object sender, EventArgs e) {
            isEditing = true;

            groupMyReviewPublished.Hide();

            reviewText.Text = reviewData.text;
            reviewRating.Value = reviewData.rating;
            buttonDeleteReview.Enabled = false;
            reviewRating.Enabled = true;
            reviewText.Enabled = true;
            reviewPublish.Enabled = true;
            buttonCancelReview.Enabled = true;
        }

        private void buttonCancelReview_Click(object sender, EventArgs e) {
            if (isEditing) {
                isEditing = false;
                LoadData();
            }
            else {
                reviewText.ResetText();
                reviewRating.Value = 5;
            }
        }
    }
}
