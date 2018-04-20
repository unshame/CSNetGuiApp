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
    public partial class FormWatchlist : Form {
        public FormWatchlist() {
            FormClosing += FormWatchlist_Closing;
            InitializeComponent();
        }

        private void FormWatchlist_Load(object sender, EventArgs e) {

        }

        private void FormWatchlist_Closing(Object sender, FormClosingEventArgs e) {
            Program.formWatchlist = null;
        }
    }
}
