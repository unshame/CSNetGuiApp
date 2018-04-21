using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Videoteka {
    static class DB {
        static private MySqlConnection connection;

        static public void Init(string server, string database, string uid, string password = "") {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + (password == "" ? ("PASSWORD=" + password + ";") : "");

            connection = new MySqlConnection(connectionString);
        }

        static private bool OpenConnection() {
            try {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) {
                Program.ShowErrorBox(ex.Message, "Connection Error (" + ex.Number + ")");

                return false;
            }
        }

        static private bool CloseConnection() {
            try {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        static public bool ConnectionIsWorking() {
            if (OpenConnection()) {
                CloseConnection();
                return true;
            }
            return false;
        }


        static public Tuple<int, string, bool> Login(string username, string password) {
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

        static public bool Register(string username, string password) {
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
                    Debug.WriteLine(e.Message);
                    result = false;
                }

                CloseConnection();

            }
            return result;
        }

        static public int AddMovie(string title, int year, int genre, int duration, string director, string stars, string description, byte[] poster) {
            var query = "INSERT INTO movies (title, year, genre, duration, director, stars, description, poster) values ('" +
                MySqlHelper.EscapeString(title) +
                "', " + year + ", " + genre + ", " + duration + ", '" +
                MySqlHelper.EscapeString(director) + "', '" +
                MySqlHelper.EscapeString(stars) + "', '" +
                MySqlHelper.EscapeString(description) + "', " +
                "@poster" + 
           ");";

            var cmd = new MySqlCommand(query, connection);
            var paramPoster = poster == null ? new MySqlParameter("@poster", MySqlDbType.Blob) : new MySqlParameter("@poster", MySqlDbType.Blob, poster.Length) {
                Value = poster
            };

            cmd.Parameters.Add(paramPoster);

            var result = -1;

            if (OpenConnection()) {
                try {
                    cmd.ExecuteNonQuery();
                    result = (int)cmd.LastInsertedId;
                }
                catch (MySqlException e) {
                    Debug.WriteLine(e.Message);
                }

                CloseConnection();

            }
            return result;
        }

        static public List<MovieData> GetMovies(int amount, int offset, string where = "") {
            var query = "select * from movies" + (where == "" ? "" : " where " + where) + " limit " + amount + " offset " + offset +  ";";
            var cmd = new MySqlCommand(query, connection);
            var results = new List<MovieData>();
            if (OpenConnection()) {
                try {
                    cmd.ExecuteNonQuery();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        results.Add(new MovieData {
                            id = reader.GetInt32("id"),
                            title = reader.GetString("title"),
                            year = reader.GetInt32("year"),
                            genre = reader.GetInt32("genre"),
                            duration = reader.GetInt32("duration"),
                            director = reader.GetString("director"),
                            stars = reader.GetString("stars"),
                            description = reader.GetString("description"),
                            poster = reader["poster"] is DBNull ? null : (byte[])reader["poster"],
                            ratingAmount = reader.GetInt32("rating_amount"),
                            ratingSum = reader.GetInt32("rating_sum")
                        });
                    }
                    reader.Close();
                    CloseConnection();
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to add movie");
                }
            }
            return results;
        }

        static public int DeleteMovie(int id) {
            var query = "delete from movies where id=" + id + ";";
            if (OpenConnection()) {
                var results = new MySqlCommand(query, connection).ExecuteNonQuery();
                CloseConnection();
                return results;
            }
            return 0;

        }

    }
}
