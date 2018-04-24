namespace Videoteka {
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
            this.buttonAllMovies = new System.Windows.Forms.Button();
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.filterSortOrder = new System.Windows.Forms.ComboBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.filterSortBy = new System.Windows.Forms.ComboBox();
            this.buttonFilterReset = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.labelFilterRating = new System.Windows.Forms.Label();
            this.filterRating = new System.Windows.Forms.ComboBox();
            this.labelFilterUser = new System.Windows.Forms.Label();
            this.filterUser = new System.Windows.Forms.TextBox();
            this.filterTitle = new System.Windows.Forms.TextBox();
            this.labelFilterTitle = new System.Windows.Forms.Label();
            this.panelReviews = new System.Windows.Forms.Panel();
            this.template = new System.Windows.Forms.GroupBox();
            this.buttonDeleteReview = new System.Windows.Forms.Button();
            this.labelReviewRating = new System.Windows.Forms.Label();
            this.buttonMovieInfo = new System.Windows.Forms.Button();
            this.textReview = new System.Windows.Forms.Label();
            this.labelMovieTitle = new System.Windows.Forms.Label();
            this.groupFilter.SuspendLayout();
            this.panelReviews.SuspendLayout();
            this.template.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPagination
            // 
            this.labelPagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPagination.Location = new System.Drawing.Point(177, 737);
            this.labelPagination.Name = "labelPagination";
            this.labelPagination.Size = new System.Drawing.Size(100, 23);
            this.labelPagination.TabIndex = 3;
            this.labelPagination.Text = "1 / 10";
            this.labelPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(353, 738);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next Page";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev.Location = new System.Drawing.Point(9, 737);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(108, 23);
            this.buttonPrev.TabIndex = 2;
            this.buttonPrev.Text = "Previous Page";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddMovie.Location = new System.Drawing.Point(353, 773);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(108, 23);
            this.buttonAddMovie.TabIndex = 8;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Location = new System.Drawing.Point(9, 773);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(108, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonWatchlist
            // 
            this.buttonWatchlist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonWatchlist.Location = new System.Drawing.Point(239, 773);
            this.buttonWatchlist.Name = "buttonWatchlist";
            this.buttonWatchlist.Size = new System.Drawing.Size(108, 23);
            this.buttonWatchlist.TabIndex = 7;
            this.buttonWatchlist.Text = "My Watchlist";
            this.buttonWatchlist.UseVisualStyleBackColor = true;
            this.buttonWatchlist.Click += new System.EventHandler(this.buttonWatchlist_Click);
            // 
            // buttonAllMovies
            // 
            this.buttonAllMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAllMovies.Location = new System.Drawing.Point(125, 773);
            this.buttonAllMovies.Name = "buttonAllMovies";
            this.buttonAllMovies.Size = new System.Drawing.Size(108, 23);
            this.buttonAllMovies.TabIndex = 6;
            this.buttonAllMovies.Text = "Browse Movies";
            this.buttonAllMovies.UseVisualStyleBackColor = true;
            this.buttonAllMovies.Click += new System.EventHandler(this.buttonAllMovies_click);
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.labelSortOrder);
            this.groupFilter.Controls.Add(this.filterSortOrder);
            this.groupFilter.Controls.Add(this.labelSortBy);
            this.groupFilter.Controls.Add(this.filterSortBy);
            this.groupFilter.Controls.Add(this.buttonFilterReset);
            this.groupFilter.Controls.Add(this.buttonFilter);
            this.groupFilter.Controls.Add(this.labelFilterRating);
            this.groupFilter.Controls.Add(this.filterRating);
            this.groupFilter.Controls.Add(this.labelFilterUser);
            this.groupFilter.Controls.Add(this.filterUser);
            this.groupFilter.Controls.Add(this.filterTitle);
            this.groupFilter.Controls.Add(this.labelFilterTitle);
            this.groupFilter.Location = new System.Drawing.Point(13, 12);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(443, 104);
            this.groupFilter.TabIndex = 0;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter Reviews";
            // 
            // labelSortOrder
            // 
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(235, 49);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(33, 13);
            this.labelSortOrder.TabIndex = 8;
            this.labelSortOrder.Text = "Order";
            // 
            // filterSortOrder
            // 
            this.filterSortOrder.FormattingEnabled = true;
            this.filterSortOrder.Location = new System.Drawing.Point(285, 46);
            this.filterSortOrder.Name = "filterSortOrder";
            this.filterSortOrder.Size = new System.Drawing.Size(142, 21);
            this.filterSortOrder.TabIndex = 9;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(235, 23);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(40, 13);
            this.labelSortBy.TabIndex = 6;
            this.labelSortBy.Text = "Sort by";
            // 
            // filterSortBy
            // 
            this.filterSortBy.FormattingEnabled = true;
            this.filterSortBy.Location = new System.Drawing.Point(285, 20);
            this.filterSortBy.Name = "filterSortBy";
            this.filterSortBy.Size = new System.Drawing.Size(142, 21);
            this.filterSortBy.TabIndex = 7;
            // 
            // buttonFilterReset
            // 
            this.buttonFilterReset.Location = new System.Drawing.Point(352, 70);
            this.buttonFilterReset.Name = "buttonFilterReset";
            this.buttonFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterReset.TabIndex = 11;
            this.buttonFilterReset.Text = "Reset Filter";
            this.buttonFilterReset.UseVisualStyleBackColor = true;
            this.buttonFilterReset.Click += new System.EventHandler(this.buttonFilterReset_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(238, 70);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(108, 23);
            this.buttonFilter.TabIndex = 10;
            this.buttonFilter.Text = "Apply Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // labelFilterRating
            // 
            this.labelFilterRating.AutoSize = true;
            this.labelFilterRating.Location = new System.Drawing.Point(7, 75);
            this.labelFilterRating.Name = "labelFilterRating";
            this.labelFilterRating.Size = new System.Drawing.Size(38, 13);
            this.labelFilterRating.TabIndex = 4;
            this.labelFilterRating.Text = "Rating";
            // 
            // filterRating
            // 
            this.filterRating.FormattingEnabled = true;
            this.filterRating.Location = new System.Drawing.Point(57, 72);
            this.filterRating.Name = "filterRating";
            this.filterRating.Size = new System.Drawing.Size(142, 21);
            this.filterRating.TabIndex = 5;
            // 
            // labelFilterUser
            // 
            this.labelFilterUser.AutoSize = true;
            this.labelFilterUser.Location = new System.Drawing.Point(7, 49);
            this.labelFilterUser.Name = "labelFilterUser";
            this.labelFilterUser.Size = new System.Drawing.Size(38, 13);
            this.labelFilterUser.TabIndex = 2;
            this.labelFilterUser.Text = "Author";
            // 
            // filterUser
            // 
            this.filterUser.Location = new System.Drawing.Point(57, 46);
            this.filterUser.Name = "filterUser";
            this.filterUser.Size = new System.Drawing.Size(142, 20);
            this.filterUser.TabIndex = 3;
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
            this.labelFilterTitle.Size = new System.Drawing.Size(36, 13);
            this.labelFilterTitle.TabIndex = 0;
            this.labelFilterTitle.Text = "Movie";
            this.labelFilterTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelReviews
            // 
            this.panelReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelReviews.AutoScroll = true;
            this.panelReviews.BackgroundImage = global::Videoteka.Properties.Resources.reel12;
            this.panelReviews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelReviews.Controls.Add(this.template);
            this.panelReviews.Location = new System.Drawing.Point(0, 122);
            this.panelReviews.Name = "panelReviews";
            this.panelReviews.Size = new System.Drawing.Size(468, 610);
            this.panelReviews.TabIndex = 1;
            // 
            // template
            // 
            this.template.AutoSize = true;
            this.template.Controls.Add(this.buttonDeleteReview);
            this.template.Controls.Add(this.labelReviewRating);
            this.template.Controls.Add(this.buttonMovieInfo);
            this.template.Controls.Add(this.textReview);
            this.template.Controls.Add(this.labelMovieTitle);
            this.template.Location = new System.Drawing.Point(12, 0);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(427, 85);
            this.template.TabIndex = 0;
            this.template.TabStop = false;
            this.template.Text = "User\'s Review";
            // 
            // buttonDeleteReview
            // 
            this.buttonDeleteReview.Location = new System.Drawing.Point(239, 23);
            this.buttonDeleteReview.Name = "buttonDeleteReview";
            this.buttonDeleteReview.Size = new System.Drawing.Size(78, 23);
            this.buttonDeleteReview.TabIndex = 11;
            this.buttonDeleteReview.Text = "Delete";
            this.buttonDeleteReview.UseVisualStyleBackColor = true;
            // 
            // labelReviewRating
            // 
            this.labelReviewRating.Location = new System.Drawing.Point(6, 33);
            this.labelReviewRating.Name = "labelReviewRating";
            this.labelReviewRating.Size = new System.Drawing.Size(227, 13);
            this.labelReviewRating.TabIndex = 10;
            this.labelReviewRating.Text = "5/10 stars";
            // 
            // buttonMovieInfo
            // 
            this.buttonMovieInfo.Location = new System.Drawing.Point(324, 23);
            this.buttonMovieInfo.Name = "buttonMovieInfo";
            this.buttonMovieInfo.Size = new System.Drawing.Size(97, 23);
            this.buttonMovieInfo.TabIndex = 5;
            this.buttonMovieInfo.Text = "Movie Info";
            this.buttonMovieInfo.UseVisualStyleBackColor = true;
            // 
            // textReview
            // 
            this.textReview.AutoSize = true;
            this.textReview.Location = new System.Drawing.Point(6, 56);
            this.textReview.MaximumSize = new System.Drawing.Size(413, 0);
            this.textReview.Name = "textReview";
            this.textReview.Size = new System.Drawing.Size(10, 13);
            this.textReview.TabIndex = 3;
            this.textReview.Text = "t";
            // 
            // labelMovieTitle
            // 
            this.labelMovieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMovieTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMovieTitle.Location = new System.Drawing.Point(6, 20);
            this.labelMovieTitle.Name = "labelMovieTitle";
            this.labelMovieTitle.Size = new System.Drawing.Size(227, 13);
            this.labelMovieTitle.TabIndex = 0;
            this.labelMovieTitle.Text = "Movie Title";
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
            this.Controls.Add(this.buttonAllMovies);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.panelReviews);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(484, 900);
            this.MinimumSize = new System.Drawing.Size(484, 511);
            this.Name = "FormReviews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Reviews";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.panelReviews.ResumeLayout(false);
            this.panelReviews.PerformLayout();
            this.template.ResumeLayout(false);
            this.template.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPagination;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonWatchlist;
        private System.Windows.Forms.Button buttonAllMovies;
        private System.Windows.Forms.GroupBox groupFilter;
        private System.Windows.Forms.Button buttonFilterReset;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Label labelFilterRating;
        private System.Windows.Forms.ComboBox filterRating;
        private System.Windows.Forms.Label labelFilterUser;
        private System.Windows.Forms.TextBox filterUser;
        private System.Windows.Forms.TextBox filterTitle;
        private System.Windows.Forms.Label labelFilterTitle;
        private System.Windows.Forms.Panel panelReviews;
        private System.Windows.Forms.GroupBox template;
        private System.Windows.Forms.Button buttonDeleteReview;
        private System.Windows.Forms.Label labelReviewRating;
        private System.Windows.Forms.Button buttonMovieInfo;
        private System.Windows.Forms.Label textReview;
        private System.Windows.Forms.Label labelMovieTitle;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.ComboBox filterSortBy;
        private System.Windows.Forms.Label labelSortOrder;
        private System.Windows.Forms.ComboBox filterSortOrder;
    }
}