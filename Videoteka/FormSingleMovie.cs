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

        public const int REVIEWS_PER_PAGE = 10;
        public Control[] reviews = new Control[REVIEWS_PER_PAGE];
        public int id = -1;
        public MovieData movieData;

        public FormSingleMovie(int id) {
            this.id = id;
            InitializeComponent();
        }

        // Events
        private void OnLoad(object sender, EventArgs e) {
            Paint += OnPaint;
            FormClosing += OnClosing;
            CreateControlsFromTemplate(panelReviews.Controls[0], panelReviews, "review", reviews, REVIEWS_PER_PAGE);
            labelRatingValue.DataBindings.Add("Text", reviewRating, "Value");
            buttonDeleteMovie.DataBindings.Add("Visible", Profile.IsAdmin, "Checked");
            LoadMovie();
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            DrawDividers(panelReviews, e.Graphics);
        }

        private void OnClosing(object sender, EventArgs e) {
            Program.RemoveFormFromOpened(this);
        }

        // Methods
        public void LoadMovie() {
            try {
                movieData = DB.GetMovies(1, 0, "id = " + id)[0];
            }
            catch {
                Program.ShowErrorBox("Movie doesn't exist in the database", "Failed to open movie");
                Close();
                return;
            }

            poster.Image = ImageManager.FormatPoster(movieData.poster, poster.Width, poster.Height);
            Text = movieData.title;
            groupMovie.Text = movieData.title;
            textMovieInfo.Text = movieData.FormatInfo();
            textMovieRating.Text = movieData.FormatRating();
            textMovieDescription.Text = movieData.description;
            textMovieDirector.Text = movieData.director;
            textMovieStars.Text = movieData.stars;
        }

        // Click events
        private void buttonDeleteMovie_Click(object sender, EventArgs e) {
            if (MovieManager.DeleteMovie(id)) {
                Close();
            }
        }


    }
}
