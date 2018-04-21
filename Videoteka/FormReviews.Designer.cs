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
            this.groupMovie = new System.Windows.Forms.GroupBox();
            this.buttonDeleteReview = new System.Windows.Forms.Button();
            this.labelMovieRating = new System.Windows.Forms.Label();
            this.buttonMovieInfo = new System.Windows.Forms.Button();
            this.textMovieDescription = new System.Windows.Forms.Label();
            this.labelMovieInfo = new System.Windows.Forms.Label();
            this.groupFilter.SuspendLayout();
            this.panelReviews.SuspendLayout();
            this.groupMovie.SuspendLayout();
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
            this.buttonLogin.Location = new System.Drawing.Point(9, 773);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(108, 23);
            this.buttonLogin.TabIndex = 33;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonWatchlist
            // 
            this.buttonWatchlist.Location = new System.Drawing.Point(239, 773);
            this.buttonWatchlist.Name = "buttonWatchlist";
            this.buttonWatchlist.Size = new System.Drawing.Size(108, 23);
            this.buttonWatchlist.TabIndex = 32;
            this.buttonWatchlist.Text = "My Watchlist";
            this.buttonWatchlist.UseVisualStyleBackColor = true;
            this.buttonWatchlist.Click += new System.EventHandler(this.buttonWatchlist_Click);
            // 
            // buttonAllMovies
            // 
            this.buttonAllMovies.Location = new System.Drawing.Point(125, 773);
            this.buttonAllMovies.Name = "buttonAllMovies";
            this.buttonAllMovies.Size = new System.Drawing.Size(108, 23);
            this.buttonAllMovies.TabIndex = 31;
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
            this.groupFilter.Size = new System.Drawing.Size(443, 107);
            this.groupFilter.TabIndex = 30;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Filter Movies";
            // 
            // labelSortOrder
            // 
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(235, 49);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(33, 13);
            this.labelSortOrder.TabIndex = 27;
            this.labelSortOrder.Text = "Order";
            // 
            // filterSortOrder
            // 
            this.filterSortOrder.FormattingEnabled = true;
            this.filterSortOrder.Location = new System.Drawing.Point(285, 46);
            this.filterSortOrder.Name = "filterSortOrder";
            this.filterSortOrder.Size = new System.Drawing.Size(142, 21);
            this.filterSortOrder.TabIndex = 26;
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
            this.filterSortBy.Location = new System.Drawing.Point(285, 20);
            this.filterSortBy.Name = "filterSortBy";
            this.filterSortBy.Size = new System.Drawing.Size(142, 21);
            this.filterSortBy.TabIndex = 24;
            // 
            // buttonFilterReset
            // 
            this.buttonFilterReset.Location = new System.Drawing.Point(352, 73);
            this.buttonFilterReset.Name = "buttonFilterReset";
            this.buttonFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterReset.TabIndex = 21;
            this.buttonFilterReset.Text = "Reset Filter";
            this.buttonFilterReset.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(238, 73);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(108, 23);
            this.buttonFilter.TabIndex = 20;
            this.buttonFilter.Text = "Apply Filter";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // labelFilterRating
            // 
            this.labelFilterRating.AutoSize = true;
            this.labelFilterRating.Location = new System.Drawing.Point(7, 75);
            this.labelFilterRating.Name = "labelFilterRating";
            this.labelFilterRating.Size = new System.Drawing.Size(38, 13);
            this.labelFilterRating.TabIndex = 17;
            this.labelFilterRating.Text = "Rating";
            // 
            // filterRating
            // 
            this.filterRating.FormattingEnabled = true;
            this.filterRating.Location = new System.Drawing.Point(57, 72);
            this.filterRating.Name = "filterRating";
            this.filterRating.Size = new System.Drawing.Size(142, 21);
            this.filterRating.TabIndex = 16;
            // 
            // labelFilterUser
            // 
            this.labelFilterUser.AutoSize = true;
            this.labelFilterUser.Location = new System.Drawing.Point(7, 49);
            this.labelFilterUser.Name = "labelFilterUser";
            this.labelFilterUser.Size = new System.Drawing.Size(29, 13);
            this.labelFilterUser.TabIndex = 4;
            this.labelFilterUser.Text = "User";
            // 
            // filterUser
            // 
            this.filterUser.Location = new System.Drawing.Point(57, 46);
            this.filterUser.Name = "filterUser";
            this.filterUser.Size = new System.Drawing.Size(142, 20);
            this.filterUser.TabIndex = 2;
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
            this.panelReviews.AutoScroll = true;
            this.panelReviews.Controls.Add(this.groupMovie);
            this.panelReviews.Location = new System.Drawing.Point(0, 125);
            this.panelReviews.Name = "panelReviews";
            this.panelReviews.Size = new System.Drawing.Size(468, 607);
            this.panelReviews.TabIndex = 29;
            // 
            // groupMovie
            // 
            this.groupMovie.Controls.Add(this.buttonDeleteReview);
            this.groupMovie.Controls.Add(this.labelMovieRating);
            this.groupMovie.Controls.Add(this.buttonMovieInfo);
            this.groupMovie.Controls.Add(this.textMovieDescription);
            this.groupMovie.Controls.Add(this.labelMovieInfo);
            this.groupMovie.Location = new System.Drawing.Point(12, 3);
            this.groupMovie.Name = "groupMovie";
            this.groupMovie.Size = new System.Drawing.Size(427, 163);
            this.groupMovie.TabIndex = 0;
            this.groupMovie.TabStop = false;
            this.groupMovie.Text = "User\'s Review";
            // 
            // buttonDeleteReview
            // 
            this.buttonDeleteReview.Location = new System.Drawing.Point(240, 134);
            this.buttonDeleteReview.Name = "buttonDeleteReview";
            this.buttonDeleteReview.Size = new System.Drawing.Size(78, 23);
            this.buttonDeleteReview.TabIndex = 11;
            this.buttonDeleteReview.Text = "Delete";
            this.buttonDeleteReview.UseVisualStyleBackColor = true;
            // 
            // labelMovieRating
            // 
            this.labelMovieRating.Location = new System.Drawing.Point(6, 33);
            this.labelMovieRating.Name = "labelMovieRating";
            this.labelMovieRating.Size = new System.Drawing.Size(413, 13);
            this.labelMovieRating.TabIndex = 10;
            this.labelMovieRating.Text = "5/10 stars";
            // 
            // buttonMovieInfo
            // 
            this.buttonMovieInfo.Location = new System.Drawing.Point(324, 134);
            this.buttonMovieInfo.Name = "buttonMovieInfo";
            this.buttonMovieInfo.Size = new System.Drawing.Size(97, 23);
            this.buttonMovieInfo.TabIndex = 5;
            this.buttonMovieInfo.Text = "Movie Info";
            this.buttonMovieInfo.UseVisualStyleBackColor = true;
            // 
            // textMovieDescription
            // 
            this.textMovieDescription.Location = new System.Drawing.Point(6, 56);
            this.textMovieDescription.Name = "textMovieDescription";
            this.textMovieDescription.Size = new System.Drawing.Size(413, 74);
            this.textMovieDescription.TabIndex = 3;
            this.textMovieDescription.Text = resources.GetString("textMovieDescription.Text");
            // 
            // labelMovieInfo
            // 
            this.labelMovieInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMovieInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMovieInfo.Location = new System.Drawing.Point(6, 20);
            this.labelMovieInfo.Name = "labelMovieInfo";
            this.labelMovieInfo.Size = new System.Drawing.Size(413, 13);
            this.labelMovieInfo.TabIndex = 0;
            this.labelMovieInfo.Text = "Movie Title";
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormReviews";
            this.Text = "Reviews";
            this.Load += new System.EventHandler(this.FormReviews_Load);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.panelReviews.ResumeLayout(false);
            this.groupMovie.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupMovie;
        private System.Windows.Forms.Button buttonDeleteReview;
        private System.Windows.Forms.Label labelMovieRating;
        private System.Windows.Forms.Button buttonMovieInfo;
        private System.Windows.Forms.Label textMovieDescription;
        private System.Windows.Forms.Label labelMovieInfo;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.ComboBox filterSortBy;
        private System.Windows.Forms.Label labelSortOrder;
        private System.Windows.Forms.ComboBox filterSortOrder;
    }
}