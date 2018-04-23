using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Videoteka {
    public partial class FormAddMovie : Form {

        public int movieId;
        public MovieData movieData;
        private string posterExistsText = "(Image in db)";

        public FormAddMovie(int movieId = -1) {
            this.movieId = movieId;
            InitializeComponent();
            AcceptButton = buttonAdd;
        }

        // Events
        private void OnLoad(object sender, EventArgs e) {
            FormClosing += OnClosing;
            BindingManager.AddGenresToDropdown(addGenre);
            if(movieId != -1) {                
                LoadMovie();
            }
        }

        private void OnClosing(Object sender, FormClosingEventArgs e) {
            if (this == Program.formAddMovie) {
                Program.formAddMovie = null;
            }
        }


        // Methods
        public void LoadMovie() {
            try {
                movieData = DB.GetMovies(1, 0, "movies.id = " + movieId)[0];
            }
            catch {
                Program.ShowErrorBox("Movie doesn't exist in the database", "Failed to open movie");
                Close();
                return;
            }

            Text = movieData.title;
            addTitle.Text = movieData.title;
            addYear.Text = movieData.year.ToString();
            addDuration.Value = movieData.duration;
            addGenre.SelectedItem = BindingManager.Genres[movieData.genre];
            addDescription.Text = movieData.description;
            addDirector.Text = movieData.director;
            addStars.Text = movieData.stars;
            if (movieData.poster != null) {
                addPosterPath.Text = posterExistsText;
            }

            buttonDelete.Visible = buttonDelete.Enabled = true;
            buttonAdd.Text = "Save";
        }


        // Click events
        private void buttonAdd_Click(object sender, EventArgs e) {
            if (movieId != -1) {
                if (MovieManager.UpdateMovie(
                    movieData.id,
                    addTitle.Text,
                    addYear.Value,
                    addGenre.SelectedValue,
                    addDuration.Value,
                    addDirector.Text,
                    addStars.Text,
                    addDescription.Text,
                    movieData.poster,
                    addPosterPath.Text == posterExistsText ? null : addPosterPath.Text
                )) {
                    Close();
                }
            }
            else {
                var id = MovieManager.AddMovie(
                    addTitle.Text,
                    addYear.Value,
                    addGenre.SelectedValue,
                    addDuration.Value,
                    addDirector.Text,
                    addStars.Text,
                    addDescription.Text,
                    addPosterPath.Text
                );
                if (id != -1) {
                    Program.OpenMovieForm(id);
                    Close();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            Close();
            MovieManager.DeleteMovie(movieId);
        }

        private void addPosterButton_Click(object sender, EventArgs e) {
            DialogResult result = addPosterDialog.ShowDialog();
            addPosterPath.Text = addPosterDialog.FileName;
        }
    }
}
