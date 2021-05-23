using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace Odtwieracz
{
    public partial class MainForm : Form
    {
        
        private WaveOut outputDevice;
        private AudioFileReader audioFile;
        bool loopTrack = false, loopPlaylist = false, shuffle = false;
        AudioTrack loadedTrack;
        float volume = 0.5f;
        int playedTrackPosition;

        TimeSpan trackCurrentTime = new TimeSpan();
        TimeSpan trackLength = new TimeSpan();
        TimeSpan playlistPlayedTime = new TimeSpan(0, 0, 0);
        TimeSpan playlistTotalLength = new TimeSpan(0, 0, 0);

        public List<AudioTrack> tracklist = new List<AudioTrack>();


        public MainForm()
        {
            InitializeComponent();
            //AddTrack(@"C:\\aaa_test\\mbaatyr.mp3");
            //PlaylistBox.SelectedIndex = 0;
        }


        public void AddTrack(string filePath)
        {
            AudioTrack newTrack = new AudioTrack(filePath);

            tracklist.Add(newTrack);

            string displayName = "";

            if (newTrack.artist != "---") displayName = newTrack.artist + " - ";
            displayName += newTrack.title;

            PlaylistBox.Items.Add(displayName);

            playlistTotalLength += newTrack.duration;
            PlaylistTotalTimeLabel.Text = "/ " + playlistTotalLength.ToString(@"hh\:mm\:ss");
            
        }

        public void SetTrackData(int trackNo)
        {
            var track = tracklist.ElementAt(trackNo);

            playedTrackPosition = trackNo;
            ImagePicturebox.Image = track.trackImage;
            loadedTrack = track;
            ArtistLabel.Text = track.artist;
            TitleLabel.Text = track.title;
            GenreLabel.Text = track.genre.ToLower();
            YearLabel.Text = track.year;
            BitrateLabel.Text = track.audioBitrate + "kbps";
            TrackTimeAtLabel.Text = "00:00";
            TrackLengthLabel.Text = track.duration.ToString(@"mm\:ss");
            trackLength = track.duration;

            TrackTimeBar.Maximum = (int)track.duration.TotalSeconds;
            TrackTimeBar.Value = 0;
        }



        private void OnButtonPlayClick(object sender, EventArgs e)
        {
            if (loadedTrack == null)
            {
                SetTrackData(PlaylistBox.SelectedIndex);

                SetPlaylistTimer();
            }


            if (PlaylistBox.SelectedItem != null)
            {
                if (outputDevice == null)
                {
                    outputDevice = new WaveOut();
                }
                if (audioFile == null)
                {
                    audioFile = new AudioFileReader(loadedTrack.pathToFile);
                    audioFile.Volume = volume;
                    audioLength = audioFile.Length;
                    outputDevice.Init(audioFile);
                }

                outputDevice.Play();
                if (!TrackTimer.Enabled)
                    TrackTimer.Start();

            }
        }

        private void OnButtonStopClick(object sender, EventArgs e)
        {
            StopPlayback();
        }

        private void StopPlayback()
        {
            outputDevice?.Stop();
            outputDevice?.Dispose();
            outputDevice = null;
            
            audioFile?.Dispose();
            audioFile = null;

            TrackTimer.Stop();
            TrackTimeBar.Value = 0;
            trackCurrentTime = new TimeSpan(0, 0, 0);
            TrackTimeAtLabel.Text = "00:00";
        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Pause();
                TrackTimer.Stop();
            }
        }

        
        private void TrackTimer_Tick(object sender, EventArgs e)
        {
            trackCurrentTime = trackCurrentTime.Add(new TimeSpan(0,0,1));
            TrackTimeAtLabel.Text = trackCurrentTime.ToString(@"mm\:ss");

            playlistPlayedTime = playlistPlayedTime.Add(new TimeSpan(0, 0, 1));
            PlaylistTimeLabel.Text = playlistPlayedTime.ToString(@"hh\:mm\:ss");

            if (!rewind)
                TrackTimeBar.Value = (int)((double)audioFile.Position / audioFile.Length * TrackTimeBar.Maximum);

            if (trackCurrentTime.Ticks > trackLength.Ticks)
            {
                StopPlayback();

                if (loopTrack)
                {
                    StartPlayback();
                    TrackTimer.Start();
                }
                else
                if (shuffle)
                {
                    PlaylistBox.SelectedIndex = new Random().Next(0, tracklist.Count - 1);
                    SetTrackData(PlaylistBox.SelectedIndex);
                    SetPlaylistTimer();
                    StartPlayback();
                    TrackTimer.Start();

                }
                else
                if (PlaylistBox.SelectedIndex != tracklist.Count - 1)
                {
                    playNextTrack();
                }
                else
                if (loopPlaylist) playNextTrack();


            }
            
            
        }

        private void playNextTrack(bool prev = false)
        {
            if (prev)
            {
                if (PlaylistBox.SelectedIndex != 0)
                    PlaylistBox.SelectedIndex--;
                else
                    PlaylistBox.SelectedIndex = tracklist.Count - 1;
            }
            else
            {
                if (PlaylistBox.SelectedIndex != tracklist.Count - 1)
                    PlaylistBox.SelectedIndex++;
                else
                    PlaylistBox.SelectedIndex = 0;
            }

            StopPlayback();
            SetTrackData(PlaylistBox.SelectedIndex);
            SetPlaylistTimer();
            StartPlayback();

            TrackTimer.Start();
        }

        private void StartPlayback()
        {
            outputDevice = new WaveOut();
            audioFile = new AudioFileReader(loadedTrack.pathToFile);
            audioLength = audioFile.Length;
            audioFile.Volume = volume;
            outputDevice.Init(audioFile);
            outputDevice.Play();
        }
        

        private void PlaylistBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(PlaylistBox.SelectedItem != null)
            {
                StopPlayback();                
                
                SetTrackData(PlaylistBox.SelectedIndex);

                SetPlaylistTimer();

                StartPlayback();
                
                TrackTimer.Start();

            }
        }

        private void ButtonMoveUp_Click(object sender, EventArgs e)
        {
            if (tracklist.Count > 1)
            {
                try
                {
                    int index = PlaylistBox.SelectedIndex;

                    string temp = PlaylistBox.SelectedItem.ToString();

                    PlaylistBox.Items[index] = PlaylistBox.Items[index - 1];
                    PlaylistBox.Items[index - 1] = temp;
                    PlaylistBox.SelectedIndex = index - 1;

                    var temp2 = tracklist[index];
                    tracklist[index] = tracklist[index - 1];
                    tracklist[index - 1] = temp2;
                }
                catch (Exception) { }
            }
        }

        private void ButtonMoveDown_Click(object sender, EventArgs e)
        {
            if (tracklist.Count > 1)
            {
                try
                {
                    int index = PlaylistBox.SelectedIndex;
                    string temp = PlaylistBox.SelectedItem.ToString();

                    PlaylistBox.Items[index] = PlaylistBox.Items[index + 1];
                    PlaylistBox.Items[index + 1] = temp;
                    PlaylistBox.SelectedIndex = index + 1;

                    var temp2 = tracklist[index];
                    tracklist[index] = tracklist[index + 1];
                    tracklist[index + 1] = temp2;
                }
                catch (Exception) { }
            }
        }

        private void SetPlaylistTimer()
        {
            playlistPlayedTime = new TimeSpan();
            int i = 0;
            while (i != PlaylistBox.SelectedIndex)
            {
                playlistPlayedTime += tracklist[i].duration;
                i++;
            }
            PlaylistTimeLabel.Text = playlistPlayedTime.ToString(@"hh\:mm\:ss");
        }

        private void PlaylistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }


        private void ButtonShuffle_Click(object sender, EventArgs e)
        {
            if (!shuffle)
            {
                ButtonShuffle.BackgroundImage = Properties.Resources.shuffle_on1;                
                shuffle = true;
            }
            else 
            {
                ButtonShuffle.BackgroundImage = Properties.Resources.shuffle_off;
                shuffle = false;
            }
             
        }

        private void ButtonLoop_Click(object sender, EventArgs e)
        {
            if (!loopTrack)
            {
                ButtonLoop.BackgroundImage = Properties.Resources.loop_on1;
                loopTrack = true;
            }
            else
            {
                ButtonLoop.BackgroundImage = Properties.Resources.loop;
                loopTrack = false;
            }
        }

        private void ButtonInfinity_Click(object sender, EventArgs e)
        {
            if (!loopPlaylist)
            {
                ButtonInfinity.BackgroundImage = Properties.Resources.infinity_on1;
                loopPlaylist = true;
            }
            else
            {
                ButtonInfinity.BackgroundImage = Properties.Resources.infinity;
                loopPlaylist = false;
            }
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (tracklist.Any())
            {
                playlistTotalLength = new TimeSpan(playlistTotalLength.Ticks - tracklist[PlaylistBox.SelectedIndex].duration.Ticks);
                if (PlaylistBox.SelectedIndex < playedTrackPosition)
                {
                    playlistPlayedTime = new TimeSpan(playlistPlayedTime.Ticks - tracklist[PlaylistBox.SelectedIndex].duration.Ticks);
                    playedTrackPosition--;
                }
                    
                tracklist.RemoveAt(PlaylistBox.SelectedIndex);
                PlaylistBox.Items.RemoveAt(PlaylistBox.SelectedIndex);
                PlaylistTotalTimeLabel.Text = "/ " + playlistTotalLength.ToString(@"hh\:mm\:ss");
            }
            
        }

        bool rewind = false;
        double rewindTo;
        long audioLength;

        private void TrackTimeBar_Scroll(object sender, EventArgs e)
        {
            rewindTo = TrackTimeBar.Value / (double)TrackTimeBar.Maximum;
        }

        private void TrackTimeBar_MouseDown(object sender, MouseEventArgs e)
        {
            rewind = true;
        }

        private void TrackTimeBar_MouseUp(object sender, MouseEventArgs e)
        {
            audioFile.Position = (long)(rewindTo * audioLength);
            trackCurrentTime = new TimeSpan((long) (rewindTo * trackLength.Ticks));
            SetPlaylistTimer();
            playlistPlayedTime = new TimeSpan(playlistPlayedTime.Ticks + trackCurrentTime.Ticks);
            TrackTimeAtLabel.Text = trackCurrentTime.ToString(@"mm\:ss");
            PlaylistTimeLabel.Text = playlistPlayedTime.ToString(@"hh\:mm\:ss");

            rewind = false;
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (tracklist.Count > 0) playNextTrack(true);

        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (tracklist.Count > 0) playNextTrack();
        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            volume = VolumeTrackBar.Value / 100f;
            if (audioFile != null)
            audioFile.Volume = volume;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            new FilePicker(this);

        }

    }
}
