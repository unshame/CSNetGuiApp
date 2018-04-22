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

        static public bool DeleteMovie(int id) {
            if (!Profile.IsAdmin.Checked) return false;

            var confirmResult = MessageBox.Show(
                "Are you sure to delete this movie from the database?",
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

            byte[] poster = null;
            var errorTitle = "Failed to add movie";
            if (posterPath != "") {
                try {
                    poster = File.ReadAllBytes(posterPath);
                }
                catch {
                    Program.ShowErrorBox("Failed to open poster image", errorTitle);
                    return -1;
                }
            }
            if (title == "") {
                Program.ShowErrorBox("Please enter title", errorTitle);
            }
            else if (genre == null) {
                Program.ShowErrorBox("Please select genre", errorTitle);
            }
            else {
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
                    return id;
                }
            }
            return -1;
        }

    }
}
