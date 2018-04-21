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

        public const int MOVIES_PER_PAGE = 10;
        public Control[] movies = new Control[MOVIES_PER_PAGE];
        public MovieData[] moviesData = new MovieData[MOVIES_PER_PAGE];
        public bool canDelete = false;

        public FormMovies() {
            StartPosition = FormStartPosition.Manual;
            FormClosed += OnClosed;
            InitializeComponent();
        }


        // Events
        private void OnLoad(object sender, EventArgs e) {
            Paint += OnPaint;
            CreateControlsFromTemplate(panelMovies.Controls[0], panelMovies, "movie", movies, MOVIES_PER_PAGE);

            MovieManager.AddGenresToDropdown(filterGenre, true);

            for (int i = 0; i < MOVIES_PER_PAGE; i++) {
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
            var newMoviesData = DB.GetMovies(MOVIES_PER_PAGE, 0);
            for (int i = 0; i < MOVIES_PER_PAGE; i++) {
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
    }
}
