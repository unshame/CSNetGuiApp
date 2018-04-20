using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka {
    static class Program {

        static public FormLogin formLogin;
        static public FormMovies formMovies;
        static public FormWatchlist formWatchlist;
        static public FormReviews formReviews;
        static public FormAddMovie formAddMovie;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
