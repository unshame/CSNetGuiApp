namespace Videoteka {
    partial class FormMovies {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovies));
            this.template = new System.Windows.Forms.GroupBox();
            this.buttonEditMovie = new System.Windows.Forms.Button();
            this.textMovieRating = new System.Windows.Forms.Label();
            this.textMovieStars = new System.Windows.Forms.Label();
            this.textMovieDirector = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.buttonReviews = new System.Windows.Forms.Button();
            this.buttonAddToWatchlist = new System.Windows.Forms.Button();
            this.textMovieDescription = new System.Windows.Forms.Label();
            this.poster = new System.Windows.Forms.PictureBox();
            this.textMovieInfo = new System.Windows.Forms.Label();
            this.panelMovies = new System.Windows.Forms.Panel();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.labelYearPlus = new System.Windows.Forms.Label();
            this.filterYear = new System.Windows.Forms.NumericUpDown();
            this.labelDurationExt = new System.Windows.Forms.Label();
            this.filterDuration = new System.Windows.Forms.NumericUpDown();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.filterSortOrder = new System.Windows.Forms.ComboBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.filterSortBy = new System.Windows.Forms.ComboBox();
            this.buttonFilterReset = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelFilterRating = new System.Windows.Forms.Label();
            this.filterRating = new System.Windows.Forms.ComboBox();
            this.labelFilterYear = new System.Windows.Forms.Label();
            this.labelFilterGenre = new System.Windows.Forms.Label();
            this.filterGenre = new System.Windows.Forms.ComboBox();
            this.labelFilterStar = new System.Windows.Forms.Label();
            this.labelFilterDirector = new System.Windows.Forms.Label();
            this.filterStar = new System.Windows.Forms.TextBox();
            this.filterDirector = new System.Windows.Forms.TextBox();
            this.filterTitle = new System.Windows.Forms.TextBox();
            this.labelFilterTitle = new System.Windows.Forms.Label();
            this.buttonAllReviews = new System.Windows.Forms.Button();
            this.buttonWatchlist = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.labelPagination = new System.Windows.Forms.Label();
            this.template.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            this.panelMovies.SuspendLayout();
            this.groupFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // template
            // 
            this.template.Controls.Add(this.buttonEditMovie);
            this.template.Controls.Add(this.textMovieRating);
            this.template.Controls.Add(this.textMovieStars);
            this.template.Controls.Add(this.textMovieDirector);
            this.template.Controls.Add(this.labelStars);
            this.template.Controls.Add(this.labelDirector);
            this.template.Controls.Add(this.buttonReviews);
            this.template.Controls.Add(this.buttonAddToWatchlist);
            this.template.Controls.Add(this.textMovieDescription);
            this.template.Controls.Add(this.poster);
            this.template.Controls.Add(this.textMovieInfo);
            this.template.Location = new System.Drawing.Point(12, 0);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(427, 196);
            this.template.TabIndex = 0;
            this.template.TabStop = false;
            this.template.Text = "Movie Title";
            // 
            // buttonEditMovie
            // 
            this.buttonEditMovie.Location = new System.Drawing.Point(343, 167);
            this.buttonEditMovie.Name = "buttonEditMovie";
            this.buttonEditMovie.Size = new System.Drawing.Size(78, 23);
            this.buttonEditMovie.TabIndex = 2;
            this.buttonEditMovie.Text = "Edit";
            this.buttonEditMovie.UseVisualStyleBackColor = true;
            // 
            // textMovieRating
            // 
            this.textMovieRating.Location = new System.Drawing.Point(135, 33);
            this.textMovieRating.Name = "textMovieRating";
            this.textMovieRating.Size = new System.Drawing.Size(286, 13);
            this.textMovieRating.TabIndex = 1;
            this.textMovieRating.Text = "5/10 stars - 15 reviews";
            this.textMovieRating.UseMnemonic = false;
            // 
            // textMovieStars
            // 
            this.textMovieStars.Location = new System.Drawing.Point(175, 146);
            this.textMovieStars.Name = "textMovieStars";
            this.textMovieStars.Size = new System.Drawing.Size(246, 13);
            this.textMovieStars.TabIndex = 6;
            this.textMovieStars.Text = "label2";
            // 
            // textMovieDirector
            // 
            this.textMovieDirector.Location = new System.Drawing.Point(191, 129);
            this.textMovieDirector.Name = "textMovieDirector";
            this.textMovieDirector.Size = new System.Drawing.Size(230, 13);
            this.textMovieDirector.TabIndex = 4;
            this.textMovieDirector.Text = "label1";
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStars.Location = new System.Drawing.Point(135, 146);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(40, 13);
            this.labelStars.TabIndex = 5;
            this.labelStars.Text = "Stars:";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDirector.Location = new System.Drawing.Point(135, 129);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(56, 13);
            this.labelDirector.TabIndex = 3;
            this.labelDirector.Text = "Director:";
            // 
            // buttonReviews
            // 
            this.buttonReviews.Location = new System.Drawing.Point(135, 167);
            this.buttonReviews.Name = "buttonReviews";
            this.buttonReviews.Size = new System.Drawing.Size(97, 23);
            this.buttonReviews.TabIndex = 0;
            this.buttonReviews.Text = "Read Reviews";
            this.buttonReviews.UseVisualStyleBackColor = true;
            // 
            // buttonAddToWatchlist
            // 
            this.buttonAddToWatchlist.Location = new System.Drawing.Point(238, 167);
            this.buttonAddToWatchlist.Name = "buttonAddToWatchlist";
            this.buttonAddToWatchlist.Size = new System.Drawing.Size(99, 23);
            this.buttonAddToWatchlist.TabIndex = 1;
            this.buttonAddToWatchlist.Text = "Add to Watchlist";
            this.buttonAddToWatchlist.UseVisualStyleBackColor = true;
            // 
            // textMovieDescription
            // 
            this.textMovieDescription.Location = new System.Drawing.Point(135, 55);
            this.textMovieDescription.Name = "textMovieDescription";
            this.textMovieDescription.Size = new System.Drawing.Size(286, 74);
            this.textMovieDescription.TabIndex = 2;
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
            this.textMovieInfo.Size = new System.Drawing.Size(286, 13);
            this.textMovieInfo.TabIndex = 0;
            this.textMovieInfo.Text = "90 min - Horror";
            // 
            // panelMovies
            // 
            this.panelMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelMovies.AutoScroll = true;
            this.panelMovies.BackgroundImage = global::Videoteka.Properties.Resources.reel12;
            this.panelMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMovies.Controls.Add(this.template);
            this.panelMovies.Location = new System.Drawing.Point(0, 174);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(468, 558);
            this.panelMovies.TabIndex = 1;
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.labelYearPlus);
            this.groupFilter.Controls.Add(this.filterYear);
            this.groupFilter.Controls.Add(this.labelDurationExt);
            this.groupFilter.Controls.Add(this.filterDuration);
            this.groupFilter.Controls.Add(this.labelSortOrder);
            this.groupFilter.Controls.Add(this.filterSortOrder);
            this.groupFilter.Controls.Add(this.labelSortBy);
            this.groupFilter.Controls.Add(this.filterSortBy);
            this.groupFilter.Controls.Add(this.buttonFilterReset);
            this.groupFilter.Controls.Add(this.buttonFilter);
            this.groupFilter.Controls.Add(this.labelDuration);
            this.groupFilter.Controls.Add(this.labelFilterRating);
            this.groupFilter.Controls.Add(this.filterRating);
            this.groupFilter.Controls.Add(this.labelFilterYear);
            this.groupFilter.Controls.Add(this.labelFilterGenre);
            this.groupFilter.Controls.Add(this.filterGenre);
            this.groupFilter.Controls.Add(this.labelFilterStar);
            this.groupFilter.Controls.Add(this.labelFilterDirector);
            this.groupFilter.Controls.Add(this.filterStar);
            this.groupFilter.Controls.Add(this.filterDirector);
            this.groupFilter.Controls.Add(this.filterTitle);
            this.groupFilter.Controls.Add(this.labelFilterTitle);
            this.groupFilter.Location = new System.Drawing.Point(13, 13);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(439, 155);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter Movies";
            // 
            // labelYearPlus
            // 
            this.labelYearPlus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelYearPlus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelYearPlus.Location = new System.Drawing.Point(312, 22);
            this.labelYearPlus.Margin = new System.Windows.Forms.Padding(0);
            this.labelYearPlus.Name = "labelYearPlus";
            this.labelYearPlus.Size = new System.Drawing.Size(95, 18);
            this.labelYearPlus.TabIndex = 13;
            this.labelYearPlus.Text = "+";
            this.labelYearPlus.UseMnemonic = false;
            // 
            // filterYear
            // 
            this.filterYear.Location = new System.Drawing.Point(285, 21);
            this.filterYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.filterYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.filterYear.Name = "filterYear";
            this.filterYear.Size = new System.Drawing.Size(141, 20);
            this.filterYear.TabIndex = 12;
            this.filterYear.Value = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            // 
            // labelDurationExt
            // 
            this.labelDurationExt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDurationExt.Location = new System.Drawing.Point(141, 100);
            this.labelDurationExt.Margin = new System.Windows.Forms.Padding(0);
            this.labelDurationExt.Name = "labelDurationExt";
            this.labelDurationExt.Size = new System.Drawing.Size(55, 13);
            this.labelDurationExt.TabIndex = 8;
            this.labelDurationExt.Text = "+  minutes";
            this.labelDurationExt.UseMnemonic = false;
            // 
            // filterDuration
            // 
            this.filterDuration.Location = new System.Drawing.Point(57, 98);
            this.filterDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.filterDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.filterDuration.Name = "filterDuration";
            this.filterDuration.Size = new System.Drawing.Size(84, 20);
            this.filterDuration.TabIndex = 7;
            this.filterDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSortOrder
            // 
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(236, 104);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(33, 13);
            this.labelSortOrder.TabIndex = 18;
            this.labelSortOrder.Text = "Order";
            // 
            // filterSortOrder
            // 
            this.filterSortOrder.FormattingEnabled = true;
            this.filterSortOrder.Location = new System.Drawing.Point(285, 101);
            this.filterSortOrder.Name = "filterSortOrder";
            this.filterSortOrder.Size = new System.Drawing.Size(142, 21);
            this.filterSortOrder.TabIndex = 19;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(235, 77);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(40, 13);
            this.labelSortBy.TabIndex = 16;
            this.labelSortBy.Text = "Sort by";
            // 
            // filterSortBy
            // 
            this.filterSortBy.FormattingEnabled = true;
            this.filterSortBy.Location = new System.Drawing.Point(284, 74);
            this.filterSortBy.Name = "filterSortBy";
            this.filterSortBy.Size = new System.Drawing.Size(142, 21);
            this.filterSortBy.TabIndex = 17;
            // 
            // buttonFilterReset
            // 
            this.buttonFilterReset.Location = new System.Drawing.Point(352, 125);
            this.buttonFilterReset.Name = "buttonFilterReset";
            this.buttonFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterReset.TabIndex = 21;
            this.buttonFilterReset.Text = "Reset Filter";
            this.buttonFilterReset.UseVisualStyleBackColor = true;
            this.buttonFilterReset.Click += new System.EventHandler(this.buttonFilterReset_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(238, 125);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(108, 23);
            this.buttonFilter.TabIndex = 20;
            this.buttonFilter.Text = "Apply Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(7, 100);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 13);
            this.labelDuration.TabIndex = 6;
            this.labelDuration.Text = "Duration";
            // 
            // labelFilterRating
            // 
            this.labelFilterRating.AutoSize = true;
            this.labelFilterRating.Location = new System.Drawing.Point(235, 50);
            this.labelFilterRating.Name = "labelFilterRating";
            this.labelFilterRating.Size = new System.Drawing.Size(38, 13);
            this.labelFilterRating.TabIndex = 14;
            this.labelFilterRating.Text = "Rating";
            // 
            // filterRating
            // 
            this.filterRating.FormattingEnabled = true;
            this.filterRating.Location = new System.Drawing.Point(285, 47);
            this.filterRating.Name = "filterRating";
            this.filterRating.Size = new System.Drawing.Size(142, 21);
            this.filterRating.TabIndex = 15;
            // 
            // labelFilterYear
            // 
            this.labelFilterYear.AutoSize = true;
            this.labelFilterYear.Location = new System.Drawing.Point(235, 23);
            this.labelFilterYear.Name = "labelFilterYear";
            this.labelFilterYear.Size = new System.Drawing.Size(29, 13);
            this.labelFilterYear.TabIndex = 11;
            this.labelFilterYear.Text = "Year";
            // 
            // labelFilterGenre
            // 
            this.labelFilterGenre.AutoSize = true;
            this.labelFilterGenre.Location = new System.Drawing.Point(7, 127);
            this.labelFilterGenre.Name = "labelFilterGenre";
            this.labelFilterGenre.Size = new System.Drawing.Size(36, 13);
            this.labelFilterGenre.TabIndex = 9;
            this.labelFilterGenre.Text = "Genre";
            // 
            // filterGenre
            // 
            this.filterGenre.FormattingEnabled = true;
            this.filterGenre.Location = new System.Drawing.Point(57, 124);
            this.filterGenre.Name = "filterGenre";
            this.filterGenre.Size = new System.Drawing.Size(142, 21);
            this.filterGenre.TabIndex = 10;
            // 
            // labelFilterStar
            // 
            this.labelFilterStar.AutoSize = true;
            this.labelFilterStar.Location = new System.Drawing.Point(7, 75);
            this.labelFilterStar.Name = "labelFilterStar";
            this.labelFilterStar.Size = new System.Drawing.Size(26, 13);
            this.labelFilterStar.TabIndex = 4;
            this.labelFilterStar.Text = "Star";
            // 
            // labelFilterDirector
            // 
            this.labelFilterDirector.AutoSize = true;
            this.labelFilterDirector.Location = new System.Drawing.Point(7, 49);
            this.labelFilterDirector.Name = "labelFilterDirector";
            this.labelFilterDirector.Size = new System.Drawing.Size(44, 13);
            this.labelFilterDirector.TabIndex = 2;
            this.labelFilterDirector.Text = "Director";
            // 
            // filterStar
            // 
            this.filterStar.Location = new System.Drawing.Point(57, 72);
            this.filterStar.Name = "filterStar";
            this.filterStar.Size = new System.Drawing.Size(142, 20);
            this.filterStar.TabIndex = 5;
            // 
            // filterDirector
            // 
            this.filterDirector.Location = new System.Drawing.Point(57, 46);
            this.filterDirector.Name = "filterDirector";
            this.filterDirector.Size = new System.Drawing.Size(142, 20);
            this.filterDirector.TabIndex = 3;
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
            // buttonAllReviews
            // 
            this.buttonAllReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllReviews.Location = new System.Drawing.Point(125, 774);
            this.buttonAllReviews.Name = "buttonAllReviews";
            this.buttonAllReviews.Size = new System.Drawing.Size(108, 23);
            this.buttonAllReviews.TabIndex = 6;
            this.buttonAllReviews.Text = "Browse Reviews";
            this.buttonAllReviews.UseVisualStyleBackColor = true;
            this.buttonAllReviews.Click += new System.EventHandler(this.buttonAllReviews_Click);
            // 
            // buttonWatchlist
            // 
            this.buttonWatchlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWatchlist.Location = new System.Drawing.Point(239, 774);
            this.buttonWatchlist.Name = "buttonWatchlist";
            this.buttonWatchlist.Size = new System.Drawing.Size(108, 23);
            this.buttonWatchlist.TabIndex = 7;
            this.buttonWatchlist.Text = "My Watchlist";
            this.buttonWatchlist.UseVisualStyleBackColor = true;
            this.buttonWatchlist.Click += new System.EventHandler(this.buttonWatchlist_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Location = new System.Drawing.Point(9, 774);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(108, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMovie.Location = new System.Drawing.Point(353, 774);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(108, 23);
            this.buttonAddMovie.TabIndex = 8;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(9, 738);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(108, 23);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "Previous Page";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(353, 739);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next Page";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // labelPagination
            // 
            this.labelPagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPagination.Location = new System.Drawing.Point(177, 738);
            this.labelPagination.Name = "labelPagination";
            this.labelPagination.Size = new System.Drawing.Size(100, 23);
            this.labelPagination.TabIndex = 3;
            this.labelPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMovies
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 1200);
            this.MinimumSize = new System.Drawing.Size(484, 511);
            this.Name = "FormMovies";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.OnLoad);
            this.template.ResumeLayout(false);
            this.template.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            this.panelMovies.ResumeLayout(false);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox template;
        private System.Windows.Forms.Button buttonReviews;
        private System.Windows.Forms.Button buttonAddToWatchlist;
        private System.Windows.Forms.Label textMovieDescription;
        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.Label textMovieInfo;
        private System.Windows.Forms.Panel panelMovies;
        private System.Windows.Forms.Label textMovieStars;
        private System.Windows.Forms.Label textMovieDirector;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label textMovieRating;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Button buttonFilterReset;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelFilterRating;
        private System.Windows.Forms.ComboBox filterRating;
        private System.Windows.Forms.Label labelFilterYear;
        private System.Windows.Forms.Label labelFilterGenre;
        private System.Windows.Forms.ComboBox filterGenre;
        private System.Windows.Forms.Label labelFilterStar;
        private System.Windows.Forms.Label labelFilterDirector;
        private System.Windows.Forms.TextBox filterStar;
        private System.Windows.Forms.TextBox filterDirector;
        private System.Windows.Forms.TextBox filterTitle;
        private System.Windows.Forms.Label labelFilterTitle;
        private System.Windows.Forms.Button buttonEditMovie;
        private System.Windows.Forms.Button buttonAllReviews;
        private System.Windows.Forms.Button buttonWatchlist;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Label labelPagination;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.ComboBox filterSortBy;
        private System.Windows.Forms.Label labelSortOrder;
        private System.Windows.Forms.ComboBox filterSortOrder;
        private System.Windows.Forms.Label labelDurationExt;
        private System.Windows.Forms.NumericUpDown filterDuration;
        private System.Windows.Forms.NumericUpDown filterYear;
        private System.Windows.Forms.Label labelYearPlus;
    }
}

