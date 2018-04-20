using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Videoteka {
    class DB {
        private MySqlConnection connection;

        //Constructor
        public DB(string server, string database, string uid, string password = "") {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + (password == "" ? ("PASSWORD=" + password + ";") : "");

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection() {
            try {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number) {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection() {
            try {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        public Tuple<int, string, bool> Login(string username, string password) {
            MySqlHelper.EscapeString(password);
            var query = "select id, username, password, is_admin from users where username = '" +
                MySqlHelper.EscapeString(username) + 
                "' AND password = SHA2('" +
                MySqlHelper.EscapeString(password) + 
                "', 256);";

            Tuple<int, string, bool> result = null;

            if (OpenConnection()) {
                var reader = new MySqlCommand(query, connection).ExecuteReader();
                
                if (reader.Read()) {
                    result = new Tuple<int, string, bool>(reader.GetInt32("id"), reader.GetString("username"), reader.GetBoolean("is_admin"));
                }

                reader.Close();
                CloseConnection();

            }
            return result;
        }

        public bool Register(string username, string password) {
            MySqlHelper.EscapeString(password);
            var query = "INSERT INTO users (username, password, is_admin) values ('" +
                MySqlHelper.EscapeString(username) +
                "', SHA2('" +
                MySqlHelper.EscapeString(password) +
                "', 256), false);";

            var result = true;

            if (OpenConnection()) {
                try {
                    new MySqlCommand(query, connection).ExecuteNonQuery();
                }
                catch(MySqlException e) {
                    result = false;
                }

                CloseConnection();

            }
            return result;
        }
    }
}
