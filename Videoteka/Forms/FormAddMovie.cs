using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Videoteka {
    public partial class FormAddMovie : Form {

        public FormAddMovie() {
            InitializeComponent();
        }

        // Events
        private void OnLoad(object sender, EventArgs e) {
            FormClosing += OnClosing;
            MovieManager.AddGenresToDropdown(addGenre);
        }

        private void OnClosing(Object sender, FormClosingEventArgs e) {
            Program.formAddMovie = null;
        }

        private void addPosterButton_Click(object sender, EventArgs e) {
            DialogResult result = addPosterDialog.ShowDialog();
            addPosterPath.Text = addPosterDialog.FileName;
        }

        // Click events
        private void buttonAdd_Click(object sender, EventArgs e) {
            var id = MovieManager.AddMovie(
                addTitle.Text,
                addYear.Value,
                addGenre.SelectedValue,
                addDuration.Value,
                addDirector.Text,
                addStars.Text,
                addDescription.Text,
                addPosterPath.Text
            );
            if (id != -1) {
                Program.OpenMovieForm(id);
                Close();
            }
        }
    }
}
