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

        public FormSingleMovie(int id) {
            this.id = id;
            InitializeComponent();
        }

        private void FormSingleMovie_Load(object sender, EventArgs e) {
            Paint += FormSingleMovie_Paint;
            CreateControlsFromTemplate(panelReviews.Controls[0], panelReviews, "review", reviews, REVIEWS_PER_PAGE);

            labelRatingValue.DataBindings.Add("Text", reviewRating, "Value");
            buttonDeleteMovie.DataBindings.Add("Visible", Profile.IsAdmin, "Checked");

            MovieData movieData;
            try {
                movieData = Program.db.GetMovies(1, 0, "id = " + id)[0];
            } catch {
                MessageBox.Show("Movie doesn't exist in the database", "Failed to open movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormSingleMovie_Paint(object sender, PaintEventArgs e) {
            DrawDividers(panelReviews, e.Graphics);
        }

        private void buttonDeleteMovie_Click(object sender, EventArgs e) {
            if (MovieManager.DeleteMovie(id)) {
                Close();
            }
        }
    }
}
