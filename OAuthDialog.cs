using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using Twitterizer;

namespace uStatus
{
    public partial class OAuthDialog : Form
    {
        private string cKey;
        private string cSecret;
        private string uToken;
        private string uSecret;
        private string aToken;
        private string aSecret;

        public string ConsumerKey
        {
            get { return cKey; }
        }
        public string ConsumerSecret
        {
            get { return cSecret; }
        }
        public string UserToken
        {
            get {
                if (uToken != "") return uToken;
                else return null;
            }
        }
        public string UserSecret
        {
            get {
                if (uSecret != "") return uSecret;
                else return null;
            }
        }

        public OAuthDialog()
        {
            InitializeComponent();
            this.cKey = Properties.Settings.Default.CKey;
            this.cSecret = Properties.Settings.Default.CSecret;
            this.uToken = Properties.Settings.Default.UToken;
            this.uSecret = Properties.Settings.Default.USecret;
        }

        public OAuthTokens CreateAccessToken()
        {
            OAuthTokens token = new OAuthTokens();

            token.ConsumerKey = this.ConsumerKey;
            token.ConsumerSecret = this.ConsumerSecret;
            token.AccessToken = this.UserToken;
            token.AccessTokenSecret = this.UserSecret;

            return token;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OAuthTokenResponse response = 
                OAuthUtility.GetRequestToken(cKey, cSecret, "oob");
            this.aToken = response.Token;
            this.aSecret = response.TokenSecret;

            System.Diagnostics.Process.Start("https://twitter.com/oauth/authorize?oauth_token=" + aToken);
        }
        private void bNext_Click(object sender, EventArgs e)
        {
            try
            {
                OAuthTokenResponse response = OAuthUtility.GetAccessToken(cKey, cSecret, aToken, tbPinNumber.Text);
                this.uToken = response.Token;
                this.uSecret = response.TokenSecret;

                Properties.Settings.Default.UToken = response.Token;
                Properties.Settings.Default.USecret = response.TokenSecret;
                Properties.Settings.Default.Save();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (TwitterizerException tx)
            {
            }
        }
        private void tbPinNumber_TextChanged(object sender, EventArgs e)
        {
            if (tbPinNumber.Text.Length == 7) bNext.Enabled = true;
            else bNext.Enabled = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void OAuthDialog_Load(object sender, EventArgs e)
        {
        }
    }
}
