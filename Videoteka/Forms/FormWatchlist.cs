using System;
using System.Windows.Forms;

namespace Videoteka {
    public partial class FormWatchlist : TemplatedForm {

        public const int MOVIES_PER_PAGE = 10;
        public Control[] movies = new Control[MOVIES_PER_PAGE];

        public FormWatchlist() {
            FormClosing += OnClosing;
            InitializeComponent();
        }

        // Events
        private void OnLoad(object sender, EventArgs e) {
            Paint += OnPaint;
            CreateControlsFromTemplate(panelMovies.Controls[0], panelMovies, "movie", movies, MOVIES_PER_PAGE);
            for (int i = 0; i < MOVIES_PER_PAGE; i++) {
                var movie = movies[i];
                var curi = i;
                movie.Controls["buttonReviews"].Click += (object s, EventArgs ee) => {
                    Program.OpenMovieForm(0);
                };
            }
        }

        private void OnClosing(Object sender, FormClosingEventArgs e) {
            Program.formWatchlist = null;
        }

        private void OnPaint(object sender, PaintEventArgs e) {
            DrawDividers(panelMovies, e.Graphics);
        }
    }
}
