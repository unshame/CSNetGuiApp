using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Videoteka {
    public partial class FormLogin : Form {

        public FormLogin() {
            InitializeComponent();
            AcceptButton = buttonLogin;
        }

        // Click events
        private void buttonGuest_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            if (Profile.Login(textBoxUsername.Text, textBoxPassword.Text)) {
                Close();
                if (Profile.IsAdmin.Checked) {
                    DB.AddMoviesFromJson("movies.json");
                }
            }
            else {
                Program.ShowErrorBox("Invalid username or password", "Failed to login");
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e) {
            if(textBoxPassword.Text == "" || textBoxUsername.Text == "") {
                Program.ShowErrorBox("Username and password must not be an empty string", "Failed to register");
                return;
            }
            if (Profile.Register(textBoxUsername.Text, textBoxPassword.Text)) {
                Close();
            }
            else {
                Program.ShowErrorBox("Username already exists", "Failed to register");
            }
        }
    }
}
