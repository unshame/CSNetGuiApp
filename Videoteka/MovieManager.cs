using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka {

    public class MovieManager {

        public struct Genre {
            public int Id { get; set; }
            public string Value { get; set; }
            public Genre(int item1, string item2) {
                Id = item1;
                Value = item2;
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
            GenresBindingWithEmpty.Add(new Genre(-1, "Any"));
            for (int i = 0; i < Genres.Length; i++) {
                GenresBinding.Add(new Genre(i, Genres[i]));
                GenresBindingWithEmpty.Add(new Genre(i, Genres[i]));
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
                if (Program.db.DeleteMovie(id) > 0) {
                    return true;
                }
                else {
                    MessageBox.Show("Movie couldn't be deleted", "Failed to delete movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return false;
        }

    }
}
