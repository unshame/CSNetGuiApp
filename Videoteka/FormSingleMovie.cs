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
    public partial class FormSingleMovie : TemplatedForm {

        public const int REVIEWS_PER_PAGE = 10;
        public Control[] reviews = new Control[REVIEWS_PER_PAGE];

        public FormSingleMovie() {
            InitializeComponent();
        }

        private void FormSingleMovie_Load(object sender, EventArgs e) {
            Paint += FormSingleMovie_Paint;
            CreateControlsFromTemplate(panelReviews.Controls[0], panelReviews, "review", reviews, REVIEWS_PER_PAGE);

            labelRatingValue.DataBindings.Add("Text", reviewRating, "Value");
            buttonDeleteMovie.DataBindings.Add("Visible", Profile.IsAdmin, "Checked");
        }

        private void FormSingleMovie_Paint(object sender, PaintEventArgs e) {
            DrawDividers(panelReviews, e.Graphics);
        }

        private void buttonDeleteMovie_Click(object sender, EventArgs e) {
            var confirmResult = MessageBox.Show(
                "Are you sure to delete this movie from the database?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo
            );
            Debug.WriteLine(confirmResult);
        }
    }
}
