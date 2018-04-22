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
            }
            CloseConnection();
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
            }
            CloseConnection();
            return result;
        }

        static public int AddMovie(string title, int year, int genre, int duration, string director, string stars, string description, byte[] poster) {
            var query = "INSERT INTO movies " + 
                "(title, year, genre, duration, director, stars, description, poster) " +
                "values (@title, @year, @genre, @duration, @director, @stars, @description, @poster);";

            var cmd = new MySqlCommand(query, connection);
            var paramPoster = new MySqlParameter("@poster", MySqlDbType.Blob);
            if (poster != null) {
                paramPoster.Size = poster.Length;
                paramPoster.Value = poster;
            }

            cmd.Parameters.Add(paramPoster);
            cmd.Parameters.AddWithValue("@title", title);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@genre", genre);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@director", MySqlHelper.EscapeString(director));
            cmd.Parameters.AddWithValue("@stars", MySqlHelper.EscapeString(stars));
            cmd.Parameters.AddWithValue("@description", MySqlHelper.EscapeString(description));

            var result = -1;

            if (OpenConnection()) {
                try {
                    cmd.ExecuteNonQuery();
                    result = (int)cmd.LastInsertedId;
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to add movie");
                }
            }
            CloseConnection();
            return result;
        }

        static public List<MovieData> GetMovies(int amount, int offset, string where = "", string sortBy = "", string order = "ASC") {
            if(sortBy == "rating") {
                sortBy = "if(rating_amount = 0, 1, rating_sum / rating_amount)";
            }
            var query = "select * from movies" + 
                (where == "" ? "" : " where " + where) + 
                (sortBy == "" ? "" : " order by " + sortBy + " " + order) + 
                " limit " + amount + " offset " + offset +  ";";
            Debug.WriteLine(query);
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
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to get movies");
                }
            }
            CloseConnection();
            return results;
        }

        static public int GetMoviesCount(string where = "") {
            var query = "select count(*) from movies" +
                (where == "" ? "" : " where " + where);

            Debug.WriteLine(query);
            var cmd = new MySqlCommand(query, connection);
            var result = 0;
            if (OpenConnection()) {
                try {
                    cmd.ExecuteNonQuery();
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) {
                        result = (int)(long)reader[0];
                    }
                    reader.Close();
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to get movies");
                }
            }
            CloseConnection();
            return result;
        }

        static public int DeleteMovie(int id) {
            var query = "delete from movies where id=" + id + ";";
            if (OpenConnection()) {
                var results = new MySqlCommand(query, connection).ExecuteNonQuery();
                CloseConnection();
                return results;
            }
            CloseConnection();
            return 0;

        }

        static string AddAnd(string query) {
            if(query != "") {
                return query + " AND ";
            }
            return query;
        }

        public static string FormatFilter(string title, string director, string star, int duration, int genre, int year, int rating) {
            var filterStr = "";
            if (title != "") {
                filterStr += "INSTR(title, '" + MySqlHelper.EscapeString(title) + "') > 0";
            }
            if (director != "") {
                filterStr = AddAnd(filterStr);
                filterStr += "INSTR(director, '" + MySqlHelper.EscapeString(director) + "') > 0";
            }
            if (star != "") {
                filterStr = AddAnd(filterStr);
                filterStr += "INSTR(stars, '" + MySqlHelper.EscapeString(star) + "') > 0";
            }
            if(duration > 1) {
                filterStr = AddAnd(filterStr);
                filterStr += "duration >= " + duration;
            }
            if (genre > 0) {
                filterStr = AddAnd(filterStr);
                filterStr += "genre = " + genre;
            }
            if (year > 1950) {
                filterStr = AddAnd(filterStr);
                filterStr += "year >= " + year;
            }
            if (rating > 1) {
                filterStr = AddAnd(filterStr);
                filterStr += "if(rating_amount = 0, 1, rating_sum / rating_amount) >= " + rating;
            }
            Debug.WriteLine(filterStr);
            return filterStr;
        }

    }
}
