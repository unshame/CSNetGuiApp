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

        public const int moviesPerPage = 5;
        public Control[] movies = new Control[moviesPerPage];
        public MovieData[] moviesData = new MovieData[moviesPerPage];
        public bool canDelete = false;
        public int moviesPage = 0;

        public FormMovies() {
            StartPosition = FormStartPosition.Manual;
            FormClosed += OnClosed;
            InitializeComponent();
        }


        // Events
        private void OnLoad(object sender, EventArgs e) {
            Paint += OnPaint;
            CreateControlsFromTemplate(panelMovies.Controls[0], panelMovies, "movie", movies, moviesPerPage);

            MovieManager.AddGenresToDropdown(filterGenre, true);
            MovieManager.AddOrderingBinding(filterSortOrder);
            MovieManager.AddSortByBinding(filterSortBy);
            MovieManager.AddRatingBinding(filterRating);

            for (int i = 0; i < moviesPerPage; i++) {
                var movie = movies[i];
                var curi = i;
                movie.Controls["buttonReviews"].Click += (object s, EventArgs ee) => {
                    Program.OpenMovieForm(moviesData[curi].id);
                };
                movie.Controls["buttonDeleteMovie"].DataBindings.Add("Visible", Profile.IsAdmin, "Checked");
                movie.Controls["buttonDeleteMovie"].Click += (object s, EventArgs ee) => {
                    MovieManager.DeleteMovie(moviesData[curi].id);
                    LoadMovies();
                };
            }

            buttonWatchlist.DataBindings.Add("Enabled", Profile.IsLoggedIn, "Checked");
            buttonAddMovie.DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
            buttonLogin.DataBindings.Add(Profile.GetFormattedBindingLoggedIn("Text"));

        }

        private void OnClosed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            DrawDividers(panelMovies, e.Graphics);
        }


        // Methods
        public void LoadMovies() {
            ValidateFilter();
            var filterStr = DB.FormatFilter(
                filterTitle.Text,
                filterDirector.Text,
                filterStar.Text,
                (int)filterDuration.Value,
                (int)filterGenre.SelectedValue,
                (int)filterYear.Value,
                (int)filterRating.SelectedValue
            );
            UpdatePagination(DB.GetMoviesCount(filterStr));
            var newMoviesData = DB.GetMovies(moviesPerPage, moviesPage * moviesPerPage, filterStr, (string)filterSortBy.SelectedValue, (string)filterSortOrder.SelectedValue);
            for (int i = 0; i < moviesPerPage; i++) {
                var movie = movies[i];
                if (i >= newMoviesData.Count) {
                    movie.Hide();
                    continue;
                }
                moviesData[i] = newMoviesData[i];
                var movieData = moviesData[i];
                movie.Text = movieData.title;
                movie.Text = movieData.title;
                movie.Controls["textMovieInfo"].Text = movieData.FormatInfo();
                movie.Controls["textMovieRating"].Text = movieData.FormatRating();
                movie.Controls["textMovieDescription"].Text = movieData.description;
                movie.Controls["textMovieDirector"].Text = movieData.director;
                movie.Controls["textMovieStars"].Text = movieData.stars;
                PictureBox poster = (PictureBox)movie.Controls["poster"];
                poster.Image = ImageManager.FormatPoster(movieData.poster, poster.Width, poster.Height);
                movie.Show();
            }
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

        public void UpdatePagination(int total) {
            var pageCount = total / moviesPerPage + (total % moviesPerPage > 0 ? 1 : 0);
            if(moviesPage >= pageCount || moviesPage < 0) {
                moviesPage = 0;
            }
            var offset = moviesPage * moviesPerPage;
            if (total > 0) {
                var rangeStart = offset + 1;
                var rangeEnd = Math.Min(offset + moviesPerPage, total);
                labelPagination.Text = rangeStart + " - " + rangeEnd + " / " + total;
            }
            else {
                labelPagination.Text = "";
            }
            buttonPrev.Enabled = moviesPage > 0;
            buttonNext.Enabled = moviesPage < (pageCount - 1);
        }


        // Click events
        private void buttonLogin_Click(object sender, EventArgs e) {
            if (Profile.IsLoggedIn.Checked) {
                Profile.Logout();
            }
            Program.formLogin.ShowDialog();
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
            Program.formReviews.Show();
        }

        private void buttonFilter_Click(object sender, EventArgs e) {
            moviesPage = 0;
            LoadMovies();
        }

        private void buttonFilterReset_Click(object sender, EventArgs e) {
            moviesPage = 0;
            ResetFilter();
            LoadMovies();
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            moviesPage++;
            LoadMovies();
        }

        private void buttonPrev_Click(object sender, EventArgs e) {
            moviesPage--;
            LoadMovies();
        }
    }
}
