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
    public partial class FormReviews : Form {
        public FormReviews() {
            StartPosition = FormStartPosition.Manual;
            FormClosed += FormReviews_Closed;
            InitializeComponent();
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
            Program.OpenWatchList();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            Program.formLogin.ShowDialog();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e) {
            Program.formAddMovie.ShowDialog();
        }
    }
}
