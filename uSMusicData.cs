using System;
using System.IO;
using System.Text;
using System.Net;
using System.Threading;
using iTunesLib;

namespace uStatus
{
    class uSMusic
    {
        private iTunesApp iTunes;
        private Thread iTunesDataCrawler;

        protected int pID;
        private String pTitle;
        private String pArtist;
        private int pRating;
        private int pLength;
        private int pCurrent;
        
        public String TrackTitle
        {
            get { return pTitle; }
            set { pTitle = value; }
        }
        public String TrackArtist
        {
            get { return pArtist; }
            set { pArtist = value; }
        }
        public int TrackRating
        {
            get { return pRating; }
            set { 
                pRating = value * 20;
                iTunes.CurrentTrack.Rating = pRating;
            }
        }
        public int TrackLength
        {
            get { return pLength; }
            set { pLength = value; }
        }
        public int TrackCurrent
        {
            get { return pCurrent; }
            set { pCurrent = value; }
        }
        public String NowPlaying
        {
            get { return CreateNowPlayingString(false); }
        }
        public String NowPlayingWithYoutube
        {
            get { return CreateNowPlayingString(true); }
        }

        public event EventHandler StateChanged;

        public void CrawlStart()
        {
            if (iTunes == null) iTunes = new iTunesApp();
            iTunes.Play();

            iTunesDataCrawler = new Thread(this.Crawl);
            iTunesDataCrawler.Start();
        }
        public void CrawlStop()
        {
            if (iTunesDataCrawler != null)
            {
                iTunesDataCrawler.Abort();
                iTunes.Pause();
            }
        }
        private void Crawl()
        {
            try
            {
                while (true)
                {
                    if (iTunes != null)
                    {
                        if (pID == 0 || (pID != 0 && pID != iTunes.CurrentTrack.trackID))
                        {
                            pID = iTunes.CurrentTrack.trackID;
                            pArtist = iTunes.CurrentTrack.Artist;
                            pTitle = iTunes.CurrentTrack.Name;
                            pRating = iTunes.CurrentTrack.Rating;
                            pLength = iTunes.CurrentTrack.Duration;
                            if (StateChanged != null) StateChanged(this, new EventArgs());
                        }
                        pCurrent = iTunes.PlayerPosition;
                    }
                    else break;
                    GC.Collect();
                    Thread.Sleep(150);
                }
            }
            catch (Exception)
            {
            }
        }

        public void NextTrack()
        {
            if (iTunes != null) iTunes.NextTrack();
        }
        public void PrevTrack()
        {
            if (iTunes != null) iTunes.PreviousTrack();
        }

        public bool CheckPlayingState()
        {
            if (iTunes != null)
            {
                if (iTunes.PlayerState == ITPlayerState.ITPlayerStateStopped)
                    return false;
                else
                    return true;
            }
            else return false;
        }
        public String CreateNowPlayingString(bool youtube)
        {
            if (iTunes.PlayerState == ITPlayerState.ITPlayerStatePlaying)
            {
                string nowplaying = "#nowplaying ";

                nowplaying += pArtist + " - " + pTitle + " ";

                if (pRating > 0)
                {
                    nowplaying += "★" + pRating / 20 + " ";
                }

                if (youtube)
                {
                    try
                    {
                        nowplaying += "@ YouTube " + getShortenLinkForYouTube() + " ";
                    }
                    catch (WebException)
                    {
                    }
                }

                nowplaying += "♪ @uStatusApp";

                return nowplaying;
            }
            return null;
        }
        private String getShortenLinkForYouTube()
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

                return shorten;
            }
            catch (WebException)
            {
                throw;
            }
        }
    }
}
