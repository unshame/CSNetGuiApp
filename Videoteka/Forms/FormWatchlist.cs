using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Videoteka {
    public partial class FormWatchlist : TemplatedForm {

        public const int itemsPerPage = 10;
        public Control[] movies = new Control[itemsPerPage];
        public MovieData[] moviesData = new MovieData[itemsPerPage];

        public FormWatchlist() {
            FormClosing += OnClosing;
            InitializeComponent();
            InitializeTemplatedForm();
        }

        // Events
         void OnLoad(object sender, EventArgs e) {
            Paint += OnPaint;

            CreateControlsFromTemplate(template, panelMovies, "movie", movies, itemsPerPage);
            BindingManager.AddOrderingBinding(filterSortOrder);
            BindingManager.AddSortByWatchlistBinding(filterSortBy);

            for (int i = 0; i < itemsPerPage; i++) {
                var movie = movies[i];
                var curi = i;
                movie.Controls["buttonReviews"].Click += (object s, EventArgs ee) => {
                    Program.OpenMovieForm(moviesData[curi].id);
                };
                movie.Controls["buttonRemove"].Click += (object s, EventArgs ee) => {
                    MovieManager.RemoveFromWatchlist(moviesData[curi].watchlistId);
                };
                movie.Controls["buttonAddToWatched"].Click += (object s, EventArgs ee) => {
                    if (radioReviewed.Checked) {
                        MovieManager.AddToWatchList(moviesData[curi].id);
                    }
                    else {
                        MovieManager.SetWatchedStatus(moviesData[curi].watchlistId, radioUnwatched.Checked);
                    }
                };
            }
            ResizeEmptyImage(pictureEmpty, panelMovies);

            LoadWatchlist();
        }

        private void OnClosing(Object sender, FormClosingEventArgs e) {
            Program.formWatchlist = null;
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            DrawDividers(panelMovies, e.Graphics);
        }


        // Methods
        public void LoadWatchlist() {
            if (!Profile.IsLoggedIn.Checked) return;

            ValidateFilter();
            var filterStr = FormatFilter();
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
                var watchlistButton = movie.Controls["buttonAddToWatched"];
                if (radioReviewed.Checked) {
                    watchlistButton.Enabled = movieData.watchlistId == 0;
                    watchlistButton.Text = watchlistButton.Enabled ? MovieManager.NotInWatchlistText : (movieData.isWatched ? MovieManager.WatchedText : MovieManager.InWatchlistText);
                }
                else {
                    watchlistButton.Enabled = true;
                    watchlistButton.Text = radioUnwatched.Checked  ? MovieManager.WatchedText : MovieManager.NotWatchedText;
                }

                movie.Controls["buttonRemove"].Visible = movie.Controls["buttonRemove"].Enabled = !radioWatched.Checked && (radioUnwatched.Checked || movieData.watchlistId != 0);

                PictureBox poster = (PictureBox)movie.Controls["poster"];
                poster.Image = ImageManager.FormatPoster(movieData.poster, poster.Width, poster.Height);
                movie.Show();
            }
            pictureEmpty.Visible = newMoviesData.Count == 0;
            panelMovies.PerformLayout();
            Refresh();
        }

        public string FormatFilter() {
            var filterStr = "";
            if (radioReviewed.Checked) {
                filterStr = "rating != 0";
            }
            else {
                filterStr = "watchlist_id is not null and is_watched = " + (radioWatched.Checked ? "true" : "false");
            }
            return filterStr;
        }

        public void ValidateFilter() {
            if (filterSortBy.SelectedItem == null) {
                filterSortBy.SelectedIndex = 0;
            }
            if (filterSortOrder.SelectedItem == null) {
                filterSortOrder.SelectedIndex = 0;
            }
        }

        public void ResetFilter() {
            filterSortBy.SelectedIndex = 0;
            filterSortOrder.SelectedIndex = 0;
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            currentPage = 0;
            LoadWatchlist();
        }

        private void buttonFilterReset_Click(object sender, EventArgs e) {
            currentPage = 0;
            ResetFilter();
            LoadWatchlist();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            currentPage++;
            LoadWatchlist();
        }

        private void buttonPrev_Click(object sender, EventArgs e) {
            currentPage--;
            LoadWatchlist();
        }

        private void radio_CheckedChanged(object sender, EventArgs e) {
            if (sender is RadioButton radio && radio.Checked) {
                LoadWatchlist();
            }
        }

        private void panelMovies_Paint(object sender, PaintEventArgs e) {

        }
    }
}
