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

        static ArrayList SortByBinding = new ArrayList() {
            new DropdownItemString("title", "Title"),
            new DropdownItemString("rating", "Rating"),
            new DropdownItemString("year", "Year"),
            new DropdownItemString("duration", "Duration")
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

        static public void AddSortByBinding(ComboBox dropdown) {
            AddBindingToDropdown(dropdown, SortByBinding);
        }

        static public void AddRatingBinding(ComboBox dropdown) {
            AddBindingToDropdown(dropdown, RatingBinding);
        }

        static public bool DeleteMovie(int id) {
            var confirmResult = MessageBox.Show(
                "Are you sure to delete this movie from the database?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo
            );
            if (confirmResult == DialogResult.Yes) {
                if (DB.DeleteMovie(id) > 0) {
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
                return DB.AddMovie(
                    title,
                    (int)year,
                    (int)genre,
                    (int)duration,
                    director,
                    stars,
                    description,
                    poster
                );
            }
            return -1;
        }

    }
}
