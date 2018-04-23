using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Videoteka {

    public class DropdownItem<T> {
        public T Id { get; set; }
        public string Value { get; set; }
        public DropdownItem(T id, string value) {
            Id = id;
            Value = value;
        }
    }

    public static class BindingManager {

        public static Dictionary<int, DropdownItem<int>> Genres;

        static ArrayList GenresBinding = new ArrayList();
        static ArrayList GenresBindingWithEmpty = new ArrayList();

        static ArrayList OrderingBinding = new ArrayList() {
            new DropdownItem<string>("ASC", "Accending"),
            new DropdownItem<string>("DESC", "Descending")
        };

        static ArrayList SortByMoviesBinding = new ArrayList() {
            new DropdownItem<string>("title", "Title"),
            new DropdownItem<string>("rating", "Rating"),
            new DropdownItem<string>("year", "Year"),
            new DropdownItem<string>("duration", "Duration")
        };

        static ArrayList SortByWatchlistBinding = new ArrayList() {
            new DropdownItem<string>("watchlist_id", "Date Added"),
            new DropdownItem<string>("title", "Title"),
            new DropdownItem<string>("rating", "Rating"),
            new DropdownItem<string>("year", "Year"),
            new DropdownItem<string>("duration", "Duration")
        };

        static ArrayList SortByReviewsBinding = new ArrayList() {
            new DropdownItem<string>("id", "Date Added"),
            new DropdownItem<string>("title", "Movie"),
            new DropdownItem<string>("username", "Author"),
            new DropdownItem<string>("rating", "Rating")
        };

        static ArrayList RatingBinding = new ArrayList();

        public static void Init() {
            Genres = DB.GetGenres();
            GenresBindingWithEmpty.Add(new DropdownItem<int>(0, "Any"));
            foreach(var genre in Genres) { 
                GenresBinding.Add(genre.Value);
                GenresBindingWithEmpty.Add(genre.Value);
            }
            for (int i = 1; i <= 10; i++) {
                RatingBinding.Add(new DropdownItem<int>(i, i + (i == 10 ? "" : "+")));
            }
        }


        public static Binding GetFormattedBindingLoggedIn(string prop) {
            var binding = new Binding(prop, Profile.IsLoggedIn, "Checked", true);
            binding.Format += (object s, ConvertEventArgs ee) => {
                ee.Value = (bool)ee.Value ? "Logout" : "Login";
            };
            return binding;
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
