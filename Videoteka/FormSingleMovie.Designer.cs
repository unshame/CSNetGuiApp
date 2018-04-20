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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textStars = new System.Windows.Forms.Label();
            this.textDirector = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.buttonAddToWatchlist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.templatePoster = new System.Windows.Forms.PictureBox();
            this.labelMovieInfo = new System.Windows.Forms.Label();
            this.labelPagination = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.panelReviews = new System.Windows.Forms.Panel();
            this.groupMovie = new System.Windows.Forms.GroupBox();
            this.labelMovieRating = new System.Windows.Forms.Label();
            this.textMovieDescription = new System.Windows.Forms.Label();
            this.groupMyReview.SuspendLayout();
            this.groupMyReviewPublished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewRating)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePoster)).BeginInit();
            this.panelReviews.SuspendLayout();
            this.groupMovie.SuspendLayout();
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
            this.groupMyReviewPublished.Location = new System.Drawing.Point(0, 0);
            this.groupMyReviewPublished.Name = "groupMyReviewPublished";
            this.groupMyReviewPublished.Size = new System.Drawing.Size(443, 156);
            this.groupMyReviewPublished.TabIndex = 11;
            this.groupMyReviewPublished.TabStop = false;
            this.groupMyReviewPublished.Text = "User\'s Review";
            this.groupMyReviewPublished.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 125);
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
            this.publishedReviewText.Size = new System.Drawing.Size(431, 83);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeleteMovie);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textStars);
            this.groupBox1.Controls.Add(this.textDirector);
            this.groupBox1.Controls.Add(this.labelStars);
            this.groupBox1.Controls.Add(this.labelDirector);
            this.groupBox1.Controls.Add(this.buttonAddToWatchlist);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.templatePoster);
            this.groupBox1.Controls.Add(this.labelMovieInfo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 196);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Movie Title";
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(135, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "5/10 stars - 15 reviews";
            // 
            // textStars
            // 
            this.textStars.Location = new System.Drawing.Point(197, 146);
            this.textStars.Name = "textStars";
            this.textStars.Size = new System.Drawing.Size(241, 13);
            this.textStars.TabIndex = 9;
            this.textStars.Text = "label2";
            // 
            // textDirector
            // 
            this.textDirector.Location = new System.Drawing.Point(197, 129);
            this.textDirector.Name = "textDirector";
            this.textDirector.Size = new System.Drawing.Size(241, 13);
            this.textDirector.TabIndex = 8;
            this.textDirector.Text = "label1";
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(135, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 74);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // templatePoster
            // 
            this.templatePoster.Location = new System.Drawing.Point(7, 20);
            this.templatePoster.Name = "templatePoster";
            this.templatePoster.Size = new System.Drawing.Size(122, 170);
            this.templatePoster.TabIndex = 1;
            this.templatePoster.TabStop = false;
            // 
            // labelMovieInfo
            // 
            this.labelMovieInfo.Location = new System.Drawing.Point(135, 20);
            this.labelMovieInfo.Name = "labelMovieInfo";
            this.labelMovieInfo.Size = new System.Drawing.Size(303, 13);
            this.labelMovieInfo.TabIndex = 0;
            this.labelMovieInfo.Text = "90 min - Horror";
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
            this.panelReviews.Controls.Add(this.groupMovie);
            this.panelReviews.Location = new System.Drawing.Point(0, 371);
            this.panelReviews.Name = "panelReviews";
            this.panelReviews.Size = new System.Drawing.Size(468, 404);
            this.panelReviews.TabIndex = 38;
            // 
            // groupMovie
            // 
            this.groupMovie.Controls.Add(this.labelMovieRating);
            this.groupMovie.Controls.Add(this.textMovieDescription);
            this.groupMovie.Location = new System.Drawing.Point(12, 3);
            this.groupMovie.Name = "groupMovie";
            this.groupMovie.Size = new System.Drawing.Size(427, 115);
            this.groupMovie.TabIndex = 0;
            this.groupMovie.TabStop = false;
            this.groupMovie.Text = "User\'s Review";
            // 
            // labelMovieRating
            // 
            this.labelMovieRating.Location = new System.Drawing.Point(6, 16);
            this.labelMovieRating.Name = "labelMovieRating";
            this.labelMovieRating.Size = new System.Drawing.Size(413, 13);
            this.labelMovieRating.TabIndex = 10;
            this.labelMovieRating.Text = "5/10 stars";
            // 
            // textMovieDescription
            // 
            this.textMovieDescription.Location = new System.Drawing.Point(6, 39);
            this.textMovieDescription.Name = "textMovieDescription";
            this.textMovieDescription.Size = new System.Drawing.Size(413, 74);
            this.textMovieDescription.TabIndex = 3;
            this.textMovieDescription.Text = resources.GetString("textMovieDescription.Text");
            // 
            // FormSingleMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 809);
            this.Controls.Add(this.groupMyReview);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelPagination);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.panelReviews);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSingleMovie";
            this.Text = "Movie";
            this.Load += new System.EventHandler(this.FormSingleMovie_Load);
            this.groupMyReview.ResumeLayout(false);
            this.groupMyReview.PerformLayout();
            this.groupMyReviewPublished.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reviewRating)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePoster)).EndInit();
            this.panelReviews.ResumeLayout(false);
            this.groupMovie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPagination;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Panel panelReviews;
        private System.Windows.Forms.GroupBox groupMovie;
        private System.Windows.Forms.Label labelMovieRating;
        private System.Windows.Forms.Label textMovieDescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textStars;
        private System.Windows.Forms.Label textDirector;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Button buttonAddToWatchlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox templatePoster;
        private System.Windows.Forms.Label labelMovieInfo;
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