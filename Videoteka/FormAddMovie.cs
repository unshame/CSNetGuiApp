using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka {
    public partial class FormAddMovie : Form {
        public FormAddMovie() {
            InitializeComponent();
        }

        private void FormAddMovie_Load(object sender, EventArgs e) {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            DialogResult result = addPosterDialog.ShowDialog();
            addPosterPath.Text = addPosterDialog.FileName;
        }
    }
}
