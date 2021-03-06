using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Videoteka {
    public partial class FormMovies : TemplatedForm {

        public const int itemsPerPage = 15;
        public Control[] movies = new Control[itemsPerPage];
        public MovieData[] moviesData = new MovieData[itemsPerPage];
        public bool canDelete = false;

        public FormMovies()  {
            StartPosition = FormStartPosition.Manual;

            FormClosed += OnClosed;
            Resize += OnResize;

            InitializeComponent();
            InitializeTemplatedForm();

            AcceptButton = buttonFilter;
        }


        // Events
        void OnLoad(object sender, EventArgs e) {
            CreateControlsFromTemplate(template, panelMovies, "movie", movies, itemsPerPage);

            BindingManager.AddGenresToDropdown(filterGenre, true);
            BindingManager.AddOrderingBinding(filterSortOrder);
            BindingManager.AddSortByMoviesBinding(filterSortBy);
            BindingManager.AddRatingBinding(filterRating);
            buttonWatchlist.DataBindings.Add("Enabled", Profile.IsLoggedIn, "Checked");
            buttonAddMovie.DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
            buttonLogin.DataBindings.Add(BindingManager.GetFormattedBindingLoggedIn("Text"));

            for (int i = 0; i < itemsPerPage; i++) {
                var movie = movies[i];
                var curi = i;
                movie.Controls["buttonReviews"].Click += (object s, EventArgs ee) => {
                    Program.OpenMovieForm(moviesData[curi].id);
                };
                movie.Controls["buttonAddToWatchlist"].Click += (object s, EventArgs ee) => {
                    MovieManager.AddToWatchList(moviesData[curi].id);
                };
                movie.Controls["buttonEditMovie"].DataBindings.Add("Visible", Profile.IsAdmin, "Checked");
                movie.Controls["buttonEditMovie"].DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
                movie.Controls["buttonEditMovie"].Click += (object s, EventArgs ee) => {
                    new FormAddMovie(moviesData[curi].id).ShowDialog();
                };
            }
        }

        private void OnClosed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        void OnResize(object sender, EventArgs e) {
            Program.formHeight = Height;
        }

        // Methods
        public void LoadMovies() {
            ValidateFilter();
            var filterStr = DB.FormatFilterMovies(
                filterTitle.Text,
                filterDirector.Text,
                filterStar.Text,
                (int)filterDuration.Value,
                (int)filterGenre.SelectedValue,
                (int)filterYear.Value,
                (int)filterRating.SelectedValue
            );

            UpdatePagination(DB.GetMoviesCount(filterStr), itemsPerPage, buttonPrev, buttonNext, labelPagination);
            var newMoviesData = DB.GetMovies(itemsPerPage, currentPage * itemsPerPage, filterStr, (string)filterSortBy.SelectedValue, (string)filterSortOrder.SelectedValue);

            for (int i = 0; i < itemsPerPage; i++) {
                var movie = movies[i];

                if (i >= newMoviesData.Count) {
                    movie.Hide();
                    continue;
                }

                moviesData[i] = newMoviesData[i];
                var movieData = moviesData[i];
                movie.Text = movieData.title;
                movie.Controls["textMovieInfo"].Text = movieData.FormatInfo();
                movie.Controls["textMovieRating"].Text = movieData.FormatRating();
                movie.Controls["textMovieDescription"].Text = movieData.description;
                movie.Controls["textMovieDirector"].Text = movieData.director;
                movie.Controls["textMovieStars"].Text = movieData.stars;
                var watchlistButton = movie.Controls["buttonAddToWatchlist"];
                watchlistButton.Enabled = Profile.IsLoggedIn.Checked && movieData.watchlistId == 0;
                watchlistButton.Text = watchlistButton.Enabled || !Profile.IsLoggedIn.Checked ? MovieManager.NotInWatchlistText : (movieData.isWatched ? MovieManager.WatchedText : MovieManager.InWatchlistText);

                var poster = (PictureBox)movie.Controls["poster"];
                poster.Image = ImageManager.FormatPoster(movieData.poster, poster.Width, poster.Height);

                movie.Show();
            }

            PerformLayout();
            Refresh();
        }

        public void ValidateFilter() {
            if (filterGenre.SelectedItem == null) {
                filterGenre.SelectedIndex = 0;
            }
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
            filterDirector.ResetText();
            filterStar.ResetText();
            filterDuration.Value = filterDuration.Minimum;
            filterGenre.SelectedIndex = 0;
            filterYear.Value = filterYear.Minimum;
            filterRating.SelectedIndex = 0;
            filterSortBy.SelectedIndex = 0;
            filterSortOrder.SelectedIndex = 0;
        }


        // Click events
        private void buttonLogin_Click(object sender, EventArgs e) {
            if (Profile.IsLoggedIn.Checked) {
                Profile.Logout();
            }
            else {
                Program.formLogin.ShowDialog();
            }
        }

        private void buttonWatchlist_Click(object sender, EventArgs e) {
            Program.OpenWatchListForm();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e) {
            Program.OpenAddMovieForm();
        }

        private void buttonAllReviews_Click(object sender, EventArgs e) {
            Hide();
            Program.formReviews.Location = Location;
            Program.formReviews.Height = Program.formHeight;
            Program.formReviews.Show();
            Program.formReviews.LoadReviews();
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            currentPage = 0;
            LoadMovies();
        }

        private void buttonFilterReset_Click(object sender, EventArgs e) {
            currentPage = 0;
            ResetFilter();
            LoadMovies();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            currentPage++;
            LoadMovies();
        }

        private void buttonPrev_Click(object sender, EventArgs e) {
            currentPage--;
            LoadMovies();
        }

        private void buttonStats_Click(object sender, EventArgs e) {
            Program.OpenStatsForm();
        }
    }
}
