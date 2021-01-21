namespace MangaKaDownloader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.downloadButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.selectPathButton = new System.Windows.Forms.Button();
            this.pathLabel = new System.Windows.Forms.Label();
            this.showDestinationButton = new System.Windows.Forms.Button();
            this.safeDownloadButton = new System.Windows.Forms.Button();
            this.fastDownloadButton = new System.Windows.Forms.Button();
            this.downSpeedLabel = new System.Windows.Forms.Label();
            this.siteList = new System.Windows.Forms.ComboBox();
            this.siteVisitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.nazevLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.englishButton = new System.Windows.Forms.Button();
            this.czechButton = new System.Windows.Forms.Button();
            this.singleChapterCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.BackColor = System.Drawing.Color.Transparent;
            this.downloadButton.FlatAppearance.BorderSize = 0;
            this.downloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.downloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.Color.White;
            this.downloadButton.Location = new System.Drawing.Point(12, 224);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(354, 55);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "DOWNLOAD";
            this.downloadButton.UseVisualStyleBackColor = false;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.BackColor = System.Drawing.Color.LightGray;
            this.urlTextBox.ForeColor = System.Drawing.Color.White;
            this.urlTextBox.Location = new System.Drawing.Point(12, 36);
            this.urlTextBox.Multiline = true;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(535, 44);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.Text = "https://mangakakalot.com/something";
            // 
            // selectPathButton
            // 
            this.selectPathButton.BackColor = System.Drawing.Color.Transparent;
            this.selectPathButton.FlatAppearance.BorderSize = 0;
            this.selectPathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.selectPathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.selectPathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPathButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPathButton.ForeColor = System.Drawing.Color.White;
            this.selectPathButton.Location = new System.Drawing.Point(12, 98);
            this.selectPathButton.Name = "selectPathButton";
            this.selectPathButton.Size = new System.Drawing.Size(354, 55);
            this.selectPathButton.TabIndex = 2;
            this.selectPathButton.Text = "select path";
            this.selectPathButton.UseVisualStyleBackColor = false;
            this.selectPathButton.Click += new System.EventHandler(this.selectPathButton_Click);
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.BackColor = System.Drawing.Color.Transparent;
            this.pathLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathLabel.ForeColor = System.Drawing.Color.White;
            this.pathLabel.Location = new System.Drawing.Point(12, 80);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(49, 20);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "path...";
            // 
            // showDestinationButton
            // 
            this.showDestinationButton.BackColor = System.Drawing.Color.Transparent;
            this.showDestinationButton.FlatAppearance.BorderSize = 0;
            this.showDestinationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.showDestinationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.showDestinationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDestinationButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showDestinationButton.ForeColor = System.Drawing.Color.White;
            this.showDestinationButton.Location = new System.Drawing.Point(12, 285);
            this.showDestinationButton.Name = "showDestinationButton";
            this.showDestinationButton.Size = new System.Drawing.Size(354, 55);
            this.showDestinationButton.TabIndex = 4;
            this.showDestinationButton.Text = "show destination";
            this.showDestinationButton.UseVisualStyleBackColor = false;
            this.showDestinationButton.Click += new System.EventHandler(this.showDestinationButton_Click);
            // 
            // safeDownloadButton
            // 
            this.safeDownloadButton.BackColor = System.Drawing.Color.Transparent;
            this.safeDownloadButton.FlatAppearance.BorderSize = 2;
            this.safeDownloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.safeDownloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.safeDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.safeDownloadButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.safeDownloadButton.ForeColor = System.Drawing.Color.White;
            this.safeDownloadButton.Location = new System.Drawing.Point(472, 107);
            this.safeDownloadButton.Name = "safeDownloadButton";
            this.safeDownloadButton.Size = new System.Drawing.Size(75, 30);
            this.safeDownloadButton.TabIndex = 5;
            this.safeDownloadButton.Text = "SAFE";
            this.safeDownloadButton.UseVisualStyleBackColor = false;
            this.safeDownloadButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // fastDownloadButton
            // 
            this.fastDownloadButton.BackColor = System.Drawing.Color.Transparent;
            this.fastDownloadButton.FlatAppearance.BorderSize = 2;
            this.fastDownloadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.fastDownloadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.fastDownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fastDownloadButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastDownloadButton.ForeColor = System.Drawing.Color.White;
            this.fastDownloadButton.Location = new System.Drawing.Point(381, 107);
            this.fastDownloadButton.Name = "fastDownloadButton";
            this.fastDownloadButton.Size = new System.Drawing.Size(75, 30);
            this.fastDownloadButton.TabIndex = 6;
            this.fastDownloadButton.Text = "FAST";
            this.fastDownloadButton.UseVisualStyleBackColor = false;
            this.fastDownloadButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // downSpeedLabel
            // 
            this.downSpeedLabel.AutoSize = true;
            this.downSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.downSpeedLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downSpeedLabel.ForeColor = System.Drawing.Color.White;
            this.downSpeedLabel.Location = new System.Drawing.Point(377, 140);
            this.downSpeedLabel.Name = "downSpeedLabel";
            this.downSpeedLabel.Size = new System.Drawing.Size(147, 20);
            this.downSpeedLabel.TabIndex = 7;
            this.downSpeedLabel.Text = "Download speed: SAFE\r\n";
            // 
            // siteList
            // 
            this.siteList.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteList.ForeColor = System.Drawing.Color.White;
            this.siteList.FormattingEnabled = true;
            this.siteList.Items.AddRange(new object[] {
            "mangakakalot.com",
            "manganelo.com",
            "comicextra.com"});
            this.siteList.Location = new System.Drawing.Point(381, 80);
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(166, 26);
            this.siteList.TabIndex = 8;
            // 
            // siteVisitButton
            // 
            this.siteVisitButton.BackColor = System.Drawing.Color.Transparent;
            this.siteVisitButton.FlatAppearance.BorderSize = 2;
            this.siteVisitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.siteVisitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.siteVisitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siteVisitButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siteVisitButton.ForeColor = System.Drawing.Color.White;
            this.siteVisitButton.Location = new System.Drawing.Point(381, 159);
            this.siteVisitButton.Name = "siteVisitButton";
            this.siteVisitButton.Size = new System.Drawing.Size(166, 47);
            this.siteVisitButton.TabIndex = 9;
            this.siteVisitButton.Text = "Take me to the site";
            this.siteVisitButton.UseVisualStyleBackColor = false;
            this.siteVisitButton.Click += new System.EventHandler(this.siteVisitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::MangaKatDownloader.Properties.Resources.catfin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(149, 159);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 59);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.aboutButton);
            this.panel1.Controls.Add(this.nazevLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 34);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // aboutButton
            // 
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Location = new System.Drawing.Point(115, 0);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(56, 34);
            this.aboutButton.TabIndex = 15;
            this.aboutButton.Text = "about";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // nazevLabel
            // 
            this.nazevLabel.AutoSize = true;
            this.nazevLabel.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nazevLabel.ForeColor = System.Drawing.Color.White;
            this.nazevLabel.Location = new System.Drawing.Point(36, 7);
            this.nazevLabel.Name = "nazevLabel";
            this.nazevLabel.Size = new System.Drawing.Size(73, 20);
            this.nazevLabel.TabIndex = 14;
            this.nazevLabel.Text = "MangaKat";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::MangaKatDownloader.Properties.Resources.catfin;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(471, -7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(34, 41);
            this.minimizeButton.TabIndex = 12;
            this.minimizeButton.Text = "_";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(511, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 34);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // englishButton
            // 
            this.englishButton.BackColor = System.Drawing.Color.Transparent;
            this.englishButton.FlatAppearance.BorderSize = 2;
            this.englishButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.englishButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.englishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.englishButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.englishButton.ForeColor = System.Drawing.Color.White;
            this.englishButton.Location = new System.Drawing.Point(381, 310);
            this.englishButton.Name = "englishButton";
            this.englishButton.Size = new System.Drawing.Size(75, 30);
            this.englishButton.TabIndex = 12;
            this.englishButton.Text = "English";
            this.englishButton.UseVisualStyleBackColor = false;
            this.englishButton.Click += new System.EventHandler(this.englishButton_Click);
            // 
            // czechButton
            // 
            this.czechButton.BackColor = System.Drawing.Color.Transparent;
            this.czechButton.FlatAppearance.BorderSize = 2;
            this.czechButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.czechButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.czechButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.czechButton.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.czechButton.ForeColor = System.Drawing.Color.White;
            this.czechButton.Location = new System.Drawing.Point(473, 310);
            this.czechButton.Name = "czechButton";
            this.czechButton.Size = new System.Drawing.Size(75, 30);
            this.czechButton.TabIndex = 13;
            this.czechButton.Text = "Čeština";
            this.czechButton.UseVisualStyleBackColor = false;
            this.czechButton.Click += new System.EventHandler(this.czechButton_Click);
            // 
            // singleChapterCheck
            // 
            this.singleChapterCheck.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleChapterCheck.ForeColor = System.Drawing.Color.White;
            this.singleChapterCheck.Location = new System.Drawing.Point(381, 212);
            this.singleChapterCheck.Name = "singleChapterCheck";
            this.singleChapterCheck.Size = new System.Drawing.Size(167, 92);
            this.singleChapterCheck.TabIndex = 14;
            this.singleChapterCheck.Text = "Check this if you\'re downloading a single chapter";
            this.singleChapterCheck.UseVisualStyleBackColor = true;
            this.singleChapterCheck.CheckedChanged += new System.EventHandler(this.singleChapterCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(559, 352);
            this.Controls.Add(this.singleChapterCheck);
            this.Controls.Add(this.czechButton);
            this.Controls.Add(this.englishButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.siteVisitButton);
            this.Controls.Add(this.siteList);
            this.Controls.Add(this.downSpeedLabel);
            this.Controls.Add(this.fastDownloadButton);
            this.Controls.Add(this.safeDownloadButton);
            this.Controls.Add(this.showDestinationButton);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.selectPathButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.downloadButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MangaKaDownloader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button selectPathButton;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Button showDestinationButton;
        private System.Windows.Forms.Button safeDownloadButton;
        private System.Windows.Forms.Button fastDownloadButton;
        private System.Windows.Forms.Label downSpeedLabel;
        private System.Windows.Forms.ComboBox siteList;
        private System.Windows.Forms.Button siteVisitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nazevLabel;
        private System.Windows.Forms.Button englishButton;
        private System.Windows.Forms.Button czechButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.CheckBox singleChapterCheck;
    }
}

