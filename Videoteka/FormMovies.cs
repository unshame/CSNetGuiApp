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
    public partial class FormMovies : Form {

        public const int MOVIES_PER_PAGE = 10;
        public Control[] movies = new Control[MOVIES_PER_PAGE];

        public FormMovies() {
            StartPosition = FormStartPosition.Manual;
            FormClosed += FormMovies_Closed;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Paint += Movies_Paint;

            var template = panelMovies.Controls[0];
            var offset = template.Location.Y + template.Height;
            for (int i = 0; i < MOVIES_PER_PAGE; i++) {
                var movie = new GroupBox {
                    Width = template.Width,
                    Height = template.Height,
                    Location = new Point(template.Location.X, offset * i + template.Location.Y),
                    Name = "movie" + i,
                    Text = "Movie " + i
                };

                foreach (Control control in template.Controls) {
                    Control newControl = null;
                    if(control is Label) {
                        newControl = new Label {
                            Text = control.Text,
                            Width = control.Width,
                            Height = control.Height,
                            Location = control.Location,
                            Font = control.Font,
                            Name = control.Name + i
                        };
                        movie.Controls.Add(newControl);
                    }
                    else if(control is Button) {
                        newControl = new Button {
                            Text = control.Text,
                            Width = control.Width,
                            Height = control.Height,
                            Location = control.Location,
                            Name = control.Name + i
                        };
                    }
                    else if(control is PictureBox) {
                        newControl = new PictureBox {
                            Text = control.Text,
                            Width = control.Width,
                            Height = control.Height,
                            Location = control.Location,
                            Name = control.Name + i
                        };
                    }
                    if (newControl != null) {
                        movie.Controls.Add(newControl);
                    }
                }
                movie.Hide();
                movies[i] = movie;
                panelMovies.Controls.Add(movie);
            }
            panelMovies.Controls.Remove(template);
            template.Dispose();

        }

        private void FormMovies_Closed(Object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void Movies_Paint(object sender, PaintEventArgs e) {
            Pen blackpen = new Pen(Color.Gray, 1);
            Graphics g = e.Graphics;

            var x1 = new Point(panelMovies.Location.X, panelMovies.Location.Y - 1);
            var x2 = new Point(panelMovies.Location.X + panelMovies.Width, panelMovies.Location.Y - 1);
            var x3 = new Point(panelMovies.Location.X, panelMovies.Location.Y + panelMovies.Height);
            var x4 = new Point(panelMovies.Location.X + panelMovies.Width, panelMovies.Location.Y + panelMovies.Height);
            g.DrawLine(blackpen, x1, x2);
            g.DrawLine(blackpen, x3, x4);

            g.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            templatePoster.Location = new Point(10, 20);
        }

        private void groupFilter_Enter(object sender, EventArgs e) {

        }

        private void buttonLogin_Click(object sender, EventArgs e) {
            Program.formLogin.ShowDialog();
        }

        private void buttonWatchlist_Click(object sender, EventArgs e) {
            Program.OpenWatchList();
        }

        private void buttonAddMovie_Click(object sender, EventArgs e) {
            Program.formAddMovie.ShowDialog();
        }

        private void buttonAllReviews_Click(object sender, EventArgs e) {
            Hide();
            Program.formReviews.Location = Location;
            Program.formReviews.Show();
        }
    }
}
