using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Filmowiec
{
    public partial class Form1 : Form
    {
        List<Video> playlist = new List<Video>();
        Video loadedVideo;
        int playedVideoPosition;

        TimeSpan TSvideoAt = new TimeSpan();
        TimeSpan TSplaylistAt = new TimeSpan();
        TimeSpan TSplaylistLength = new TimeSpan();

        OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
            RestoreDirectory = true
        };
        
        SaveFileDialog SaveFileDialog = new SaveFileDialog()
        {
            Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
            RestoreDirectory = true
        };

        public Form1()
        {
            InitializeComponent();
            MediaPlayer.uiMode = "none";
        }

        public void AddVideo(string filepath)
        {
            Video newVideo = new Video(filepath);
            playlist.Add(newVideo);
            string displayName = newVideo.title;
            ListBoxPlaylist.Items.Add(displayName);

            TSplaylistLength += newVideo.duration;
            LabelPlaylistLength.Text = TSplaylistLength.ToString(@"hh\:mm\:ss");
        }


        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (!videoPaused)
            {
                if (ListBoxPlaylist.SelectedIndex < 0)
                    ListBoxPlaylist.SelectedIndex = 0;

                MediaPlayer.URL = playlist[ListBoxPlaylist.SelectedIndex].pathToFile;
                LoadVideoData(ListBoxPlaylist.SelectedIndex);

                SetPlaylistTimer();
            }
            
            MediaPlayer.Ctlcontrols.play();
            
            Timer.Start();
        }

        bool videoPaused = false;

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.pause();
            Timer.Stop();
            videoPaused = true;
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            StopPlayback();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 0) playNextVideo();
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 0) playNextVideo(true);
        }


        private void ListBoxPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StopPlayback();
            MediaPlayer.URL = playlist[ListBoxPlaylist.SelectedIndex].pathToFile;
            LoadVideoData(ListBoxPlaylist.SelectedIndex);
            SetPlaylistTimer();
            Timer.Start();
        }

        bool rewind = false;
        double rewindTo;

        private void TrackBar_Scroll(object sender, EventArgs e)
        {
            rewindTo = TrackBar.Value / (double)TrackBar.Maximum;
        }

        private void TrackBar_MouseDown(object sender, MouseEventArgs e)
        {
            rewind = true;
        }

        private void TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            MediaPlayer.Ctlcontrols.currentPosition = rewindTo * loadedVideo.duration.TotalSeconds;
            TSvideoAt = new TimeSpan((long)(rewindTo * loadedVideo.duration.Ticks));
            SetPlaylistTimer();
            TSplaylistAt = new TimeSpan(TSplaylistAt.Ticks + TSvideoAt.Ticks);
            LabelVideoAt.Text = TSvideoAt.ToString(@"mm\:ss");
            LabelPlaylistAt.Text = TSplaylistAt.ToString(@"hh\:mm\:ss");

            rewind = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TSvideoAt = TSvideoAt.Add(new TimeSpan(0, 0, 1));
            LabelVideoAt.Text = TSvideoAt.ToString(@"mm\:ss");
            TSplaylistAt = TSplaylistAt.Add(new TimeSpan(0, 0, 1));
            LabelPlaylistAt.Text = TSplaylistAt.ToString(@"hh\:mm\:ss");

            if (!rewind)
                TrackBar.Value = (int)(MediaPlayer.Ctlcontrols.currentPosition / loadedVideo.duration.TotalSeconds * TrackBar.Maximum);

            if (TSvideoAt.Ticks > loadedVideo.duration.Ticks)
            {
                StopPlayback();

                if (checkBoxLoop.Checked)
                {
                    MediaPlayer.Ctlcontrols.play();
                    Timer.Start();
                }
                else
                if (checkBoxRandomize.Checked)
                {
                    ListBoxPlaylist.SelectedIndex = new Random().Next(0, playlist.Count);

                    LoadVideoData(ListBoxPlaylist.SelectedIndex);
                    SetPlaylistTimer();
                    MediaPlayer.Ctlcontrols.play();
                    Timer.Start();
                }
                else
                if (ListBoxPlaylist.SelectedIndex != playlist.Count - 1)
                {
                    playNextVideo();
                }
                else
                if (checkBoxLoopPlaylist.Checked) playNextVideo();
            }
        }

        private void StopPlayback()
        {
            MediaPlayer.Ctlcontrols.stop();
            Timer.Stop();
            TrackBar.Value = 0;
            TSvideoAt = new TimeSpan(0, 0, 0);
        }

        private void ButtonSavePlaylist_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> filepaths = new List<string>();
                foreach (var vid in playlist)
                {
                    filepaths.Add(vid.pathToFile);
                }
                System.IO.File.WriteAllLines(SaveFileDialog.FileName, filepaths);
            }
        }

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 1)
            {
                try
                {
                    int index = ListBoxPlaylist.SelectedIndex;
                    string temp = ListBoxPlaylist.SelectedItem.ToString();

                    ListBoxPlaylist.Items[index] = ListBoxPlaylist.Items[index - 1];
                    ListBoxPlaylist.Items[index - 1] = temp;
                    ListBoxPlaylist.SelectedIndex = index - 1;

                    var temp2 = playlist[index];
                    playlist[index] = playlist[index - 1];
                    playlist[index - 1] = temp2;
                    SetPlaylistTimer();
                }
                catch (Exception) {}
            }
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 1)
            {
                try
                {
                    int index = ListBoxPlaylist.SelectedIndex;
                    string temp = ListBoxPlaylist.SelectedItem.ToString();

                    ListBoxPlaylist.Items[index] = ListBoxPlaylist.Items[index + 1];
                    ListBoxPlaylist.Items[index + 1] = temp;
                    ListBoxPlaylist.SelectedIndex = index + 1;

                    var temp2 = playlist[index];
                    playlist[index] = playlist[index + 1];
                    playlist[index + 1] = temp2;
                    SetPlaylistTimer();
                }
                catch (Exception) { }
            }
        }

        private void ButtonRemoveVideo_Click(object sender, EventArgs e)
        {
            if (playlist.Any() && ListBoxPlaylist.SelectedIndex >= 0)
            {
                TSplaylistLength = new TimeSpan(TSplaylistLength.Ticks - playlist[ListBoxPlaylist.SelectedIndex].duration.Ticks);
                if (ListBoxPlaylist.SelectedIndex < playedVideoPosition)
                {
                    TSplaylistAt = new TimeSpan(TSplaylistAt.Ticks - playlist[ListBoxPlaylist.SelectedIndex].duration.Ticks);
                    playedVideoPosition--;
                }

                playlist.RemoveAt(ListBoxPlaylist.SelectedIndex);
                ListBoxPlaylist.Items.RemoveAt(ListBoxPlaylist.SelectedIndex);
                LabelPlaylistLength.Text = TSplaylistLength.ToString(@"hh\:mm\:ss");
            }
        }

        

        public void LoadVideoData(int videoNo)
        {
            var vid = playlist.ElementAt(videoNo);
            playedVideoPosition = videoNo;
            LabelVideoAt.Text = "00:00";
            LabelVideoLength.Text = vid.duration.ToString(@"mm\:ss");
            loadedVideo = vid;
            MediaPlayer.URL = vid.pathToFile;

            TrackBar.Maximum = (int)vid.duration.TotalSeconds;
            TrackBar.Value = 0;
        }

        

        private void ButtonLoadPlaylist_Click(object sender, EventArgs e)
        {
            playlist.Clear();
            ListBoxPlaylist.Items.Clear();

            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var lines = System.IO.File.ReadLines(openFileDialog.FileName);
                foreach (var line in lines)
                {
                    AddVideo(line);
                }
            }

        }


        private void ButtonAddVideo_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All files(*.*) |*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AddVideo(openFileDialog.FileName);
            }
        }


        private void playNextVideo(bool prev = false)
        {
            if (prev)
            {
                if (ListBoxPlaylist.SelectedIndex != 0)
                    ListBoxPlaylist.SelectedIndex--;
                else
                    ListBoxPlaylist.SelectedIndex = playlist.Count - 1;
            }
            else
            {
                if (ListBoxPlaylist.SelectedIndex != playlist.Count - 1)
                    ListBoxPlaylist.SelectedIndex++;
                else
                    ListBoxPlaylist.SelectedIndex = 0;
            }

            StopPlayback();
            LoadVideoData(ListBoxPlaylist.SelectedIndex);
            SetPlaylistTimer();
            MediaPlayer.Ctlcontrols.play();
            Timer.Start();
        }

        private void SetPlaylistTimer()
        {
            TSplaylistAt = new TimeSpan();
            int i = 0;
            while (i != ListBoxPlaylist.SelectedIndex)
            {
                TSplaylistAt += playlist[i].duration;
                i++;
            }
            LabelPlaylistAt.Text = TSplaylistAt.ToString(@"hh\:mm\:ss");
        }

        int seconds;

        private void MediaPlayer_MouseMoveEvent(object sender, AxWMPLib._WMPOCXEvents_MouseMoveEvent e)
        {
            seconds = 0;
            PanelTime.Visible = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 5)
            {
                PanelTime.Visible = false;
                timer1.Stop();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loadedVideo != null)
                new TagsForm(loadedVideo).Show();
        }
    }
}
