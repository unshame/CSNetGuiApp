namespace Videoteka {
    partial class FormAddMovie {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddMovie));
            this.labelTitle = new System.Windows.Forms.Label();
            this.addTitle = new System.Windows.Forms.TextBox();
            this.addDirector = new System.Windows.Forms.TextBox();
            this.labelDIrector = new System.Windows.Forms.Label();
            this.addStars = new System.Windows.Forms.TextBox();
            this.labelStars = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.addGenre = new System.Windows.Forms.ComboBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.addDuration = new System.Windows.Forms.NumericUpDown();
            this.labelDurationExt = new System.Windows.Forms.Label();
            this.addDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.addPosterDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelPoster = new System.Windows.Forms.Label();
            this.addPosterButton = new System.Windows.Forms.Button();
            this.addPosterPath = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.addYear = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.addDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addYear)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 15);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Title";
            // 
            // addTitle
            // 
            this.addTitle.Location = new System.Drawing.Point(65, 12);
            this.addTitle.Name = "addTitle";
            this.addTitle.Size = new System.Drawing.Size(142, 20);
            this.addTitle.TabIndex = 2;
            // 
            // addDirector
            // 
            this.addDirector.Location = new System.Drawing.Point(65, 38);
            this.addDirector.Name = "addDirector";
            this.addDirector.Size = new System.Drawing.Size(142, 20);
            this.addDirector.TabIndex = 3;
            // 
            // labelDIrector
            // 
            this.labelDIrector.AutoSize = true;
            this.labelDIrector.Location = new System.Drawing.Point(12, 41);
            this.labelDIrector.Name = "labelDIrector";
            this.labelDIrector.Size = new System.Drawing.Size(44, 13);
            this.labelDIrector.TabIndex = 4;
            this.labelDIrector.Text = "Director";
            // 
            // addStars
            // 
            this.addStars.Location = new System.Drawing.Point(65, 64);
            this.addStars.Name = "addStars";
            this.addStars.Size = new System.Drawing.Size(142, 20);
            this.addStars.TabIndex = 5;
            // 
            // labelStars
            // 
            this.labelStars.AutoSize = true;
            this.labelStars.Location = new System.Drawing.Point(12, 67);
            this.labelStars.Name = "labelStars";
            this.labelStars.Size = new System.Drawing.Size(31, 13);
            this.labelStars.TabIndex = 6;
            this.labelStars.Text = "Stars";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(12, 96);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(36, 13);
            this.labelGenre.TabIndex = 8;
            this.labelGenre.Text = "Genre";
            // 
            // addGenre
            // 
            this.addGenre.FormattingEnabled = true;
            this.addGenre.Location = new System.Drawing.Point(65, 93);
            this.addGenre.Name = "addGenre";
            this.addGenre.Size = new System.Drawing.Size(142, 21);
            this.addGenre.TabIndex = 13;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(12, 148);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 13);
            this.labelDuration.TabIndex = 14;
            this.labelDuration.Text = "Duration";
            // 
            // addDuration
            // 
            this.addDuration.Location = new System.Drawing.Point(65, 146);
            this.addDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.addDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addDuration.Name = "addDuration";
            this.addDuration.Size = new System.Drawing.Size(93, 20);
            this.addDuration.TabIndex = 15;
            this.addDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelDurationExt
            // 
            this.labelDurationExt.AutoSize = true;
            this.labelDurationExt.Location = new System.Drawing.Point(164, 148);
            this.labelDurationExt.Name = "labelDurationExt";
            this.labelDurationExt.Size = new System.Drawing.Size(43, 13);
            this.labelDurationExt.TabIndex = 16;
            this.labelDurationExt.Text = "minutes";
            // 
            // addDescription
            // 
            this.addDescription.Location = new System.Drawing.Point(15, 211);
            this.addDescription.Multiline = true;
            this.addDescription.Name = "addDescription";
            this.addDescription.Size = new System.Drawing.Size(192, 100);
            this.addDescription.TabIndex = 17;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 195);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 18;
            this.labelDescription.Text = "Description";
            // 
            // addPosterDialog
            // 
            this.addPosterDialog.Filter = "JPEG Image|*jpg";
            // 
            // labelPoster
            // 
            this.labelPoster.AutoSize = true;
            this.labelPoster.Location = new System.Drawing.Point(12, 175);
            this.labelPoster.Name = "labelPoster";
            this.labelPoster.Size = new System.Drawing.Size(37, 13);
            this.labelPoster.TabIndex = 20;
            this.labelPoster.Text = "Poster";
            // 
            // addPosterButton
            // 
            this.addPosterButton.Location = new System.Drawing.Point(147, 170);
            this.addPosterButton.Name = "addPosterButton";
            this.addPosterButton.Size = new System.Drawing.Size(60, 23);
            this.addPosterButton.TabIndex = 21;
            this.addPosterButton.Text = "Select...";
            this.addPosterButton.UseVisualStyleBackColor = true;
            this.addPosterButton.Click += new System.EventHandler(this.addPosterButton_Click);
            // 
            // addPosterPath
            // 
            this.addPosterPath.Location = new System.Drawing.Point(65, 172);
            this.addPosterPath.Name = "addPosterPath";
            this.addPosterPath.Size = new System.Drawing.Size(76, 20);
            this.addPosterPath.TabIndex = 22;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(132, 317);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 23;
            this.buttonAdd.Text = "Add Movie";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 122);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(29, 13);
            this.labelYear.TabIndex = 24;
            this.labelYear.Text = "Year";
            // 
            // addYear
            // 
            this.addYear.Location = new System.Drawing.Point(65, 120);
            this.addYear.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.addYear.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.addYear.Name = "addYear";
            this.addYear.Size = new System.Drawing.Size(142, 20);
            this.addYear.TabIndex = 25;
            this.addYear.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // FormAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 344);
            this.Controls.Add(this.addYear);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.addPosterPath);
            this.Controls.Add(this.addPosterButton);
            this.Controls.Add(this.labelPoster);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.addDescription);
            this.Controls.Add(this.labelDurationExt);
            this.Controls.Add(this.addDuration);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.addGenre);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.labelStars);
            this.Controls.Add(this.addStars);
            this.Controls.Add(this.labelDIrector);
            this.Controls.Add(this.addDirector);
            this.Controls.Add(this.addTitle);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAddMovie";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.addDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addYear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox addTitle;
        private System.Windows.Forms.TextBox addDirector;
        private System.Windows.Forms.Label labelDIrector;
        private System.Windows.Forms.TextBox addStars;
        private System.Windows.Forms.Label labelStars;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.ComboBox addGenre;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.NumericUpDown addDuration;
        private System.Windows.Forms.Label labelDurationExt;
        private System.Windows.Forms.TextBox addDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.OpenFileDialog addPosterDialog;
        private System.Windows.Forms.Label labelPoster;
        private System.Windows.Forms.Button addPosterButton;
        private System.Windows.Forms.TextBox addPosterPath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.NumericUpDown addYear;
    }
}