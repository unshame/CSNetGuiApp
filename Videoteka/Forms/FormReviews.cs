using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Videoteka {
    public partial class FormReviews : TemplatedForm {

        public const int itemsPerPage = 5;
        public Control[] reviews = new Control[itemsPerPage];
        public ReviewData[] reviewsData = new ReviewData[itemsPerPage];

        public FormReviews() {
            StartPosition = FormStartPosition.Manual;
            FormClosed += OnClosed;
            InitializeComponent();
        }

        // Events
        private void OnLoad(object sender, EventArgs e) {
            Paint += OnPaint;
            CreateControlsFromTemplate(panelReviews.Controls[0], panelReviews, "review", reviews, itemsPerPage);

            BindingManager.AddOrderingBinding(filterSortOrder);
            BindingManager.AddRatingBinding(filterRating);
            BindingManager.AddSortByReviewsBinding(filterSortBy);

            buttonAddMovie.DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
            buttonWatchlist.DataBindings.Add("Enabled", Profile.IsLoggedIn, "Checked");
            buttonLogin.DataBindings.Add(Profile.GetFormattedBindingLoggedIn("Text"));

            for (int i = 0; i < itemsPerPage; i++) {
                var review = reviews[i];
                var curi = i;
                review.Controls["buttonDeleteReview"].DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
                review.Controls["buttonDeleteReview"].DataBindings.Add("Visible", Profile.IsAdmin, "Checked");
                review.Controls["buttonDeleteReview"].Click += (object s, EventArgs ee) => {
                    ReviewManager.DeleteReview(reviewsData[curi].id);
                    LoadReviews();
                };
                review.Controls["buttonMovieInfo"].Click += (object s, EventArgs ee) => {
                    Program.OpenMovieForm(reviewsData[curi].movieId);
                };
            }
            LoadReviews();
        }

        private void OnClosed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            DrawDividers(panelReviews, e.Graphics);
        }

        public void LoadReviews() {
            var savedScrollValue = panelReviews.VerticalScroll.Value;
            panelReviews.VerticalScroll.Value = 0;

            var filterStr = DB.AddAnd(DB.FormatFilterReviews(filterTitle.Text, filterUser.Text, (int)filterRating.SelectedValue));
            filterStr += "review != ''";
            UpdatePagination(DB.GetReviewsCount(filterStr), itemsPerPage, buttonPrev, buttonNext, labelPagination);
            var newReviewsData = DB.GetReviews(
                itemsPerPage,
                currentPage * itemsPerPage,
                filterStr,
                (string)filterSortBy.SelectedValue,
                (string)filterSortOrder.SelectedValue
            );
            var baseOffset = reviews[0].Location.Y;
            var offset = baseOffset;
            for (int i = 0; i < itemsPerPage; i++) {
                var review = reviews[i];
                if (i >= newReviewsData.Count) {
                    review.Hide();
                    continue;
                }
                var reviewData = newReviewsData[i];
                reviewsData[i] = reviewData;
                review.Text = reviewData.FormatUsername();
                review.Controls["labelMovieTitle"].Text = reviewData.title;
                review.Controls["labelReviewRating"].Text = reviewData.FormatRating();
                review.Controls["textReview"].Text = reviewData.text;
                review.Location = new Point(review.Location.X, offset);
                offset += baseOffset + review.Height;
                review.Show();
            }

            panelReviews.VerticalScroll.Value = savedScrollValue;
            panelReviews.PerformLayout();
            Refresh();
        }

        public void ValidateFilter() {
            if (filterRating.SelectedItem == null) {
                filterRating.SelectedIndex = 0;
            }
            if (filterSortBy.SelectedItem == null) {
                filterSortBy.SelectedIndex = 0;
            }
            if (filterSortOrder.SelectedItem == null) {
                filterSortOrder.SelectedIndex = 0;
            }
        }

        public void ResetFilter() {
            filterTitle.ResetText();
            filterUser.ResetText();
            filterRating.SelectedIndex = 0;
            filterSortBy.SelectedIndex = 0;
            filterSortOrder.SelectedIndex = 0;
        }


        // Click events 
        private void buttonAllMovies_click(object sender, EventArgs e) {
            Hide();
            Program.formMovies.Location = Location;
            Program.formMovies.Show();
        }

        private void buttonWatchlist_Click(object sender, EventArgs e) {
            Program.OpenWatchListForm();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            if (Profile.IsLoggedIn.Checked) {
                Profile.Logout();
            }
            Program.formLogin.ShowDialog();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e) {
            Program.OpenAddMovieForm();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            currentPage++;
            LoadReviews();
        }

        private void buttonPrev_Click(object sender, EventArgs e) {
            currentPage--;
            LoadReviews();
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            currentPage = 0;
            LoadReviews();
        }

        private void buttonFilterReset_Click(object sender, EventArgs e) {
            ResetFilter();
            currentPage = 0;
            LoadReviews();
        }
    }
}
