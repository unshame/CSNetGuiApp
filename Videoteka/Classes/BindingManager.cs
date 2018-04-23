using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Videoteka {
    public static class BindingManager {
        class DropdownItemInt {
            public int Id { get; set; }
            public string Value { get; set; }
            public DropdownItemInt(int id, string value) {
                Id = id;
                Value = value;
            }
        }

        class DropdownItemString {
            public string Id { get; set; }
            public string Value { get; set; }
            public DropdownItemString(string id, string value) {
                Id = id;
                Value = value;
            }
        }

        public static string[] Genres = new string[] {
            "Comedy",
            "Sci-fi",
            "Horror",
            "Romance",
            "Action",
            "Thriller",
            "Drama",
            "Mystery",
            "Crime",
            "Adventure",
            "Fantasy",
            "Comedy-romance",
            "Action-comedy"
        };

        static ArrayList GenresBinding = new ArrayList();
        static ArrayList GenresBindingWithEmpty = new ArrayList();

        static ArrayList OrderingBinding = new ArrayList() {
            new DropdownItemString("ASC", "Accending"),
            new DropdownItemString("DESC", "Descending")
        };

        static ArrayList SortByMoviesBinding = new ArrayList() {
            new DropdownItemString("title", "Title"),
            new DropdownItemString("rating", "Rating"),
            new DropdownItemString("year", "Year"),
            new DropdownItemString("duration", "Duration")
        };

        static ArrayList SortByWatchlistBinding = new ArrayList() {
            new DropdownItemString("watchlist_id", "Added Date"),
            new DropdownItemString("title", "Title"),
            new DropdownItemString("rating", "Rating"),
            new DropdownItemString("year", "Year"),
            new DropdownItemString("duration", "Duration")
        };

        static ArrayList SortByReviewsBinding = new ArrayList() {
            new DropdownItemString("title", "Movie"),
            new DropdownItemString("username", "Author"),
            new DropdownItemString("rating", "Rating")
        };

        static ArrayList RatingBinding = new ArrayList();

        public static void Init() {
            GenresBindingWithEmpty.Add(new DropdownItemInt(0, "Any"));
            for (int i = 0; i < Genres.Length; i++) {
                GenresBinding.Add(new DropdownItemInt(i + 1, Genres[i]));
                GenresBindingWithEmpty.Add(new DropdownItemInt(i + 1, Genres[i]));
            }
            for (int i = 1; i <= 10; i++) {
                RatingBinding.Add(new DropdownItemInt(i, i + (i == 10 ? "" : "+")));
            }
        }

        static void AddBindingToDropdown(ComboBox dropdown, ArrayList bindData) {
            BindingSource source = new BindingSource {
                DataSource = bindData
            };
            dropdown.DataSource = source.DataSource;
            dropdown.ValueMember = "Id";
            dropdown.DisplayMember = "Value";
        }

        static public void AddGenresToDropdown(ComboBox dropdown, bool includeEmpty = false) {
            AddBindingToDropdown(dropdown, includeEmpty ? GenresBindingWithEmpty : GenresBinding);
        }

        static public void AddOrderingBinding(ComboBox dropdown) {
            AddBindingToDropdown(dropdown, OrderingBinding);
        }

        static public void AddSortByMoviesBinding(ComboBox dropdown) {
            AddBindingToDropdown(dropdown, SortByMoviesBinding);
        }

        static public void AddSortByWatchlistBinding(ComboBox dropdown) {
            AddBindingToDropdown(dropdown, SortByWatchlistBinding);
        }

        static public void AddSortByReviewsBinding(ComboBox dropdown) {
            AddBindingToDropdown(dropdown, SortByReviewsBinding);
        }

        static public void AddRatingBinding(ComboBox dropdown) {
            AddBindingToDropdown(dropdown, RatingBinding);
        }
    }
}
