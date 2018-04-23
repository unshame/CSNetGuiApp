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


        // Connection

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


        static public List<DropdownItemInt> GetGenres() {
            var query = "select * from genres";
            var cmd = new MySqlCommand(query, connection);
            var results = new List<DropdownItemInt>();
            if (OpenConnection()) {
                try {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        results.Add(new DropdownItemInt(
                            reader.GetInt32("genre_id"),
                            reader.GetString("genre_name")
                        ));
                    }
                    reader.Close();
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to get genres");
                }
            }
            CloseConnection();
            return results;
        }


        // Users

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


        // Both

        static private int GetCount(string table, string where, string modifier = "") {
            var query = "select count(*) from " + table +
                (modifier == "" ? "" : " " + modifier) +
                (where == "" ? "" : " where " + where);

            Debug.WriteLine(query);
            var cmd = new MySqlCommand(query, connection);
            var result = 0;
            if (OpenConnection()) {
                try {
                    var reader = cmd.ExecuteReader();
                    if (reader.Read()) {
                        result = (int)(long)reader[0];
                    }
                    reader.Close();
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to get " + table + " count");
                }
            }
            CloseConnection();
            return result;
        }


        // Movies

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
            cmd.Parameters.AddWithValue("@director", director);
            cmd.Parameters.AddWithValue("@stars", stars);
            cmd.Parameters.AddWithValue("@description", description);

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

        static public int DeleteMovie(int id) {
            var query = "delete from movies where id=" + id + ";";

            var result = 0;
            if (OpenConnection()) {
                result = new MySqlCommand(query, connection).ExecuteNonQuery();
            }
            CloseConnection();
            return result;
        }

        static public List<MovieData> GetMovies(int amount, int offset, string where = "", string sortBy = "", string order = "ASC") {
            if(sortBy == "rating") {
                sortBy = "if(rating_amount = 0, 1, rating_sum / rating_amount)";
            }
            var query = "select movies.id, title, year, genre, duration, director, stars, description, poster, rating_amount, rating_sum, rating, watchlist_id, is_watched from movies" +
                " left outer join reviews on reviews.movie_id = movies.id and reviews.user_id = " + Profile.UID +
                " left outer join watchlist on watchlist.movie_id = movies.id and watchlist.user_id = " + Profile.UID +
                (where == "" ? "" : " where " + where) + 
                (sortBy == "" ? "" : " order by " + sortBy + " " + order) + 
                " limit " + amount + " offset " + offset +  ";";
            Debug.WriteLine(query);
            var cmd = new MySqlCommand(query, connection);
            var results = new List<MovieData>();
            if (OpenConnection()) {
                try {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        var rating = Profile.IsLoggedIn.Checked && !(reader["rating"] is DBNull) ? reader.GetInt32("rating") : 0;
                        var watchlistId = Profile.IsLoggedIn.Checked && !(reader["watchlist_id"] is DBNull) ? reader.GetInt32("watchlist_id") : 0;
                        var isWatched = Profile.IsLoggedIn.Checked && !(reader["is_watched"] is DBNull) ? reader.GetBoolean("is_watched") : false;
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
                            ratingSum = reader.GetInt32("rating_sum"),
                            ratingOwn = rating,
                            watchlistId = watchlistId,
                            isWatched = isWatched
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
            return GetCount("movies", where,
                "left outer join reviews on reviews.movie_id = movies.id and reviews.user_id = " + Profile.UID +
                " left outer join watchlist on watchlist.movie_id = movies.id and watchlist.user_id = " + Profile.UID
            );
        }

        public static bool UpdateMovieRating(int movieId, int rating, int increment = 1) {
            var query = "update movies set rating_amount = rating_amount + " + increment + ", rating_sum = rating_sum + @rating where id = @movie_id";

            var cmd = new MySqlCommand(query, connection);
            Debug.WriteLine(cmd.CommandText);

            cmd.Parameters.AddWithValue("@movie_id", movieId);
            cmd.Parameters.AddWithValue("@rating", rating);

            var result = false;

            if (OpenConnection()) {
                try {
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to update movie rating");
                }
            }

            CloseConnection();
            return result;
        }


        // Reviews

        static public int AddReview(int movieId, int rating, string review) {
            var query = "INSERT INTO reviews " +
                "(movie_id, user_id, rating, review) " +
                "values (@movie_id, @user_id, @rating, @review);";
            Debug.WriteLine(query);

            var cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@movie_id", movieId);
            cmd.Parameters.AddWithValue("@user_id", Profile.UID);
            cmd.Parameters.AddWithValue("@rating", rating);
            cmd.Parameters.AddWithValue("@review", review);

            var result = -1;

            if (OpenConnection()) {
                try {
                    cmd.ExecuteNonQuery();
                    result = (int)cmd.LastInsertedId;
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to add review");
                }
            }
            CloseConnection();

            return result;
        }

        static public int UpdateReview(int movieId, int rating, string review) {
            var query = "update reviews set " +
                "rating = @rating, review = @review " +
                "where movie_id = @movie_id and user_id = @user_id;";
            Debug.WriteLine(query);

            var cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@movie_id", movieId);
            cmd.Parameters.AddWithValue("@user_id", Profile.UID);
            cmd.Parameters.AddWithValue("@rating", rating);
            cmd.Parameters.AddWithValue("@review", review);

            var result = 0;

            if (OpenConnection()) {
                try {
                    result = cmd.ExecuteNonQuery();
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to update review");
                }
            }
            CloseConnection();

            return result;
        }

        static public int DeleteReview(int id) {
            var query = "delete from reviews where id=" + id + ";";

            var result = 0;
            if (OpenConnection()) {
                result = new MySqlCommand(query, connection).ExecuteNonQuery();
            }
            CloseConnection();
            return result;
        }

        static public int DeleteReviewsOfMovie(int movieId) {
            var query = "delete from reviews where movie_id=" + movieId + ";";

            var result = 0;
            if (OpenConnection()) {
                result = new MySqlCommand(query, connection).ExecuteNonQuery();
            }
            CloseConnection();
            return result;
        }

        public static List<ReviewData> GetReviews(int amount, int offset, string where = "", string sortBy = "", string order = "ASC") {
            var query = "select reviews.id, user_id, movie_id, username, title, rating, review from reviews" +
                " inner join movies on reviews.movie_id = movies.id" +
                " inner join users on reviews.user_id = users.id" +
                (where == "" ? "" : " where " + where) +
                (sortBy == "" ? "" : " order by " + sortBy + " " + order) +
                " limit " + amount + " offset " + offset + ";";
            Debug.WriteLine(query);
            var cmd = new MySqlCommand(query, connection);
            var results = new List<ReviewData>();
            if (OpenConnection()) {
                try {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read()) {
                        results.Add(new ReviewData {
                            id = reader.GetInt32("id"),
                            userId = reader.GetInt32("user_id"),
                            movieId = reader.GetInt32("movie_id"),
                            title = reader.GetString("title"),
                            username = reader.GetString("username"),
                            rating = reader.GetInt32("rating"),
                            text = reader.GetString("review")
                        });
                    }
                    reader.Close();
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to get review");
                }
            }
            CloseConnection();
            return results;
        }

        static public int GetReviewsCount(string where = "") {
            return GetCount(
                "reviews",
                where,
                "inner join movies on reviews.movie_id = movies.id" +
                " inner join users on reviews.user_id = users.id"
           );
        }


        // Watchlist

        static public int AddToWatchlist(int movieId) {
            var query = "INSERT INTO watchlist " +
                "(movie_id, user_id, is_watched) " +
                "values (@movie_id, @user_id, false);";
            Debug.WriteLine(query);

            var cmd = new MySqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@movie_id", movieId);
            cmd.Parameters.AddWithValue("@user_id", Profile.UID);

            var result = -1;

            if (OpenConnection()) {
                try {
                    cmd.ExecuteNonQuery();
                    result = (int)cmd.LastInsertedId;
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to add movie to watchlist");
                }
            }
            CloseConnection();

            return result;
        }

        static public int RemoveFromWatchlist(int id) {
            var query = "delete from watchlist where watchlist_id=" + id + ";";

            var result = 0;
            if (OpenConnection()) {
                result = new MySqlCommand(query, connection).ExecuteNonQuery();
            }
            CloseConnection();
            return result;
        }

        static public bool ChangeWatchedStatus(int id, bool status) {
            var query = "update watchlist set is_watched = " + (status ? "true" : "false") + " where watchlist_id = @id";

            var cmd = new MySqlCommand(query, connection);
            Debug.WriteLine(cmd.CommandText);

            cmd.Parameters.AddWithValue("@id", id);

            var result = false;

            if (OpenConnection()) {
                try {
                    cmd.ExecuteNonQuery();
                    result = true;
                }
                catch (MySqlException e) {
                    Program.ShowErrorBox(e.Message, "Failed to update watched status");
                }
            }

            CloseConnection();
            return result;
        }


        // Filter

        public static string AddAnd(string query) {
            if(query != "") {
                return query + " AND ";
            }
            return query;
        }

        public static string FormatFilterMovies(string title, string director, string star, int duration, int genre, int year, int rating) {
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

        public static string FormatFilterReviews(string title, string username, int rating) {
            var filterStr = "";
            if (title != "") {
                filterStr += "INSTR(title, '" + MySqlHelper.EscapeString(title) + "') > 0";
            }
            if (username != "") {
                filterStr = AddAnd(filterStr);
                filterStr += "INSTR(username, '" + MySqlHelper.EscapeString(username) + "') > 0";
            }
            if (rating > 1) {
                filterStr = AddAnd(filterStr);
                filterStr += "reviews.rating >= " + rating;
            }
            Debug.WriteLine(filterStr);
            return filterStr;
        }

    }
}
