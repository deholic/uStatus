namespace uStatus
{
    partial class uStatus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uStatus));
            this.tiProgressbar = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStarPoint = new System.Windows.Forms.ComboBox();
            this.bPlay = new System.Windows.Forms.Button();
            this.cbAddYoutube = new System.Windows.Forms.CheckBox();
            this.bCopy = new System.Windows.Forms.Button();
            this.bNextSong = new System.Windows.Forms.Button();
            this.bPrevSong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pProgressBar = new System.Windows.Forms.Panel();
            this.cbAlwaysTop = new System.Windows.Forms.CheckBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lArtist = new System.Windows.Forms.Label();
            this.pProgressBg = new System.Windows.Forms.Panel();
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tiProgressbar
            // 
            this.tiProgressbar.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 118);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 118);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::uStatus.Properties.Resources.bg;
            this.panel1.Controls.Add(this.cbStarPoint);
            this.panel1.Controls.Add(this.bPlay);
            this.panel1.Controls.Add(this.cbAddYoutube);
            this.panel1.Controls.Add(this.bCopy);
            this.panel1.Controls.Add(this.bNextSong);
            this.panel1.Controls.Add(this.bPrevSong);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 50);
            this.panel1.TabIndex = 1;
            // 
            // cbStarPoint
            // 
            this.cbStarPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStarPoint.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStarPoint.DropDownWidth = 71;
            this.cbStarPoint.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbStarPoint.FormattingEnabled = true;
            this.cbStarPoint.Items.AddRange(new object[] {
            "0☆",
            "1★",
            "2★★",
            "3★★★",
            "4★★★★",
            "5★★★★★"});
            this.cbStarPoint.Location = new System.Drawing.Point(227, 14);
            this.cbStarPoint.Name = "cbStarPoint";
            this.cbStarPoint.Size = new System.Drawing.Size(43, 23);
            this.cbStarPoint.TabIndex = 3;
            this.cbStarPoint.SelectionChangeCommitted += new System.EventHandler(this.cbStarPoint_SelectionChangeCommitted);
            // 
            // bPlay
            // 
            this.bPlay.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bPlay.Location = new System.Drawing.Point(12, 13);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(25, 25);
            this.bPlay.TabIndex = 1;
            this.bPlay.Text = "■";
            this.bPlay.UseVisualStyleBackColor = true;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // cbAddYoutube
            // 
            this.cbAddYoutube.AutoSize = true;
            this.cbAddYoutube.BackColor = System.Drawing.Color.Transparent;
            this.cbAddYoutube.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbAddYoutube.ForeColor = System.Drawing.Color.White;
            this.cbAddYoutube.Location = new System.Drawing.Point(99, 18);
            this.cbAddYoutube.Name = "cbAddYoutube";
            this.cbAddYoutube.Size = new System.Drawing.Size(70, 17);
            this.cbAddYoutube.TabIndex = 2;
            this.cbAddYoutube.Text = "YouTube";
            this.cbAddYoutube.UseVisualStyleBackColor = false;
            // 
            // bCopy
            // 
            this.bCopy.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bCopy.Location = new System.Drawing.Point(43, 13);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(50, 25);
            this.bCopy.TabIndex = 1;
            this.bCopy.Text = "Tweet";
            this.bCopy.UseVisualStyleBackColor = true;
            this.bCopy.Click += new System.EventHandler(this.bCopy_Click_1);
            // 
            // bNextSong
            // 
            this.bNextSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNextSong.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bNextSong.Location = new System.Drawing.Point(307, 13);
            this.bNextSong.Name = "bNextSong";
            this.bNextSong.Size = new System.Drawing.Size(25, 25);
            this.bNextSong.TabIndex = 0;
            this.bNextSong.Text = ">";
            this.bNextSong.UseVisualStyleBackColor = true;
            this.bNextSong.Click += new System.EventHandler(this.bNextSong_Click);
            // 
            // bPrevSong
            // 
            this.bPrevSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bPrevSong.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bPrevSong.Location = new System.Drawing.Point(276, 13);
            this.bPrevSong.Name = "bPrevSong";
            this.bPrevSong.Size = new System.Drawing.Size(25, 25);
            this.bPrevSong.TabIndex = 0;
            this.bPrevSong.Text = "<";
            this.bPrevSong.UseVisualStyleBackColor = true;
            this.bPrevSong.Click += new System.EventHandler(this.bPrevSong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 68);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pProgressBar);
            this.panel3.Controls.Add(this.cbAlwaysTop);
            this.panel3.Controls.Add(this.lTitle);
            this.panel3.Controls.Add(this.lArtist);
            this.panel3.Controls.Add(this.pProgressBg);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 68);
            this.panel3.TabIndex = 3;
            // 
            // pProgressBar
            // 
            this.pProgressBar.BackColor = System.Drawing.Color.Silver;
            this.pProgressBar.Location = new System.Drawing.Point(0, 58);
            this.pProgressBar.Margin = new System.Windows.Forms.Padding(0);
            this.pProgressBar.Name = "pProgressBar";
            this.pProgressBar.Size = new System.Drawing.Size(1, 10);
            this.pProgressBar.TabIndex = 2;
            // 
            // cbAlwaysTop
            // 
            this.cbAlwaysTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbAlwaysTop.AutoSize = true;
            this.cbAlwaysTop.Location = new System.Drawing.Point(317, 12);
            this.cbAlwaysTop.Name = "cbAlwaysTop";
            this.cbAlwaysTop.Size = new System.Drawing.Size(15, 14);
            this.cbAlwaysTop.TabIndex = 1;
            this.cbAlwaysTop.UseVisualStyleBackColor = true;
            this.cbAlwaysTop.Click += new System.EventHandler(this.cbAlwaysTop_CheckedChanged);
            // 
            // lTitle
            // 
            this.lTitle.AutoEllipsis = true;
            this.lTitle.BackColor = System.Drawing.Color.Transparent;
            this.lTitle.Font = new System.Drawing.Font("Malgun Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(5, 25);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(327, 25);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Now Stopped";
            this.lTitle.UseMnemonic = false;
            // 
            // lArtist
            // 
            this.lArtist.AutoSize = true;
            this.lArtist.BackColor = System.Drawing.Color.Transparent;
            this.lArtist.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lArtist.ForeColor = System.Drawing.Color.White;
            this.lArtist.Location = new System.Drawing.Point(9, 10);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(57, 15);
            this.lArtist.TabIndex = 0;
            this.lArtist.Text = "iTunes is";
            this.lArtist.UseMnemonic = false;
            // 
            // pProgressBg
            // 
            this.pProgressBg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pProgressBg.BackColor = System.Drawing.Color.DimGray;
            this.pProgressBg.Location = new System.Drawing.Point(0, 58);
            this.pProgressBg.Margin = new System.Windows.Forms.Padding(0);
            this.pProgressBg.Name = "pProgressBg";
            this.pProgressBg.Size = new System.Drawing.Size(344, 10);
            this.pProgressBg.TabIndex = 3;
            // 
            // nIcon
            // 
            this.nIcon.BalloonTipTitle = "Now Playing     ";
            this.nIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("nIcon.Icon")));
            this.nIcon.Text = "uStatus";
            this.nIcon.Visible = true;
            this.nIcon.BalloonTipClicked += new System.EventHandler(this.nIcon_BalloonTipClicked);
            // 
            // uStatus
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(344, 118);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "uStatus";
            this.Text = "uStatus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.iTunesTwit_FormClosing);
            this.Load += new System.EventHandler(this.iTunesTwit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uStatus_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tiProgressbar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.CheckBox cbAddYoutube;
        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bNextSong;
        private System.Windows.Forms.Button bPrevSong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pProgressBar;
        private System.Windows.Forms.CheckBox cbAlwaysTop;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.Panel pProgressBg;
        private System.Windows.Forms.ComboBox cbStarPoint;
        private System.Windows.Forms.NotifyIcon nIcon;
    }
}

