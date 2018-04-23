using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Videoteka {

    public class MovieManager {

        static public string InWatchlistText = "In Watchlist";
        static public string NotInWatchlistText = "Add to Watchlist";

        static public string WatchedText = "Watched";
        static public string NotWatchedText = "Not Watched";

        static public bool DeleteMovie(int id) {
            if (!Profile.IsAdmin.Checked) return false;

            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this movie from the database?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo
            );
            if (confirmResult == DialogResult.Yes) {
                if (DB.DeleteMovie(id) > 0) {
                    var reviewsDeleted = DB.DeleteReviewsOfMovie(id);
                    MessageBox.Show("Deleted one movie and " + reviewsDeleted + " reviews");
                    Program.CloseMovieForm(id);
                    Program.ReloadForms();
                    return true;
                }
                else {
                    Program.ShowErrorBox("Movie couldn't be deleted", "Failed to delete movie");
                }
            }
            return false;
        }

        public static int AddMovie(string title, decimal year, object genre, decimal duration, string director, string stars, string description, string posterPath) {
            if (!Profile.IsAdmin.Checked) return -1;


            if (!VerifyAddParams(title, genre)) return -1;

            byte[] poster = null;
            if (posterPath != "") {
                poster = ImageManager.OpenImage(posterPath);
                if (poster == null) return -1;
            }
            var id = DB.AddMovie(
                title,
                (int)year,
                (int)genre,
                (int)duration,
                director,
                stars,
                description,
                poster
            );
            if (id != -1) {
                Program.ReloadForms();
            }
            return id;
        }

        public static bool UpdateMovie(int id, string title, decimal year, object genre, decimal duration, string director, string stars, string description, byte[] poster, string posterPath) {
            if (!Profile.IsAdmin.Checked) return false;

            if (!VerifyAddParams(title, genre)) return false;

            if(posterPath == "") {
                poster = null;
            }
            else if (posterPath != null) {
                poster = ImageManager.OpenImage(posterPath);
                if (poster == null) return false;
            }

            var success = DB.UpdateMovie(
                id,
                title,
                (int)year,
                (int)genre,
                (int)duration,
                director,
                stars,
                description,
                poster
            ) > 0;
            if (success) {
                Program.ReloadForms();
            }
            return success;
        }

        private static bool VerifyAddParams(string title, object genre) {
            var errorTitle = "Failed to add movie";
            if (title == "") {
                Program.ShowErrorBox("Please enter title", errorTitle);
                return false;
            }
            if (genre == null) {
                Program.ShowErrorBox("Please select genre", errorTitle);
                return false;
            }
            return true;
        }

        public static int AddToWatchList(int movieId) {
            if (!Profile.IsLoggedIn.Checked) return -1;

            var id = DB.AddToWatchlist(movieId);
            if (id != -1) {
                Program.ReloadForms();
            }

            return id;
        }

        public static bool RemoveFromWatchlist(int id) {
            if (!Profile.IsLoggedIn.Checked) return false;

            if (DB.RemoveFromWatchlist(id) > 0) {
                Program.ReloadForms();
                return true;
            }

            return false;
        }

        public static bool SetWatchedStatus(int id, bool status) {
            if (!Profile.IsLoggedIn.Checked) return false;

            if (DB.ChangeWatchedStatus(id, status)) {
                Program.ReloadForms();
                return true;
            }

            return false;
        }

    }
}
