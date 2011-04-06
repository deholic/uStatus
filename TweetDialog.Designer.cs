namespace uStatus
{
    partial class TweetDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lSongInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lCount = new System.Windows.Forms.Label();
            this.bTweet = new System.Windows.Forms.Button();
            this.tbCustomMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 136);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lSongInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 80);
            this.panel1.TabIndex = 0;
            // 
            // lSongInfo
            // 
            this.lSongInfo.ForeColor = System.Drawing.Color.White;
            this.lSongInfo.Location = new System.Drawing.Point(5, 34);
            this.lSongInfo.Margin = new System.Windows.Forms.Padding(5);
            this.lSongInfo.Name = "lSongInfo";
            this.lSongInfo.Size = new System.Drawing.Size(324, 40);
            this.lSongInfo.TabIndex = 1;
            this.lSongInfo.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "#NowPlaying";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lCount);
            this.panel2.Controls.Add(this.bTweet);
            this.panel2.Controls.Add(this.tbCustomMessage);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 56);
            this.panel2.TabIndex = 1;
            // 
            // lCount
            // 
            this.lCount.ForeColor = System.Drawing.Color.Black;
            this.lCount.Location = new System.Drawing.Point(280, 35);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(49, 18);
            this.lCount.TabIndex = 2;
            this.lCount.Text = "0";
            // 
            // bTweet
            // 
            this.bTweet.Location = new System.Drawing.Point(280, 3);
            this.bTweet.Name = "bTweet";
            this.bTweet.Size = new System.Drawing.Size(50, 29);
            this.bTweet.TabIndex = 2;
            this.bTweet.Text = "Tweet";
            this.bTweet.UseVisualStyleBackColor = true;
            this.bTweet.Click += new System.EventHandler(this.bTweet_Click);
            // 
            // tbCustomMessage
            // 
            this.tbCustomMessage.Location = new System.Drawing.Point(44, 3);
            this.tbCustomMessage.Multiline = true;
            this.tbCustomMessage.Name = "tbCustomMessage";
            this.tbCustomMessage.Size = new System.Drawing.Size(230, 50);
            this.tbCustomMessage.TabIndex = 1;
            this.tbCustomMessage.TextChanged += new System.EventHandler(this.tbCustomMessage_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(6, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "+";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TweetDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 136);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TweetDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TweetDialog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lSongInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Button bTweet;
        private System.Windows.Forms.TextBox tbCustomMessage;
        private System.Windows.Forms.Label label3;
    }
}