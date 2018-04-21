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

        public string FormatInfo() {
            return year + " - " + duration + " min - " + (genre < MovieManager.Genres.Length ? MovieManager.Genres[genre] : "Unknown");
        }

        public string FormatRating() {
            var ratingAverage = ratingAmount > 0 ? ratingSum / ratingAmount : 0;
            return ratingAverage + "/10 stars - " + ratingAmount + " reviews";
        }
    }
}