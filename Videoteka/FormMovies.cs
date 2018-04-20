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
        public bool canDelete = false;

        public FormMovies() {
            StartPosition = FormStartPosition.Manual;
            FormClosed += FormMovies_Closed;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Paint += Movies_Paint;

            var template = panelMovies.Controls[0];

            CreateControlsFromTemplate(panelMovies.Controls[0], panelMovies, "movie", movies, MOVIES_PER_PAGE);
            Debug.WriteLine(1);

            for (int i = 0; i < MOVIES_PER_PAGE; i++) {
                var movie = movies[i];
                var curi = i;
                movie.Controls["buttonReviews"].Click += (object s, EventArgs ee) => {
                    new FormSingleMovie().Show();
                };
                movie.Controls["buttonDeleteMovie"].DataBindings.Add("Visible", Profile.IsAdmin, "Checked");
            }

            buttonAddMovie.DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
            buttonLogin.DataBindings.Add(Profile.GetFormattedBindingLoggedIn("Text"));
        }

        private void FormMovies_Closed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Movies_Paint(object sender, PaintEventArgs e) {
            DrawDividers(panelMovies, e.Graphics);
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            templatePoster.Location = new Point(10, 20);
        }

        private void groupFilter_Enter(object sender, EventArgs e) {

        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            if (Profile.IsLoggedIn.Checked) {
                Profile.Logout();
            }
            Program.formLogin.ShowDialog();
        }

        private void buttonWatchlist_Click(object sender, EventArgs e) {
            Program.OpenWatchList();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e) {
            Program.formAddMovie.ShowDialog();
        }

        private void buttonAllReviews_Click(object sender, EventArgs e) {
            Hide();
            Program.formReviews.Location = Location;
            Program.formReviews.Show();
        }
    }
}
