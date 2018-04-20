using System;
using System.Windows.Forms;

namespace Videoteka {
    public partial class FormWatchlist : TemplatedForm {

        public const int MOVIES_PER_PAGE = 10;
        public Control[] movies = new Control[MOVIES_PER_PAGE];

        public FormWatchlist() {
            FormClosing += FormWatchlist_Closing;
            InitializeComponent();
        }

        private void FormWatchlist_Load(object sender, EventArgs e) {
            Paint += FormWatchlist_Paint;
            CreateControlsFromTemplate(panelMovies.Controls[0], panelMovies, "movie", movies, MOVIES_PER_PAGE);
            for (int i = 0; i < MOVIES_PER_PAGE; i++) {
                var movie = movies[i];
                var curi = i;
                movie.Controls["buttonReviews"].Click += (object s, EventArgs ee) => {
                    new FormSingleMovie().Show();
                };
            }
        }

        private void FormWatchlist_Closing(Object sender, FormClosingEventArgs e) {
            Program.formWatchlist = null;
        }

        private void FormWatchlist_Paint(object sender, PaintEventArgs e) {
            DrawDividers(panelMovies, e.Graphics);
        }
    }
}
