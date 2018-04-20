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
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Login_Load(object sender, EventArgs e) {

        }

        private void buttonGuest_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            if (Profile.Login(textBoxUsername.Text, textBoxPassword.Text)) {
                Close();
            }
            else {
                MessageBox.Show("Invalid username or password", "Failed to login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e) {
            if(textBoxPassword.Text == "" || textBoxUsername.Text == "") {
                MessageBox.Show("Username and password must not be an empty string", "Failed to register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Profile.Register(textBoxUsername.Text, textBoxPassword.Text)) {
                Close();
            }
            else {
                MessageBox.Show("Username already exists", "Failed to register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
