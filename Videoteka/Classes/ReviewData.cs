using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka {
    public class ReviewData {
        public int id;
        public int userId;
        public string username;
        public string title;
        public int movieId;
        public int rating;
        public string text;

        public string FormatRating() {
            return rating + "/10 stars";
        }

        public string FormatUsername() {
            return username + "'s Review";
        }
    }
}
