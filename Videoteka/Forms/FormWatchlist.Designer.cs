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
            this.groupFilter = new System.Windows.Forms.GroupBox();
            this.labelSortOrder = new System.Windows.Forms.Label();
            this.filterSortOrder = new System.Windows.Forms.ComboBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.filterSortBy = new System.Windows.Forms.ComboBox();
            this.buttonFilterReset = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.radioReviewed = new System.Windows.Forms.RadioButton();
            this.radioWatched = new System.Windows.Forms.RadioButton();
            this.radioUnwatched = new System.Windows.Forms.RadioButton();
            this.labelPagination = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.groupRadio = new System.Windows.Forms.GroupBox();
            this.panelMovies = new System.Windows.Forms.Panel();
            this.template = new System.Windows.Forms.GroupBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textMovieRating = new System.Windows.Forms.Label();
            this.textMovieStars = new System.Windows.Forms.Label();
            this.textMovieDirector = new System.Windows.Forms.Label();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.buttonReviews = new System.Windows.Forms.Button();
            this.buttonAddToWatched = new System.Windows.Forms.Button();
            this.textMovieDescription = new System.Windows.Forms.Label();
            this.poster = new System.Windows.Forms.PictureBox();
            this.textMovieInfo = new System.Windows.Forms.Label();
            this.groupFilter.SuspendLayout();
            this.groupRadio.SuspendLayout();
            this.panelMovies.SuspendLayout();
            this.template.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            this.SuspendLayout();
            // 
            // groupFilter
            // 
            this.groupFilter.Controls.Add(this.labelSortOrder);
            this.groupFilter.Controls.Add(this.filterSortOrder);
            this.groupFilter.Controls.Add(this.labelSortBy);
            this.groupFilter.Controls.Add(this.filterSortBy);
            this.groupFilter.Controls.Add(this.buttonFilterReset);
            this.groupFilter.Controls.Add(this.buttonFilter);
            this.groupFilter.Location = new System.Drawing.Point(247, 12);
            this.groupFilter.Name = "groupFilter";
            this.groupFilter.Size = new System.Drawing.Size(209, 105);
            this.groupFilter.TabIndex = 1;
            this.groupFilter.TabStop = false;
            this.groupFilter.Text = "Sort Watchlist";
            // 
            // labelSortOrder
            // 
            this.labelSortOrder.AutoSize = true;
            this.labelSortOrder.Location = new System.Drawing.Point(9, 47);
            this.labelSortOrder.Name = "labelSortOrder";
            this.labelSortOrder.Size = new System.Drawing.Size(33, 13);
            this.labelSortOrder.TabIndex = 2;
            this.labelSortOrder.Text = "Order";
            // 
            // filterSortOrder
            // 
            this.filterSortOrder.FormattingEnabled = true;
            this.filterSortOrder.Location = new System.Drawing.Point(59, 44);
            this.filterSortOrder.Name = "filterSortOrder";
            this.filterSortOrder.Size = new System.Drawing.Size(142, 21);
            this.filterSortOrder.TabIndex = 3;
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.Location = new System.Drawing.Point(9, 22);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(40, 13);
            this.labelSortBy.TabIndex = 0;
            this.labelSortBy.Text = "Sort by";
            // 
            // filterSortBy
            // 
            this.filterSortBy.FormattingEnabled = true;
            this.filterSortBy.Location = new System.Drawing.Point(59, 18);
            this.filterSortBy.Name = "filterSortBy";
            this.filterSortBy.Size = new System.Drawing.Size(142, 21);
            this.filterSortBy.TabIndex = 1;
            // 
            // buttonFilterReset
            // 
            this.buttonFilterReset.Location = new System.Drawing.Point(126, 71);
            this.buttonFilterReset.Name = "buttonFilterReset";
            this.buttonFilterReset.Size = new System.Drawing.Size(75, 23);
            this.buttonFilterReset.TabIndex = 5;
            this.buttonFilterReset.Text = "Reset Sorting";
            this.buttonFilterReset.UseVisualStyleBackColor = true;
            this.buttonFilterReset.Click += new System.EventHandler(this.buttonFilterReset_Click);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(12, 71);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(108, 23);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Apply Sorting";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // radioReviewed
            // 
            this.radioReviewed.AutoSize = true;
            this.radioReviewed.Location = new System.Drawing.Point(13, 66);
            this.radioReviewed.Name = "radioReviewed";
            this.radioReviewed.Size = new System.Drawing.Size(73, 17);
            this.radioReviewed.TabIndex = 2;
            this.radioReviewed.Text = "Reviewed";
            this.radioReviewed.UseVisualStyleBackColor = true;
            this.radioReviewed.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioWatched
            // 
            this.radioWatched.AutoSize = true;
            this.radioWatched.Location = new System.Drawing.Point(13, 43);
            this.radioWatched.Name = "radioWatched";
            this.radioWatched.Size = new System.Drawing.Size(69, 17);
            this.radioWatched.TabIndex = 1;
            this.radioWatched.Text = "Watched";
            this.radioWatched.UseVisualStyleBackColor = true;
            this.radioWatched.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioUnwatched
            // 
            this.radioUnwatched.AutoSize = true;
            this.radioUnwatched.Checked = true;
            this.radioUnwatched.Location = new System.Drawing.Point(13, 20);
            this.radioUnwatched.Name = "radioUnwatched";
            this.radioUnwatched.Size = new System.Drawing.Size(80, 17);
            this.radioUnwatched.TabIndex = 0;
            this.radioUnwatched.TabStop = true;
            this.radioUnwatched.Text = "Unwatched";
            this.radioUnwatched.UseVisualStyleBackColor = true;
            this.radioUnwatched.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // labelPagination
            // 
            this.labelPagination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPagination.Location = new System.Drawing.Point(177, 690);
            this.labelPagination.Name = "labelPagination";
            this.labelPagination.Size = new System.Drawing.Size(100, 23);
            this.labelPagination.TabIndex = 4;
            this.labelPagination.Text = "1 / 10";
            this.labelPagination.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(353, 691);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 23);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next Page";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrev.Location = new System.Drawing.Point(9, 690);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(108, 23);
            this.buttonPrev.TabIndex = 3;
            this.buttonPrev.Text = "Previous Page";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // groupRadio
            // 
            this.groupRadio.Controls.Add(this.radioUnwatched);
            this.groupRadio.Controls.Add(this.radioWatched);
            this.groupRadio.Controls.Add(this.radioReviewed);
            this.groupRadio.Location = new System.Drawing.Point(12, 12);
            this.groupRadio.Name = "groupRadio";
            this.groupRadio.Size = new System.Drawing.Size(229, 100);
            this.groupRadio.TabIndex = 0;
            this.groupRadio.TabStop = false;
            this.groupRadio.Text = "Show Watchlist";
            // 
            // panelMovies
            // 
            this.panelMovies.AutoScroll = true;
            this.panelMovies.BackgroundImage = global::Videoteka.Properties.Resources.reel12;
            this.panelMovies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelMovies.Controls.Add(this.template);
            this.panelMovies.Location = new System.Drawing.Point(0, 123);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(468, 561);
            this.panelMovies.TabIndex = 2;
            // 
            // template
            // 
            this.template.Controls.Add(this.buttonRemove);
            this.template.Controls.Add(this.textMovieRating);
            this.template.Controls.Add(this.textMovieStars);
            this.template.Controls.Add(this.textMovieDirector);
            this.template.Controls.Add(this.labelStars);
            this.template.Controls.Add(this.labelDirector);
            this.template.Controls.Add(this.buttonReviews);
            this.template.Controls.Add(this.buttonAddToWatched);
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
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(343, 167);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(78, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Won\'t Watch";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // textMovieRating
            // 
            this.textMovieRating.Location = new System.Drawing.Point(135, 33);
            this.textMovieRating.Name = "textMovieRating";
            this.textMovieRating.Size = new System.Drawing.Size(286, 13);
            this.textMovieRating.TabIndex = 1;
            this.textMovieRating.Text = "5/10 stars - 15 reviews";
            // 
            // textMovieStars
            // 
            this.textMovieStars.Location = new System.Drawing.Point(174, 146);
            this.textMovieStars.Name = "textMovieStars";
            this.textMovieStars.Size = new System.Drawing.Size(247, 13);
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
            this.buttonReviews.TabIndex = 7;
            this.buttonReviews.Text = "Read Reviews";
            this.buttonReviews.UseVisualStyleBackColor = true;
            // 
            // buttonAddToWatched
            // 
            this.buttonAddToWatched.Location = new System.Drawing.Point(238, 167);
            this.buttonAddToWatched.Name = "buttonAddToWatched";
            this.buttonAddToWatched.Size = new System.Drawing.Size(99, 23);
            this.buttonAddToWatched.TabIndex = 8;
            this.buttonAddToWatched.Text = "Watched";
            this.buttonAddToWatched.UseVisualStyleBackColor = true;
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
            // FormWatchlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 720);
            this.Controls.Add(this.groupRadio);
            this.Controls.Add(this.labelPagination);
            this.Controls.Add(this.groupFilter);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.panelMovies);
            this.Controls.Add(this.buttonPrev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormWatchlist";
            this.Text = "Watchlist";
            this.Load += new System.EventHandler(this.OnLoad);
            this.groupFilter.ResumeLayout(false);
            this.groupFilter.PerformLayout();
            this.groupRadio.ResumeLayout(false);
            this.groupRadio.PerformLayout();
            this.panelMovies.ResumeLayout(false);
            this.template.ResumeLayout(false);
            this.template.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMovies;
        private System.Windows.Forms.GroupBox template;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label textMovieRating;
        private System.Windows.Forms.Label textMovieStars;
        private System.Windows.Forms.Label textMovieDirector;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Button buttonReviews;
        private System.Windows.Forms.Button buttonAddToWatched;
        private System.Windows.Forms.Label textMovieDescription;
        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.Label textMovieInfo;
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
        private System.Windows.Forms.GroupBox groupRadio;
    }
}