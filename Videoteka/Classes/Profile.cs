using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Videoteka {
    public class Profile {
        public static CheckBox IsLoggedIn;
        public static CheckBox IsAdmin;

        public static string Username;
        public static int UID;

        public static void Init() {
            IsLoggedIn = new CheckBox();
            IsAdmin = new CheckBox();
        }

        public static Binding GetFormattedBindingLoggedIn(string prop) {
            var binding = new Binding(prop, IsLoggedIn, "Checked", true);
            binding.Format += FormatLogInStatus;
            return binding;
        }

        private static void FormatLogInStatus(object s, ConvertEventArgs ee) {
            ee.Value = (bool) ee.Value ? "Logout" : "Login";
        }

        public static bool Login(string username, string password) {
            var result = DB.Login(username, password);
            if (result != null) {
                UID = result.Item1;
                Username = result.Item2;
                IsAdmin.Checked = result.Item3;
                IsLoggedIn.Checked = true;
                Program.ReloadAllMovieForms();
                return true;
            }
            return false;
        }

        public static bool Register(string username, string password) {
            if(DB.Register(username, password)) {
                return Login(username, password);
            }
            return false;
        }

        public static void Logout() {
            Username = "";
            UID = -1;
            IsLoggedIn.Checked = false;
            IsAdmin.Checked = false;
            Program.CloseAddMovieForm();
            Program.CloseWatchListForm();
            Program.ReloadAllMovieForms();
        }
    }

}
