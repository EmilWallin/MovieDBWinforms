namespace MovieDBSearch
{
    partial class formMovieSearch
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBoxMain = new System.Windows.Forms.GroupBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.radioTitle = new System.Windows.Forms.RadioButton();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.grpBoxInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.linkHomepage = new System.Windows.Forms.LinkLabel();
            this.lblGenre = new System.Windows.Forms.Label();
            this.labelNoImage = new System.Windows.Forms.Label();
            this.picturePoster = new System.Windows.Forms.PictureBox();
            this.lblRelease = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSynopsis = new System.Windows.Forms.Label();
            this.textBoxSynopsis = new System.Windows.Forms.TextBox();
            this.grpBoxMain.SuspendLayout();
            this.grpBoxInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBoxMain
            // 
            this.grpBoxMain.Controls.Add(this.listBoxResults);
            this.grpBoxMain.Controls.Add(this.lblSearchBy);
            this.grpBoxMain.Controls.Add(this.radioTitle);
            this.grpBoxMain.Controls.Add(this.radioId);
            this.grpBoxMain.Controls.Add(this.textBoxSearch);
            this.grpBoxMain.Location = new System.Drawing.Point(12, 15);
            this.grpBoxMain.Name = "grpBoxMain";
            this.grpBoxMain.Size = new System.Drawing.Size(318, 323);
            this.grpBoxMain.TabIndex = 0;
            this.grpBoxMain.TabStop = false;
            this.grpBoxMain.Text = "Search Movies";
            // 
            // listBoxResults
            // 
            this.listBoxResults.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.ItemHeight = 17;
            this.listBoxResults.Location = new System.Drawing.Point(6, 85);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(300, 225);
            this.listBoxResults.TabIndex = 4;
            this.listBoxResults.SelectedIndexChanged += new System.EventHandler(this.listBoxResults_SelectedIndexChanged);
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchBy.Location = new System.Drawing.Point(6, 22);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(68, 17);
            this.lblSearchBy.TabIndex = 3;
            this.lblSearchBy.Text = "Search by:";
            // 
            // radioTitle
            // 
            this.radioTitle.AutoSize = true;
            this.radioTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioTitle.Location = new System.Drawing.Point(123, 22);
            this.radioTitle.Name = "radioTitle";
            this.radioTitle.Size = new System.Drawing.Size(50, 21);
            this.radioTitle.TabIndex = 2;
            this.radioTitle.Text = "Title";
            this.radioTitle.UseVisualStyleBackColor = true;
            this.radioTitle.CheckedChanged += new System.EventHandler(this.radioTitle_CheckedChanged);
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Checked = true;
            this.radioId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioId.Location = new System.Drawing.Point(80, 22);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(37, 21);
            this.radioId.TabIndex = 1;
            this.radioId.TabStop = true;
            this.radioId.Text = "Id";
            this.radioId.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSearch.Location = new System.Drawing.Point(6, 47);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(300, 25);
            this.textBoxSearch.TabIndex = 0;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // grpBoxInfo
            // 
            this.grpBoxInfo.Controls.Add(this.label1);
            this.grpBoxInfo.Controls.Add(this.lblLanguage);
            this.grpBoxInfo.Controls.Add(this.lblRuntime);
            this.grpBoxInfo.Controls.Add(this.linkHomepage);
            this.grpBoxInfo.Controls.Add(this.lblGenre);
            this.grpBoxInfo.Controls.Add(this.labelNoImage);
            this.grpBoxInfo.Controls.Add(this.picturePoster);
            this.grpBoxInfo.Controls.Add(this.lblRelease);
            this.grpBoxInfo.Controls.Add(this.lblRating);
            this.grpBoxInfo.Controls.Add(this.lblTitle);
            this.grpBoxInfo.Controls.Add(this.lblSynopsis);
            this.grpBoxInfo.Controls.Add(this.textBoxSynopsis);
            this.grpBoxInfo.Location = new System.Drawing.Point(336, 15);
            this.grpBoxInfo.Name = "grpBoxInfo";
            this.grpBoxInfo.Size = new System.Drawing.Size(545, 323);
            this.grpBoxInfo.TabIndex = 1;
            this.grpBoxInfo.TabStop = false;
            this.grpBoxInfo.Text = "Movie Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 11;
            this.label1.Text = "Genre(s):";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(94, 295);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(107, 15);
            this.lblLanguage.TabIndex = 10;
            this.lblLanguage.Text = "Original Language:";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRuntime.Location = new System.Drawing.Point(6, 120);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(56, 14);
            this.lblRuntime.TabIndex = 9;
            this.lblRuntime.Text = "Runtime:";
            // 
            // linkHomepage
            // 
            this.linkHomepage.AutoSize = true;
            this.linkHomepage.Location = new System.Drawing.Point(6, 295);
            this.linkHomepage.Name = "linkHomepage";
            this.linkHomepage.Size = new System.Drawing.Size(66, 15);
            this.linkHomepage.TabIndex = 8;
            this.linkHomepage.TabStop = true;
            this.linkHomepage.Text = "Homepage";
            this.linkHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHomepage_LinkClicked);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenre.Location = new System.Drawing.Point(6, 100);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(0, 14);
            this.lblGenre.TabIndex = 7;
            // 
            // labelNoImage
            // 
            this.labelNoImage.AutoSize = true;
            this.labelNoImage.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoImage.Location = new System.Drawing.Point(358, 156);
            this.labelNoImage.Name = "labelNoImage";
            this.labelNoImage.Size = new System.Drawing.Size(0, 16);
            this.labelNoImage.TabIndex = 6;
            // 
            // picturePoster
            // 
            this.picturePoster.Location = new System.Drawing.Point(346, 22);
            this.picturePoster.Name = "picturePoster";
            this.picturePoster.Size = new System.Drawing.Size(193, 288);
            this.picturePoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picturePoster.TabIndex = 5;
            this.picturePoster.TabStop = false;
            // 
            // lblRelease
            // 
            this.lblRelease.AutoSize = true;
            this.lblRelease.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRelease.Location = new System.Drawing.Point(6, 40);
            this.lblRelease.Name = "lblRelease";
            this.lblRelease.Size = new System.Drawing.Size(86, 14);
            this.lblRelease.TabIndex = 4;
            this.lblRelease.Text = "Release Date: ";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRating.Location = new System.Drawing.Point(6, 60);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(45, 14);
            this.lblRating.TabIndex = 3;
            this.lblRating.Text = "Rating:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(6, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 19);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title of the movie";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSynopsis
            // 
            this.lblSynopsis.AutoSize = true;
            this.lblSynopsis.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSynopsis.Location = new System.Drawing.Point(6, 135);
            this.lblSynopsis.Name = "lblSynopsis";
            this.lblSynopsis.Size = new System.Drawing.Size(64, 18);
            this.lblSynopsis.TabIndex = 1;
            this.lblSynopsis.Text = "Synopsis";
            // 
            // textBoxSynopsis
            // 
            this.textBoxSynopsis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSynopsis.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSynopsis.Location = new System.Drawing.Point(6, 156);
            this.textBoxSynopsis.Multiline = true;
            this.textBoxSynopsis.Name = "textBoxSynopsis";
            this.textBoxSynopsis.ReadOnly = true;
            this.textBoxSynopsis.Size = new System.Drawing.Size(334, 133);
            this.textBoxSynopsis.TabIndex = 0;
            // 
            // formMovieSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 353);
            this.Controls.Add(this.grpBoxInfo);
            this.Controls.Add(this.grpBoxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formMovieSearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Movie Search";
            this.grpBoxMain.ResumeLayout(false);
            this.grpBoxMain.PerformLayout();
            this.grpBoxInfo.ResumeLayout(false);
            this.grpBoxInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBoxMain;
        private Label lblSearchBy;
        private RadioButton radioTitle;
        private RadioButton radioId;
        private TextBox textBoxSearch;
        private ListBox listBoxResults;
        private GroupBox grpBoxInfo;
        private TextBox textBoxSynopsis;
        private Label lblRating;
        private Label lblTitle;
        private Label lblSynopsis;
        private Label lblRelease;
        private PictureBox picturePoster;
        private Label labelNoImage;
        private Label lblGenre;
        private LinkLabel linkHomepage;
        private Label lblRuntime;
        private Label lblLanguage;
        private Label label1;
    }
}