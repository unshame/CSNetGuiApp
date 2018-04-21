namespace Videoteka {
    partial class FormSingleMovie {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSingleMovie));
            this.groupMyReview = new System.Windows.Forms.GroupBox();
            this.groupMyReviewPublished = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.publishedReviewRating = new System.Windows.Forms.Label();
            this.publishedReviewText = new System.Windows.Forms.Label();
            this.labelRatingValue = new System.Windows.Forms.Label();
            this.reviewPublish = new System.Windows.Forms.Button();
            this.reviewText = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.reviewRating = new System.Windows.Forms.TrackBar();
            this.groupMovie = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.textMovieRating = new System.Windows.Forms.Label();
            this.textMovieStars = new System.Windows.Forms.Label();
            this.textMovieDirector = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.buttonAddToWatchlist = new System.Windows.Forms.Button();
            this.textMovieDescription = new System.Windows.Forms.Label();
            this.poster = new System.Windows.Forms.PictureBox();
            this.textMovieInfo = new System.Windows.Forms.Label();
            this.labelPagination = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.panelReviews = new System.Windows.Forms.Panel();
            this.groupReview = new System.Windows.Forms.GroupBox();
            this.labelReviewMovieRating = new System.Windows.Forms.Label();
            this.textReviewMovieDescription = new System.Windows.Forms.Label();
            this.groupMyReview.SuspendLayout();
            this.groupMyReviewPublished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewRating)).BeginInit();
            this.groupMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            this.panelReviews.SuspendLayout();
            this.groupReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMyReview
            // 
            this.groupMyReview.Controls.Add(this.groupMyReviewPublished);
            this.groupMyReview.Controls.Add(this.labelRatingValue);
            this.groupMyReview.Controls.Add(this.reviewPublish);
            this.groupMyReview.Controls.Add(this.reviewText);
            this.groupMyReview.Controls.Add(this.labelRating);
            this.groupMyReview.Controls.Add(this.reviewRating);
            this.groupMyReview.Location = new System.Drawing.Point(13, 209);
            this.groupMyReview.Name = "groupMyReview";
            this.groupMyReview.Size = new System.Drawing.Size(443, 156);
            this.groupMyReview.TabIndex = 43;
            this.groupMyReview.TabStop = false;
            this.groupMyReview.Text = "My Review";
            // 
            // groupMyReviewPublished
            // 
            this.groupMyReviewPublished.Controls.Add(this.button1);
            this.groupMyReviewPublished.Controls.Add(this.publishedReviewRating);
            this.groupMyReviewPublished.Controls.Add(this.publishedReviewText);
            this.groupMyReviewPublished.Location = new System.Drawing.Point(6, 0);
            this.groupMyReviewPublished.Name = "groupMyReviewPublished";
            this.groupMyReviewPublished.Size = new System.Drawing.Size(437, 156);
            this.groupMyReviewPublished.TabIndex = 11;
            this.groupMyReviewPublished.TabStop = false;
            this.groupMyReviewPublished.Text = "User\'s Review";
            this.groupMyReviewPublished.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // publishedReviewRating
            // 
            this.publishedReviewRating.Location = new System.Drawing.Point(6, 16);
            this.publishedReviewRating.Name = "publishedReviewRating";
            this.publishedReviewRating.Size = new System.Drawing.Size(413, 13);
            this.publishedReviewRating.TabIndex = 10;
            this.publishedReviewRating.Text = "5/10 stars";
            // 
            // publishedReviewText
            // 
            this.publishedReviewText.Location = new System.Drawing.Point(6, 39);
            this.publishedReviewText.Name = "publishedReviewText";
            this.publishedReviewText.Size = new System.Drawing.Size(425, 83);
            this.publishedReviewText.TabIndex = 3;
            this.publishedReviewText.Text = resources.GetString("publishedReviewText.Text");
            // 
            // labelRatingValue
            // 
            this.labelRatingValue.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelRatingValue.Location = new System.Drawing.Point(410, 95);
            this.labelRatingValue.Name = "labelRatingValue";
            this.labelRatingValue.Size = new System.Drawing.Size(27, 13);
            this.labelRatingValue.TabIndex = 4;
            this.labelRatingValue.Text = "5";
            this.labelRatingValue.UseMnemonic = false;
            // 
            // reviewPublish
            // 
            this.reviewPublish.Location = new System.Drawing.Point(362, 125);
            this.reviewPublish.Name = "reviewPublish";
            this.reviewPublish.Size = new System.Drawing.Size(75, 23);
            this.reviewPublish.TabIndex = 3;
            this.reviewPublish.Text = "Publish";
            this.reviewPublish.UseVisualStyleBackColor = true;
            // 
            // reviewText
            // 
            this.reviewText.Location = new System.Drawing.Point(6, 19);
            this.reviewText.Multiline = true;
            this.reviewText.Name = "reviewText";
            this.reviewText.Size = new System.Drawing.Size(431, 66);
            this.reviewText.TabIndex = 2;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(6, 95);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(38, 13);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "Rating";
            // 
            // reviewRating
            // 
            this.reviewRating.Location = new System.Drawing.Point(50, 91);
            this.reviewRating.Minimum = 1;
            this.reviewRating.Name = "reviewRating";
            this.reviewRating.Size = new System.Drawing.Size(354, 45);
            this.reviewRating.TabIndex = 0;
            this.reviewRating.Value = 5;
            // 
            // groupMovie
            // 
            this.groupMovie.Controls.Add(this.buttonDeleteMovie);
            this.groupMovie.Controls.Add(this.textMovieRating);
            this.groupMovie.Controls.Add(this.textMovieStars);
            this.groupMovie.Controls.Add(this.textMovieDirector);
            this.groupMovie.Controls.Add(this.labelStars);
            this.groupMovie.Controls.Add(this.labelDirector);
            this.groupMovie.Controls.Add(this.buttonAddToWatchlist);
            this.groupMovie.Controls.Add(this.textMovieDescription);
            this.groupMovie.Controls.Add(this.poster);
            this.groupMovie.Controls.Add(this.textMovieInfo);
            this.groupMovie.Location = new System.Drawing.Point(12, 12);
            this.groupMovie.Name = "groupMovie";
            this.groupMovie.Size = new System.Drawing.Size(444, 196);
            this.groupMovie.TabIndex = 42;
            this.groupMovie.TabStop = false;
            this.groupMovie.Text = "Movie Title";
            // 
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.Location = new System.Drawing.Point(243, 167);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(78, 23);
            this.buttonDeleteMovie.TabIndex = 11;
            this.buttonDeleteMovie.Text = "Delete";
            this.buttonDeleteMovie.UseVisualStyleBackColor = true;
            this.buttonDeleteMovie.Click += new System.EventHandler(this.buttonDeleteMovie_Click);
            // 
            // textMovieRating
            // 
            this.textMovieRating.Location = new System.Drawing.Point(135, 33);
            this.textMovieRating.Name = "textMovieRating";
            this.textMovieRating.Size = new System.Drawing.Size(303, 13);
            this.textMovieRating.TabIndex = 10;
            this.textMovieRating.Text = "5/10 stars - 15 reviews";
            // 
            // textMovieStars
            // 
            this.textMovieStars.Location = new System.Drawing.Point(197, 146);
            this.textMovieStars.Name = "textMovieStars";
            this.textMovieStars.Size = new System.Drawing.Size(241, 13);
            this.textMovieStars.TabIndex = 9;
            this.textMovieStars.Text = "label2";
            // 
            // textMovieDirector
            // 
            this.textMovieDirector.Location = new System.Drawing.Point(197, 129);
            this.textMovieDirector.Name = "textMovieDirector";
            this.textMovieDirector.Size = new System.Drawing.Size(241, 13);
            this.textMovieDirector.TabIndex = 8;
            this.textMovieDirector.Text = "label1";
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStars.Location = new System.Drawing.Point(135, 146);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(40, 13);
            this.labelStars.TabIndex = 7;
            this.labelStars.Text = "Stars:";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirector.Location = new System.Drawing.Point(135, 129);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(56, 13);
            this.labelDirector.TabIndex = 6;
            this.labelDirector.Text = "Director:";
            // 
            // buttonAddToWatchlist
            // 
            this.buttonAddToWatchlist.Location = new System.Drawing.Point(138, 167);
            this.buttonAddToWatchlist.Name = "buttonAddToWatchlist";
            this.buttonAddToWatchlist.Size = new System.Drawing.Size(99, 23);
            this.buttonAddToWatchlist.TabIndex = 4;
            this.buttonAddToWatchlist.Text = "Add to Watchlist";
            this.buttonAddToWatchlist.UseVisualStyleBackColor = true;
            // 
            // textMovieDescription
            // 
            this.textMovieDescription.Location = new System.Drawing.Point(135, 55);
            this.textMovieDescription.Name = "textMovieDescription";
            this.textMovieDescription.Size = new System.Drawing.Size(303, 74);
            this.textMovieDescription.TabIndex = 3;
            this.textMovieDescription.Text = resources.GetString("textMovieDescription.Text");
            // 
            // poster
            // 
            this.poster.Location = new System.Drawing.Point(7, 20);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(122, 170);
            this.poster.TabIndex = 1;
            this.poster.TabStop = false;
            // 
            // textMovieInfo
            // 
            this.textMovieInfo.Location = new System.Drawing.Point(135, 20);
            this.textMovieInfo.Name = "textMovieInfo";
            this.textMovieInfo.Size = new System.Drawing.Size(303, 13);
            this.textMovieInfo.TabIndex = 0;
            this.textMovieInfo.Text = "90 min - Horror";
            // 
            // labelPagination
            // 
            this.labelPagination.Location = new System.Drawing.Point(177, 780);
            this.labelPagination.Name = "labelPagination";
            this.labelPagination.Size = new System.Drawing.Size(100, 23);
            this.labelPagination.TabIndex = 41;
            this.labelPagination.Text = "1 / 10";
            this.labelPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(353, 781);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 23);
            this.buttonNext.TabIndex = 40;
            this.buttonNext.Text = "Next Page";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(9, 780);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(108, 23);
            this.buttonPrev.TabIndex = 39;
            this.buttonPrev.Text = "Previous Page";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // panelReviews
            // 
            this.panelReviews.AutoScroll = true;
            this.panelReviews.Controls.Add(this.groupReview);
            this.panelReviews.Location = new System.Drawing.Point(0, 371);
            this.panelReviews.Name = "panelReviews";
            this.panelReviews.Size = new System.Drawing.Size(468, 404);
            this.panelReviews.TabIndex = 38;
            // 
            // groupReview
            // 
            this.groupReview.Controls.Add(this.labelReviewMovieRating);
            this.groupReview.Controls.Add(this.textReviewMovieDescription);
            this.groupReview.Location = new System.Drawing.Point(12, 3);
            this.groupReview.Name = "groupReview";
            this.groupReview.Size = new System.Drawing.Size(427, 115);
            this.groupReview.TabIndex = 0;
            this.groupReview.TabStop = false;
            this.groupReview.Text = "User\'s Review";
            // 
            // labelReviewMovieRating
            // 
            this.labelReviewMovieRating.Location = new System.Drawing.Point(6, 16);
            this.labelReviewMovieRating.Name = "labelReviewMovieRating";
            this.labelReviewMovieRating.Size = new System.Drawing.Size(413, 13);
            this.labelReviewMovieRating.TabIndex = 10;
            this.labelReviewMovieRating.Text = "5/10 stars";
            // 
            // textReviewMovieDescription
            // 
            this.textReviewMovieDescription.Location = new System.Drawing.Point(6, 39);
            this.textReviewMovieDescription.Name = "textReviewMovieDescription";
            this.textReviewMovieDescription.Size = new System.Drawing.Size(413, 74);
            this.textReviewMovieDescription.TabIndex = 3;
            this.textReviewMovieDescription.Text = resources.GetString("textReviewMovieDescription.Text");
            // 
            // FormSingleMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 809);
            this.Controls.Add(this.groupMyReview);
            this.Controls.Add(this.groupMovie);
            this.Controls.Add(this.labelPagination);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.panelReviews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSingleMovie";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupMyReview.ResumeLayout(false);
            this.groupMyReview.PerformLayout();
            this.groupMyReviewPublished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reviewRating)).EndInit();
            this.groupMovie.ResumeLayout(false);
            this.groupMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            this.panelReviews.ResumeLayout(false);
            this.groupReview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPagination;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Panel panelReviews;
        private System.Windows.Forms.GroupBox groupReview;
        private System.Windows.Forms.Label labelReviewMovieRating;
        private System.Windows.Forms.Label textReviewMovieDescription;
        private System.Windows.Forms.GroupBox groupMovie;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.Label textMovieRating;
        private System.Windows.Forms.Label textMovieStars;
        private System.Windows.Forms.Label textMovieDirector;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Button buttonAddToWatchlist;
        private System.Windows.Forms.Label textMovieDescription;
        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.Label textMovieInfo;
        private System.Windows.Forms.GroupBox groupMyReview;
        private System.Windows.Forms.Button reviewPublish;
        private System.Windows.Forms.TextBox reviewText;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TrackBar reviewRating;
        private System.Windows.Forms.Label labelRatingValue;
        private System.Windows.Forms.GroupBox groupMyReviewPublished;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label publishedReviewRating;
        private System.Windows.Forms.Label publishedReviewText;
    }
}