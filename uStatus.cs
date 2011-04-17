using System;
using System.Drawing;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using iTunesLib;

namespace uStatus
{
    public partial class uStatus : Form
    {
        private const int STUFF_FLOW_SIZE = 335;
        private iTunesApp iTunes;
        private bool RightLeft = true;

        public uStatus()
        {
            InitializeComponent();
        }

        private void FirstLoad()
        {
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
        }
        private bool CheckPlayingState()
        {
            if (iTunes.PlayerState == ITPlayerState.ITPlayerStateStopped)
                return false;
            else
                return true;
        }
        private void RefreshInfo()
        {
            try
            {
                if (CheckPlayingState())
                {
                    // 기본 정보 표시를 위한 설정
                    lArtist.Text = iTunes.CurrentTrack.Artist;
                    lTitle.Text = iTunes.CurrentTrack.Name;

                    // Progress Bar 표시
                    pProgressBar.Width = (int)(((double)pProgressBg.Width / (double)iTunes.CurrentTrack.Duration) * iTunes.PlayerPosition);

                    // 곡 제목이 넘쳤을 경우에 흘러가는 효과 주긔
                    if (lTitle.Width > STUFF_FLOW_SIZE)
                    {
                        //tiRatioView.Start();
                    }
                    else
                    {
                        lTitle.Location = new Point(7, 25);
                        tiRatioView.Stop();
                    }

                    bPlay.Text = "■";
                    bCopy.Enabled = true;

                    GC.Collect();
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
        private string CreateNowPlayingString()
        {
            if (iTunes.PlayerState == ITPlayerState.ITPlayerStatePlaying)
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

        private void bPlay_Click(object sender, EventArgs e)
        {
            if (!CheckPlayingState())
            {
                iTunes.Play();
                bPlay.Text = "■";
            }
            else
            {
                iTunes.Pause();
                bPlay.Text = "▶";
            }
        }
        private void bNextSong_Click(object sender, EventArgs e)
        {
            iTunes.NextTrack();
        }
        private void bPrevSong_Click(object sender, EventArgs e)
        {
            iTunes.PreviousTrack();
        }
        private void bCopy_Click(object sender, EventArgs e)
        {
            string clip = null;
            if ((clip = CreateNowPlayingString()) != null)
            {
                Clipboard.SetText(CreateNowPlayingString());
                MessageBox.Show("클립보드에 #nowplaying 정보가 복사 되었습니다!", "성공!");
            }
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
            RefreshInfo();
        }
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
        private void iTunesTwit_Load(object sender, EventArgs e)
        {
            FirstLoad();
            tiCheckStatus.Start();
        }
        private void iTunesTwit_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            TweetDialog td = new TweetDialog(CreateNowPlayingString());
            td.ShowDialog();
        }
    }
}
