using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka {
    public class ReviewManager {
        public static int AddReview(int movieId, int rating, string review) {
            if (!Profile.IsLoggedIn.Checked) return -1;
            var id = DB.AddReview(movieId, rating, review);
            if(id != -1) {
                DB.UpdateMovieRating(movieId, rating);
            }
            Program.ReloadForms();
            return id;
        }

        public static bool DeleteReview(int id) {
            if (!Profile.IsLoggedIn.Checked) return false;

            var confirmResult = MessageBox.Show(
                "Are you sure you want to delete this review?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo
            );

            if (confirmResult == DialogResult.Yes) {
                var reviewsData = DB.GetReviews(1, 0, "reviews.id = " + id);
                if (reviewsData.Count > 0 && DB.DeleteReview(id) > 0) {
                    DB.UpdateMovieRating(reviewsData[0].movieId, -reviewsData[0].rating, -1);
                    Program.ReloadForms();
                    return true;
                }
                Program.ShowErrorBox("Review couldn't be deleted", "Failed to delete review");
            }
            return false;
        }
    }
}
