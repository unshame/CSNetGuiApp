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

        public static DB db;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Profile.Init();

            db = new DB("localhost", "videoteka", "root");

            formLogin = new FormLogin();
            formMovies = new FormMovies();
            formWatchlist = null;
            formReviews = new FormReviews();
            formAddMovie = new FormAddMovie();
            formMovies.Show();
            formLogin.ShowDialog();
            Application.Run();
        }

        static public void OpenMovieForm() {
            var form = new FormSingleMovie();
            form.Show();
        }

        static public void OpenWatchList() {
            if(formWatchlist == null) {
                formWatchlist = new FormWatchlist();
                formWatchlist.Show();
            }
            formWatchlist.Focus();
        }

        
    }
}
