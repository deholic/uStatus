using System;
using System.Drawing;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Threading;
using iTunesLib;

namespace uStatus
{
    public partial class uStatus : Form
    {
        private const int STUFF_FLOW_SIZE = 335;
        private iTunesApp iTunes;
        private bool RightLeft = true;
        private uSMusic iTunesData;
        

        public uStatus()
        {
            InitializeComponent();
        }

        private void FirstLoad()
        {
            #region before v1.2
            /*
            iTunes = new iTunesApp();
            if (CheckPlayingState())
            {
                bPlay.Text = "■";
            }

            this.TopMost = Properties.Settings.Default.LastWindowTopMost;
            this.cbAlwaysTop.Checked = Properties.Settings.Default.LastWindowTopMost;

            if (!(Properties.Settings.Default.LastWindowPointX == 0 && Properties.Settings.Default.LastWindowPointY == 0))
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(Properties.Settings.Default.LastWindowPointX, Properties.Settings.Default.LastWindowPointY);                
            }
            */
            #endregion

            iTunesData = new uSMusic();
            iTunesData.StateChanged += RefreshInfo;
            iTunesData.CrawlStart();
        }
        
        private void RefreshInfo(object sender, EventArgs e)
        {
            try
            {
                if (iTunesData.CheckPlayingState())
                {
                    #region old codes
                    /*
                    // 기본 정보 표시를 위한 설정
                    lArtist.Text = iTunes.CurrentTrack.Artist;
                    lTitle.Text = iTunes.CurrentTrack.Name;
                    cbStarPoint.SelectedIndex = iTunes.CurrentTrack.Rating;
                    */
                    #endregion
                    
                    this.Invoke(new MethodInvoker(() => {
                        lArtist.Text = iTunesData.TrackArtist;
                        lTitle.Text = iTunesData.TrackTitle;
                        nIcon.BalloonTipText = iTunesData.TrackArtist + " - " + iTunesData.TrackTitle;
                        cbStarPoint.SelectedIndex = iTunesData.TrackRating / 20;
                    }));

                    nIcon.ShowBalloonTip(500);
                    bPlay.Text = "■";
                    bCopy.Enabled = true;
                }
                else
                {
                    lArtist.Text = "iTunes is";
                    lTitle.Text = "Now Stopped";
                    bPlay.Text = "▶";
                    bCopy.Enabled = false;
                    pProgressBar.Width = 0;
                }
            }
            catch (Exception)
            {
            }
        }
        /*
        private string CreateNowPlayingString()
        {
            if (iTunesData. == ITPlayerState.ITPlayerStatePlaying)
            {
                string nowplaying = "";

                nowplaying =
                    "#nowplaying "
                    + iTunes.CurrentTrack.Artist + " - "
                    + iTunes.CurrentTrack.Name;

                if (cbAddYoutube.Checked)
                {
                    try
                    {

                        byte[] buf = new byte[4096];
                        StringBuilder sb = new StringBuilder();

                        HttpWebRequest request =
                            (HttpWebRequest)WebRequest.Create("http://tln.kr/?mode=shorten&link=http://youtube.com/results?search_query=" + iTunes.CurrentTrack.Artist + " " + iTunes.CurrentTrack.Name);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        Stream resStream = response.GetResponseStream();

                        int count = 0;
                        string shorten = null;

                        do
                        {
                            count = resStream.Read(buf, 0, buf.Length);
                            if (count != 0)
                            {
                                shorten = Encoding.UTF8.GetString(buf, 0, count);
                                sb.Append(shorten);
                            }
                        } while (count > 0);

                        nowplaying += " @ YouTube " + shorten;
                    }
                    catch (WebException)
                    {
                        MessageBox.Show(
                            "YouTube 주소 추가중에 문제가 발생하였습니다.\n주소를 제외한 내용만 작성됩니다.", 
                            "알림", MessageBoxButtons.OK, MessageBoxIcon.Information
                        );
                    }
                }

                nowplaying += " w/ @uStatusApp";

                return nowplaying;
            }
            return null;
        }
        */
        private void bPlay_Click(object sender, EventArgs e)
        {
            if (!iTunesData.CheckPlayingState())
            {
                iTunesData.CrawlStart();
                bPlay.Text = "■";
            }
            else
            {
                iTunesData.CrawlStop();
                bPlay.Text = "▶";
            }
        }
        private void bNextSong_Click(object sender, EventArgs e)
        {
            iTunesData.NextTrack();
        }
        private void bPrevSong_Click(object sender, EventArgs e)
        {
            iTunesData.PrevTrack();
        }
        private void cbAlwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.TopMost)
                this.TopMost = true;
            else
                this.TopMost = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pProgressBar.Width = (int)(((double)pProgressBg.Width / (double)iTunesData.TrackLength) * iTunesData.TrackCurrent);
        }
        /*
        private void tiRatioView_Tick(object sender, EventArgs e)
        {
            if (lTitle.Width > STUFF_FLOW_SIZE)
            {
                if (lTitle.Location.X == STUFF_FLOW_SIZE - lTitle.Width) RightLeft = false;
                else if (lTitle.Location.X > 5) RightLeft = true;

                if (RightLeft)
                    lTitle.Location = new Point(lTitle.Location.X - 1, lTitle.Location.Y);
                else
                    lTitle.Location = new Point(lTitle.Location.X + 1, lTitle.Location.Y);

                //if(lTitle.Location.X >=
            }
            else return;
        }
        */
        private void iTunesTwit_Load(object sender, EventArgs e)
        {
            FirstLoad();
            tiProgressbar.Start();
            
        }
        private void iTunesTwit_FormClosing(object sender, FormClosingEventArgs e)
        {
            iTunesData.CrawlStop();
            Point currentPoint = this.Location;
            Properties.Settings.Default.LastWindowPointX = currentPoint.X;
            Properties.Settings.Default.LastWindowPointY = currentPoint.Y;
            Properties.Settings.Default.LastWindowTopMost = this.TopMost;
            Properties.Settings.Default.Save();
        }
        private void cbAlwaysTop_Click(object sender, EventArgs e)
        {
            if (!this.TopMost)
                this.TopMost = true;
            else
                this.TopMost = false;
        }
        private void bCopy_Click_1(object sender, EventArgs e)
        {
            TweetDialog td = new TweetDialog(iTunesData.CreateNowPlayingString(cbAddYoutube.Checked));
            td.ShowDialog();
        }
        private void cbStarPoint_SelectionChangeCommitted(object sender, EventArgs e)
        {
            iTunesData.TrackRating = cbStarPoint.SelectedIndex;
        }
        private void uStatus_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                case Keys.P:
                    iTunesData.PrevTrack();
                    break;
                case Keys.D:
                case Keys.N:
                    iTunesData.NextTrack();
                    break;
                case Keys.W:
                    if(cbStarPoint.SelectedIndex < 5) cbStarPoint.SelectedIndex++;
                    break;
                case Keys.S:
                    if (cbStarPoint.SelectedIndex > 0) cbStarPoint.SelectedIndex--;
                    break;
                case Keys.T:
                    bCopy_Click_1(null, null);
                    break;
                case Keys.Y:
                    cbAddYoutube.Checked = !cbAddYoutube.Checked;
                    break;
                case Keys.U:
                    cbAlwaysTop_Click(null, null);
                    cbAlwaysTop.Checked = this.TopMost;
                    break;
            }
        }

        private void nIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                WindowState = FormWindowState.Normal;
            }
        }
    }
}
