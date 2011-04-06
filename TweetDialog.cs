using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Twitterizer;

namespace uStatus
{
    public partial class TweetDialog : Form
    {
        private string info;
        private string tweet;
        private OAuthDialog od;
        private int tweetlength;

        public int TweetLength
        {
            get { return tweetlength; }
            set { 
                tweetlength = value;
                lCount.Text = tweetlength.ToString();
            }
        }
        public TweetDialog(string songInfo)
        {
            InitializeComponent();
            this.info = songInfo;
            this.od = new OAuthDialog();
            this.tweet = songInfo;
        }

        private void TweetDialog_Load(object sender, EventArgs e)
        {
            this.lSongInfo.Text = info;
            this.lCount.Text = info.Length.ToString();
        }
        private void bTweet_Click(object sender, EventArgs e)
        {
            if (od.UserToken == null || od.UserSecret == null) od.ShowDialog();
            TwitterStatus.Update(od.CreateAccessToken(), tweet);

            this.Close();
        }
        private void tbCustomMessage_TextChanged(object sender, EventArgs e)
        {
            this.TweetLength = info.Length + tbCustomMessage.Text.Length;
            if (TweetLength > 140)
            {
                lCount.ForeColor = Color.Red;
                bTweet.Enabled = false;
            }
            else
            {
                lCount.ForeColor = Color.Black;
                bTweet.Enabled = true;
            }
            this.tweet = info + " " + tbCustomMessage.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UToken = "";
            Properties.Settings.Default.USecret = "";
            Properties.Settings.Default.Save();

            od = new OAuthDialog();
        }
    }
}
