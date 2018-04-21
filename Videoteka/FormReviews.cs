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

        public const int REVIEWS_PER_PAGE = 10;
        public Control[] reviews = new Control[REVIEWS_PER_PAGE];

        public FormReviews() {
            StartPosition = FormStartPosition.Manual;
            FormClosed += FormReviews_Closed;
            InitializeComponent();
        }

        private void FormReviews_Load(object sender, EventArgs e) {
            Paint += FormReviews_Paint;
            CreateControlsFromTemplate(panelReviews.Controls[0], panelReviews, "review", reviews, REVIEWS_PER_PAGE);
            buttonAddMovie.DataBindings.Add("Enabled", Profile.IsAdmin, "Checked");
            buttonWatchlist.DataBindings.Add("Enabled", Profile.IsLoggedIn, "Checked");
            buttonLogin.DataBindings.Add(Profile.GetFormattedBindingLoggedIn("Text"));
            for (int i = 0; i < REVIEWS_PER_PAGE; i++) {
                var review = reviews[i];
                review.Controls["buttonDeleteReview"].DataBindings.Add("Visible", Profile.IsAdmin, "Checked");
            }
        }

        private void FormReviews_Closed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

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
            Program.OpenAddMovie();
        }

        private void FormReviews_Paint(object sender, PaintEventArgs e) {
            DrawDividers(panelReviews, e.Graphics);
        }
    }
}
