using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Videoteka {

    public class MovieManager {

        public struct Genre {
            public int Id { get; set; }
            public string Value { get; set; }
            public Genre(int id, string value) {
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

        public static List<Genre> GenresBinding = new List<Genre>();
        public static List<Genre> GenresBindingWithEmpty = new List<Genre>();

        public static void Init() {
            GenresBindingWithEmpty.Add(new Genre(0, "Any"));
            for (int i = 0; i < Genres.Length; i++) {
                GenresBinding.Add(new Genre(i + 1, Genres[i]));
                GenresBindingWithEmpty.Add(new Genre(i + 1, Genres[i]));
            }
        }

        static public void AddGenresToDropdown(ComboBox dropdown, bool includeEmpty = false) {
            BindingSource source = new BindingSource {
                DataSource = includeEmpty ? GenresBindingWithEmpty : GenresBinding
            };
            dropdown.DataSource = source.DataSource;
            dropdown.ValueMember = "Id";
            dropdown.DisplayMember = "Value";
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
                return id;
            }
            return -1;
        }

    }
}
