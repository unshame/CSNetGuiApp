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
    static class Program {

        public static FormLogin formLogin;
        public static FormMovies formMovies;
        public static FormWatchlist formWatchlist;
        public static FormReviews formReviews;
        public static FormAddMovie formAddMovie;

        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Profile.Init();
            MovieManager.Init();

            var host = args.Length > 0 ? args[0] : "localhost";
            var database = args.Length > 1 ? args[1] : "videoteka";
            var username = args.Length > 2 ? args[2] : "root";
            var password = args.Length > 3 ? args[3] : "";

            DB.Init(host, database, username, password);
            if (DB.ConnectionIsWorking()) {

                formLogin = new FormLogin();
                formMovies = new FormMovies();
                formReviews = new FormReviews();

                formWatchlist = null;
                formAddMovie = null;

                formMovies.Show();
                formMovies.LoadMovies();
                formLogin.ShowDialog();

                Application.Run();
            }
            else {
                Application.Exit();
            }
        }

        static public void OpenMovieForm(int id) {
            new FormSingleMovie(id).Show();
        }

        static public void OpenWatchListForm() {
            if(formWatchlist == null) {
                formWatchlist = new FormWatchlist();
                formWatchlist.Show();
            }
            formWatchlist.Focus();
        }

        static public void OpenAddMovie() {
            if (formAddMovie == null) {
                formAddMovie = new FormAddMovie();
                formAddMovie.Show();
            }
            formAddMovie.Focus();
        }

        static public void ShowErrorBox(string text, string title) {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
