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

        private void FormAddMovie_Load(object sender, EventArgs e) {
            FormClosing += FormAddMovie_Closing;
            MovieManager.AddGenresToDropdown(addGenre);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result = addPosterDialog.ShowDialog();
            addPosterPath.Text = addPosterDialog.FileName;
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            byte[] poster = null;
            var errorTitle = "Failed to add movie";
            if (addPosterPath.Text != "") {
                try {
                    poster = File.ReadAllBytes(addPosterPath.Text);
                }
                catch {
                    MessageBox.Show("Failed to open poster image", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (addTitle.Text == "") {
                MessageBox.Show("Please enter title", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (addGenre.SelectedValue == null) {
                MessageBox.Show("Please select genre", errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                var id = Program.db.AddMovie(
                    addTitle.Text,
                    (int)addYear.Value,
                    (int)addGenre.SelectedValue,
                    (int)addDuration.Value,
                    addDirector.Text,
                    addStars.Text,
                    addDescription.Text,
                    poster
                );
                if(id != -1) {
                    new FormSingleMovie((int)id).Show();
                    Close();
                }
            }
        }

        private void FormAddMovie_Closing(Object sender, FormClosingEventArgs e) {
            Program.formAddMovie = null;
        }
    }
}
