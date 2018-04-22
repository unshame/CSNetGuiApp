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

        public static Dictionary<int, FormSingleMovie> openedMovieForms = new Dictionary<int, FormSingleMovie>();

        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Profile.Init();
            BindingManager.Init();

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
            if (openedMovieForms.ContainsKey(id)) {
                openedMovieForms[id].LoadData();
                openedMovieForms[id].Focus();
            }
            else { 
                var movieForm = new FormSingleMovie(id);
                openedMovieForms.Add(id, movieForm);
                movieForm.Show();
            }
        }

        static public void CloseMovieForm(int id) {
            if (openedMovieForms.ContainsKey(id)) {
                openedMovieForms[id].Close();
            }
        }

        static public void ReloadAllMovieForms() {
            var forms = new List<FormSingleMovie>();
            foreach(var formPair in openedMovieForms) {
                forms.Add(formPair.Value);
            }
            for(int i = 0; i < forms.Count; i++) {
                forms[i].LoadData();
            }
        }

        static public void RemoveFormFromOpened(FormSingleMovie form) {
            if (openedMovieForms.ContainsKey(form.id)) {
                openedMovieForms.Remove(form.id);
            }
        }


        static public void OpenWatchListForm() {
            if(formWatchlist == null) {
                formWatchlist = new FormWatchlist();
                formWatchlist.Show();
            }
            formWatchlist.Focus();
        }

        static public void CloseWatchListForm() {
            if (formWatchlist != null) {
                formWatchlist.Close();
            }                
        }

        static public void OpenAddMovieForm() {
            if (formAddMovie == null) {
                formAddMovie = new FormAddMovie();
                formAddMovie.Show();
            }
            formAddMovie.Focus();
        }

        static public void CloseAddMovieForm() {
            if (formAddMovie != null) {
                formAddMovie.Close();
            }
        }

        static public void ReloadForms() {
            if (formMovies.Visible) {
                formMovies.LoadMovies();
            }
            if (formReviews.Visible) {
                formReviews.LoadReviews();
            }
            ReloadAllMovieForms();
        }

        static public void ShowErrorBox(string text, string title) {
            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
