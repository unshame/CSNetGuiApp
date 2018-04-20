﻿namespace Videoteka {
    partial class FormReviews {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReviews));
            this.labelPagination = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonWatchlist = new System.Windows.Forms.Button();
            this.buttonAllReviews = new System.Windows.Forms.Button();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.buttonFilterReset = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filterLength = new System.Windows.Forms.TextBox();
            this.labelFilterRating = new System.Windows.Forms.Label();
            this.filterRating = new System.Windows.Forms.ComboBox();
            this.labelFilterYear = new System.Windows.Forms.Label();
            this.filterYear = new System.Windows.Forms.ComboBox();
            this.labelFilterGenre = new System.Windows.Forms.Label();
            this.filterGenre = new System.Windows.Forms.ComboBox();
            this.labelFilterActor = new System.Windows.Forms.Label();
            this.labelFilterDirector = new System.Windows.Forms.Label();
            this.filterActor = new System.Windows.Forms.TextBox();
            this.filterDirector = new System.Windows.Forms.TextBox();
            this.filterTitle = new System.Windows.Forms.TextBox();
            this.labelFilterTitle = new System.Windows.Forms.Label();
            this.panelMovies = new System.Windows.Forms.Panel();
            this.groupMovie = new System.Windows.Forms.GroupBox();
            this.buttonDeleteMovie = new System.Windows.Forms.Button();
            this.labelMovieRating = new System.Windows.Forms.Label();
            this.textStars = new System.Windows.Forms.Label();
            this.textDirector = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.buttonReviews = new System.Windows.Forms.Button();
            this.buttonAddToWatchlist = new System.Windows.Forms.Button();
            this.textMovieDescription = new System.Windows.Forms.Label();
            this.templatePoster = new System.Windows.Forms.PictureBox();
            this.labelMovieInfo = new System.Windows.Forms.Label();
            this.groupFilter.SuspendLayout();
            this.panelMovies.SuspendLayout();
            this.groupMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPagination
            // 
            this.labelPagination.Location = new System.Drawing.Point(177, 737);
            this.labelPagination.Name = "labelPagination";
            this.labelPagination.Size = new System.Drawing.Size(100, 23);
            this.labelPagination.TabIndex = 37;
            this.labelPagination.Text = "1 / 10";
            this.labelPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(353, 738);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 23);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "Next Page";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonPrev
            // 
            this.buttonPrev.Location = new System.Drawing.Point(9, 737);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(108, 23);
            this.buttonPrev.TabIndex = 35;
            this.buttonPrev.Text = "Previous Page";
            this.buttonPrev.UseVisualStyleBackColor = true;
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(353, 773);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(108, 23);
            this.buttonAddMovie.TabIndex = 34;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(239, 773);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(108, 23);
            this.buttonLogin.TabIndex = 33;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonWatchlist
            // 
            this.buttonWatchlist.Location = new System.Drawing.Point(123, 773);
            this.buttonWatchlist.Name = "buttonWatchlist";
            this.buttonWatchlist.Size = new System.Drawing.Size(108, 23);
            this.buttonWatchlist.TabIndex = 32;
            this.buttonWatchlist.Text = "My Watchlist";
            this.buttonWatchlist.UseVisualStyleBackColor = true;
            this.buttonWatchlist.Click += new System.EventHandler(this.buttonWatchlist_Click);
            // 
            // buttonAllReviews
            // 
            this.buttonAllReviews.Location = new System.Drawing.Point(9, 773);
            this.buttonAllReviews.Name = "buttonAllReviews";
            this.buttonAllReviews.Size = new System.Drawing.Size(108, 23);
            this.buttonAllReviews.TabIndex = 31;
            this.buttonAllReviews.Text = "Browse Movies";
            this.buttonAllReviews.UseVisualStyleBackColor = true;
            this.buttonAllReviews.Click += new System.EventHandler(this.buttonAllMovies_click);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.buttonFilterReset);
            this.groupFilter.Controls.Add(this.buttonFilter);
            this.groupFilter.Controls.Add(this.label1);
            this.groupFilter.Controls.Add(this.filterLength);
            this.groupFilter.Controls.Add(this.labelFilterRating);
            this.groupFilter.Controls.Add(this.filterRating);
            this.groupFilter.Controls.Add(this.labelFilterYear);
            this.groupFilter.Controls.Add(this.filterYear);
            this.groupFilter.Controls.Add(this.labelFilterGenre);
            this.groupFilter.Controls.Add(this.filterGenre);
            this.groupFilter.Controls.Add(this.labelFilterActor);
            this.groupFilter.Controls.Add(this.labelFilterDirector);
            this.groupFilter.Controls.Add(this.filterActor);
            this.groupFilter.Controls.Add(this.filterDirector);
            this.groupFilter.Controls.Add(this.filterTitle);
            this.groupFilter.Controls.Add(this.labelFilterTitle);
            this.groupFilter.Location = new System.Drawing.Point(13, 12);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(439, 135);
            this.groupFilter.TabIndex = 30;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter Movies";
            // 
            // buttonFilterReset
            // 
            this.buttonFilterReset.Location = new System.Drawing.Point(352, 106);
            this.buttonFilterReset.Name = "buttonFilterReset";
            this.buttonFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterReset.TabIndex = 21;
            this.buttonFilterReset.Text = "Reset Filter";
            this.buttonFilterReset.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(238, 106);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(108, 23);
            this.buttonFilter.TabIndex = 20;
            this.buttonFilter.Text = "Apply Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Length";
            // 
            // filterLength
            // 
            this.filterLength.Location = new System.Drawing.Point(57, 98);
            this.filterLength.Name = "filterLength";
            this.filterLength.Size = new System.Drawing.Size(142, 20);
            this.filterLength.TabIndex = 18;
            // 
            // labelFilterRating
            // 
            this.labelFilterRating.AutoSize = true;
            this.labelFilterRating.Location = new System.Drawing.Point(235, 74);
            this.labelFilterRating.Name = "labelFilterRating";
            this.labelFilterRating.Size = new System.Drawing.Size(38, 13);
            this.labelFilterRating.TabIndex = 17;
            this.labelFilterRating.Text = "Rating";
            // 
            // filterRating
            // 
            this.filterRating.FormattingEnabled = true;
            this.filterRating.Location = new System.Drawing.Point(285, 71);
            this.filterRating.Name = "filterRating";
            this.filterRating.Size = new System.Drawing.Size(142, 21);
            this.filterRating.TabIndex = 16;
            // 
            // labelFilterYear
            // 
            this.labelFilterYear.AutoSize = true;
            this.labelFilterYear.Location = new System.Drawing.Point(235, 47);
            this.labelFilterYear.Name = "labelFilterYear";
            this.labelFilterYear.Size = new System.Drawing.Size(29, 13);
            this.labelFilterYear.TabIndex = 15;
            this.labelFilterYear.Text = "Year";
            // 
            // filterYear
            // 
            this.filterYear.FormattingEnabled = true;
            this.filterYear.Location = new System.Drawing.Point(285, 44);
            this.filterYear.Name = "filterYear";
            this.filterYear.Size = new System.Drawing.Size(142, 21);
            this.filterYear.TabIndex = 14;
            // 
            // labelFilterGenre
            // 
            this.labelFilterGenre.AutoSize = true;
            this.labelFilterGenre.Location = new System.Drawing.Point(235, 20);
            this.labelFilterGenre.Name = "labelFilterGenre";
            this.labelFilterGenre.Size = new System.Drawing.Size(36, 13);
            this.labelFilterGenre.TabIndex = 13;
            this.labelFilterGenre.Text = "Genre";
            // 
            // filterGenre
            // 
            this.filterGenre.FormattingEnabled = true;
            this.filterGenre.Location = new System.Drawing.Point(285, 17);
            this.filterGenre.Name = "filterGenre";
            this.filterGenre.Size = new System.Drawing.Size(142, 21);
            this.filterGenre.TabIndex = 12;
            // 
            // labelFilterActor
            // 
            this.labelFilterActor.AutoSize = true;
            this.labelFilterActor.Location = new System.Drawing.Point(7, 75);
            this.labelFilterActor.Name = "labelFilterActor";
            this.labelFilterActor.Size = new System.Drawing.Size(32, 13);
            this.labelFilterActor.TabIndex = 5;
            this.labelFilterActor.Text = "Actor";
            // 
            // labelFilterDirector
            // 
            this.labelFilterDirector.AutoSize = true;
            this.labelFilterDirector.Location = new System.Drawing.Point(7, 49);
            this.labelFilterDirector.Name = "labelFilterDirector";
            this.labelFilterDirector.Size = new System.Drawing.Size(44, 13);
            this.labelFilterDirector.TabIndex = 4;
            this.labelFilterDirector.Text = "Director";
            // 
            // filterActor
            // 
            this.filterActor.Location = new System.Drawing.Point(57, 72);
            this.filterActor.Name = "filterActor";
            this.filterActor.Size = new System.Drawing.Size(142, 20);
            this.filterActor.TabIndex = 3;
            // 
            // filterDirector
            // 
            this.filterDirector.Location = new System.Drawing.Point(57, 46);
            this.filterDirector.Name = "filterDirector";
            this.filterDirector.Size = new System.Drawing.Size(142, 20);
            this.filterDirector.TabIndex = 2;
            // 
            // filterTitle
            // 
            this.filterTitle.Location = new System.Drawing.Point(57, 20);
            this.filterTitle.Name = "filterTitle";
            this.filterTitle.Size = new System.Drawing.Size(142, 20);
            this.filterTitle.TabIndex = 1;
            // 
            // labelFilterTitle
            // 
            this.labelFilterTitle.AutoSize = true;
            this.labelFilterTitle.Location = new System.Drawing.Point(7, 23);
            this.labelFilterTitle.Name = "labelFilterTitle";
            this.labelFilterTitle.Size = new System.Drawing.Size(27, 13);
            this.labelFilterTitle.TabIndex = 0;
            this.labelFilterTitle.Text = "Title";
            // 
            // panelMovies
            // 
            this.panelMovies.AutoScroll = true;
            this.panelMovies.Controls.Add(this.groupMovie);
            this.panelMovies.Location = new System.Drawing.Point(0, 153);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(468, 579);
            this.panelMovies.TabIndex = 29;
            // 
            // groupMovie
            // 
            this.groupMovie.Controls.Add(this.buttonDeleteMovie);
            this.groupMovie.Controls.Add(this.labelMovieRating);
            this.groupMovie.Controls.Add(this.textStars);
            this.groupMovie.Controls.Add(this.textDirector);
            this.groupMovie.Controls.Add(this.labelStars);
            this.groupMovie.Controls.Add(this.labelDirector);
            this.groupMovie.Controls.Add(this.buttonReviews);
            this.groupMovie.Controls.Add(this.buttonAddToWatchlist);
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
            // buttonDeleteMovie
            // 
            this.buttonDeleteMovie.Location = new System.Drawing.Point(343, 167);
            this.buttonDeleteMovie.Name = "buttonDeleteMovie";
            this.buttonDeleteMovie.Size = new System.Drawing.Size(78, 23);
            this.buttonDeleteMovie.TabIndex = 11;
            this.buttonDeleteMovie.Text = "Delete";
            this.buttonDeleteMovie.UseVisualStyleBackColor = true;
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
            // buttonAddToWatchlist
            // 
            this.buttonAddToWatchlist.Location = new System.Drawing.Point(238, 167);
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
            // FormReviews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 809);
            this.Controls.Add(this.labelPagination);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonWatchlist);
            this.Controls.Add(this.buttonAllReviews);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.panelMovies);
            this.Name = "FormReviews";
            this.Text = "Reviews";
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.panelMovies.ResumeLayout(false);
            this.groupMovie.ResumeLayout(false);
            this.groupMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.templatePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPagination;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonWatchlist;
        private System.Windows.Forms.Button buttonAllReviews;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Button buttonFilterReset;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filterLength;
        private System.Windows.Forms.Label labelFilterRating;
        private System.Windows.Forms.ComboBox filterRating;
        private System.Windows.Forms.Label labelFilterYear;
        private System.Windows.Forms.ComboBox filterYear;
        private System.Windows.Forms.Label labelFilterGenre;
        private System.Windows.Forms.ComboBox filterGenre;
        private System.Windows.Forms.Label labelFilterActor;
        private System.Windows.Forms.Label labelFilterDirector;
        private System.Windows.Forms.TextBox filterActor;
        private System.Windows.Forms.TextBox filterDirector;
        private System.Windows.Forms.TextBox filterTitle;
        private System.Windows.Forms.Label labelFilterTitle;
        private System.Windows.Forms.Panel panelMovies;
        private System.Windows.Forms.GroupBox groupMovie;
        private System.Windows.Forms.Button buttonDeleteMovie;
        private System.Windows.Forms.Label labelMovieRating;
        private System.Windows.Forms.Label textStars;
        private System.Windows.Forms.Label textDirector;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Button buttonReviews;
        private System.Windows.Forms.Button buttonAddToWatchlist;
        private System.Windows.Forms.Label textMovieDescription;
        private System.Windows.Forms.PictureBox templatePoster;
        private System.Windows.Forms.Label labelMovieInfo;
    }
}