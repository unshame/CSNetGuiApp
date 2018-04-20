namespace Videoteka {
    partial class FormWatchlist {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWatchlist));
            this.panelMovies = new System.Windows.Forms.Panel();
            this.groupMovie = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelMovieRating = new System.Windows.Forms.Label();
            this.textStars = new System.Windows.Forms.Label();
            this.textDirector = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.buttonReviews = new System.Windows.Forms.Button();
            this.buttonAddToWatched = new System.Windows.Forms.Button();
            this.textMovieDescription = new System.Windows.Forms.Label();
            this.templatePoster = new System.Windows.Forms.PictureBox();
            this.labelMovieInfo = new System.Windows.Forms.Label();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.filterSortOrder = new System.Windows.Forms.ComboBox();
            this.radioReviewed = new System.Windows.Forms.RadioButton();
            this.radioWatched = new System.Windows.Forms.RadioButton();
            this.radioUnwatched = new System.Windows.Forms.RadioButton();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.filterSortBy = new System.Windows.Forms.ComboBox();
            this.buttonFilterReset = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelPagination = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.panelMovies.SuspendLayout();
            this.groupMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePoster)).BeginInit();
            this.groupFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMovies
            // 
            this.panelMovies.AutoScroll = true;
            this.panelMovies.Controls.Add(this.groupMovie);
            this.panelMovies.Location = new System.Drawing.Point(0, 123);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(468, 561);
            this.panelMovies.TabIndex = 11;
            // 
            // groupMovie
            // 
            this.groupMovie.Controls.Add(this.buttonRemove);
            this.groupMovie.Controls.Add(this.labelMovieRating);
            this.groupMovie.Controls.Add(this.textStars);
            this.groupMovie.Controls.Add(this.textDirector);
            this.groupMovie.Controls.Add(this.labelStars);
            this.groupMovie.Controls.Add(this.labelDirector);
            this.groupMovie.Controls.Add(this.buttonReviews);
            this.groupMovie.Controls.Add(this.buttonAddToWatched);
            this.groupMovie.Controls.Add(this.textMovieDescription);
            this.groupMovie.Controls.Add(this.templatePoster);
            this.groupMovie.Controls.Add(this.labelMovieInfo);
            this.groupMovie.Location = new System.Drawing.Point(12, 3);
            this.groupMovie.Name = "groupMovie";
            this.groupMovie.Size = new System.Drawing.Size(427, 196);
            this.groupMovie.TabIndex = 0;
            this.groupMovie.TabStop = false;
            this.groupMovie.Text = "Movie Title";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(343, 167);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(78, 23);
            this.buttonRemove.TabIndex = 11;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // labelMovieRating
            // 
            this.labelMovieRating.Location = new System.Drawing.Point(135, 33);
            this.labelMovieRating.Name = "labelMovieRating";
            this.labelMovieRating.Size = new System.Drawing.Size(286, 13);
            this.labelMovieRating.TabIndex = 10;
            this.labelMovieRating.Text = "5/10 stars - 15 reviews";
            // 
            // textStars
            // 
            this.textStars.Location = new System.Drawing.Point(197, 146);
            this.textStars.Name = "textStars";
            this.textStars.Size = new System.Drawing.Size(224, 13);
            this.textStars.TabIndex = 9;
            this.textStars.Text = "label2";
            // 
            // textDirector
            // 
            this.textDirector.Location = new System.Drawing.Point(197, 129);
            this.textDirector.Name = "textDirector";
            this.textDirector.Size = new System.Drawing.Size(224, 13);
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
            // buttonReviews
            // 
            this.buttonReviews.Location = new System.Drawing.Point(135, 167);
            this.buttonReviews.Name = "buttonReviews";
            this.buttonReviews.Size = new System.Drawing.Size(97, 23);
            this.buttonReviews.TabIndex = 5;
            this.buttonReviews.Text = "Read Reviews";
            this.buttonReviews.UseVisualStyleBackColor = true;
            // 
            // buttonAddToWatched
            // 
            this.buttonAddToWatched.Location = new System.Drawing.Point(238, 167);
            this.buttonAddToWatched.Name = "buttonAddToWatched";
            this.buttonAddToWatched.Size = new System.Drawing.Size(99, 23);
            this.buttonAddToWatched.TabIndex = 4;
            this.buttonAddToWatched.Text = "Watched";
            this.buttonAddToWatched.UseVisualStyleBackColor = true;
            // 
            // textMovieDescription
            // 
            this.textMovieDescription.Location = new System.Drawing.Point(135, 55);
            this.textMovieDescription.Name = "textMovieDescription";
            this.textMovieDescription.Size = new System.Drawing.Size(286, 74);
            this.textMovieDescription.TabIndex = 3;
            this.textMovieDescription.Text = resources.GetString("textMovieDescription.Text");
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
            this.labelMovieInfo.Size = new System.Drawing.Size(286, 13);
            this.labelMovieInfo.TabIndex = 0;
            this.labelMovieInfo.Text = "90 min - Horror";
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.labelSortOrder);
            this.groupFilter.Controls.Add(this.filterSortOrder);
            this.groupFilter.Controls.Add(this.radioReviewed);
            this.groupFilter.Controls.Add(this.radioWatched);
            this.groupFilter.Controls.Add(this.radioUnwatched);
            this.groupFilter.Controls.Add(this.labelSortBy);
            this.groupFilter.Controls.Add(this.filterSortBy);
            this.groupFilter.Controls.Add(this.buttonFilterReset);
            this.groupFilter.Controls.Add(this.buttonFilter);
            this.groupFilter.Location = new System.Drawing.Point(12, 12);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(443, 105);
            this.groupFilter.TabIndex = 31;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter Movies";
            // 
            // labelSortOrder
            // 
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(235, 48);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(33, 13);
            this.labelSortOrder.TabIndex = 30;
            this.labelSortOrder.Text = "Order";
            // 
            // filterSortOrder
            // 
            this.filterSortOrder.FormattingEnabled = true;
            this.filterSortOrder.Location = new System.Drawing.Point(285, 45);
            this.filterSortOrder.Name = "filterSortOrder";
            this.filterSortOrder.Size = new System.Drawing.Size(142, 21);
            this.filterSortOrder.TabIndex = 29;
            // 
            // radioReviewed
            // 
            this.radioReviewed.AutoSize = true;
            this.radioReviewed.Location = new System.Drawing.Point(6, 67);
            this.radioReviewed.Name = "radioReviewed";
            this.radioReviewed.Size = new System.Drawing.Size(103, 17);
            this.radioReviewed.TabIndex = 28;
            this.radioReviewed.Text = "Show Reviewed";
            this.radioReviewed.UseVisualStyleBackColor = true;
            // 
            // radioWatched
            // 
            this.radioWatched.AutoSize = true;
            this.radioWatched.Location = new System.Drawing.Point(6, 44);
            this.radioWatched.Name = "radioWatched";
            this.radioWatched.Size = new System.Drawing.Size(99, 17);
            this.radioWatched.TabIndex = 27;
            this.radioWatched.Text = "Show Watched";
            this.radioWatched.UseVisualStyleBackColor = true;
            // 
            // radioUnwatched
            // 
            this.radioUnwatched.AutoSize = true;
            this.radioUnwatched.Checked = true;
            this.radioUnwatched.Location = new System.Drawing.Point(6, 21);
            this.radioUnwatched.Name = "radioUnwatched";
            this.radioUnwatched.Size = new System.Drawing.Size(110, 17);
            this.radioUnwatched.TabIndex = 26;
            this.radioUnwatched.TabStop = true;
            this.radioUnwatched.Text = "Show Unwatched";
            this.radioUnwatched.UseVisualStyleBackColor = true;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(235, 23);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(40, 13);
            this.labelSortBy.TabIndex = 25;
            this.labelSortBy.Text = "Sort by";
            // 
            // filterSortBy
            // 
            this.filterSortBy.FormattingEnabled = true;
            this.filterSortBy.Location = new System.Drawing.Point(285, 19);
            this.filterSortBy.Name = "filterSortBy";
            this.filterSortBy.Size = new System.Drawing.Size(142, 21);
            this.filterSortBy.TabIndex = 24;
            // 
            // buttonFilterReset
            // 
            this.buttonFilterReset.Location = new System.Drawing.Point(352, 72);
            this.buttonFilterReset.Name = "buttonFilterReset";
            this.buttonFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterReset.TabIndex = 21;
            this.buttonFilterReset.Text = "Reset Filter";
            this.buttonFilterReset.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(238, 72);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(108, 23);
            this.buttonFilter.TabIndex = 20;
            this.buttonFilter.Text = "Apply Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // labelPagination
            // 
            this.labelPagination.Location = new System.Drawing.Point(177, 690);
            this.labelPagination.Name = "labelPagination";
            this.labelPagination.Size = new System.Drawing.Size(100, 23);
            this.labelPagination.TabIndex = 40;
            this.labelPagination.Text = "1 / 10";
            this.labelPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(353, 691);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 23);
            this.buttonNext.TabIndex = 39;
            this.buttonNext.Text = "Next Page";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(9, 690);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(108, 23);
            this.buttonPrev.TabIndex = 38;
            this.buttonPrev.Text = "Previous Page";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // FormWatchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 720);
            this.Controls.Add(this.labelPagination);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.panelMovies);
            this.Controls.Add(this.buttonPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormWatchlist";
            this.Text = "FormWatchlist";
            this.Load += new System.EventHandler(this.FormWatchlist_Load);
            this.panelMovies.ResumeLayout(false);
            this.groupMovie.ResumeLayout(false);
            this.groupMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePoster)).EndInit();
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMovies;
        private System.Windows.Forms.GroupBox groupMovie;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label labelMovieRating;
        private System.Windows.Forms.Label textStars;
        private System.Windows.Forms.Label textDirector;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Button buttonReviews;
        private System.Windows.Forms.Button buttonAddToWatched;
        private System.Windows.Forms.Label textMovieDescription;
        private System.Windows.Forms.PictureBox templatePoster;
        private System.Windows.Forms.Label labelMovieInfo;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.RadioButton radioReviewed;
        private System.Windows.Forms.RadioButton radioWatched;
        private System.Windows.Forms.RadioButton radioUnwatched;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.ComboBox filterSortBy;
        private System.Windows.Forms.Button buttonFilterReset;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelPagination;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Label labelSortOrder;
        private System.Windows.Forms.ComboBox filterSortOrder;
    }
}