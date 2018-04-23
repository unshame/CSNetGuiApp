using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videoteka {
    public class MovieData {
        public int id;
        public string title;
        public int year;
        public int genre;
        public int duration;
        public string director;
        public string stars;
        public string description;
        public byte[] poster;
        public int ratingSum;
        public int ratingAmount;
        public int ratingOwn;
        public int watchlistId;
        public bool isWatched;

        public string FormatInfo() {
            return year + " - " + duration + " min - " + (genre <= BindingManager.Genres.Length ? BindingManager.Genres[genre - 1] : "Unknown");
        }

        public string FormatRating() {
            var ratingAverage = ratingAmount > 0 ? ratingSum / ratingAmount : 0;
            return ratingAverage + "/10 stars - " + ratingAmount + " reviews" + (ratingOwn != 0 ? " - you rated " + ratingOwn : "");
        }
    }
}
