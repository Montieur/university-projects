using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudio.Vorbis;

namespace Blenderv2
{
    public partial class AudioMixer : Form
    {
        static string dir = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\AudioMixer\";

        public AudioMixer()
        {
            InitializeComponent();
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
            CleanUp();
            foreach (var s in sampleRates) comboBox1.Items.Add(s);
            comboBox1.SelectedIndex = 3;
            
            InitTracks();
            //MessageBox.Show("This program is really easy to crash if you want it to, but works fine if you play by the rules! \r\n" +
            //    "And it got me an A, so you have no right to complain :^) \r\n(jk I promise I'll do better in the future)");
            // and when I look at it now, the code itself is looking really nasty too, try not to gauge your eyes out please
        }

        

        OpenFileDialog opf = new OpenFileDialog() { RestoreDirectory = true };

        int projectRate = 44100;
        readonly int[] sampleRates = new int[] { 8000, 16000, 22050, 44100, 48000, 88200, 96000 };

        ProjectTrack MainTrack, Track1, Track2, Track3;
        List<ProjectTrack> tracksList = new List<ProjectTrack>();
        VorbisWaveReader vorbisWaveReader;
        WaveOut outputDevice;


        private void InitTracks()
        {

            MainTrack = new ProjectTrack()
            {
                trackID = 0,
                filename = "main",
                filepath = dir + "main.wav",
                tempFilepath = dir + "main_temp.wav"
            };
            Track1 = new ProjectTrack()
            {
                trackID = 1,
                filename = "track1",
                filepath = dir + "track1.wav",
                tempFilepath = dir + "track1_temp.wav"
            };
            Track2 = new ProjectTrack()
            {
                trackID = 2,
                filename = "track2",
                filepath = dir + "track2.wav",
                tempFilepath = dir + "track2_temp.wav"
            };
            Track3 = new ProjectTrack()
            {
                trackID = 3,
                filename = "track3",
                filepath = dir + "track3.wav",
                tempFilepath = dir + "track3_temp.wav"
            };
            tracksList.Add(MainTrack);
            tracksList.Add(Track1);
            tracksList.Add(Track2);
            tracksList.Add(Track3);
        }

        private ProjectTrack SelectedTrack()
        {
            foreach (var t in tracksList)
                if (t.markedForEdit)
                    return t;

            return null;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            if (File.Exists(MainTrack.filepath))
            {
                if (MainTrack.audio == null)
                    MainTrack.audio = new AudioFileReader(MainTrack.filepath);
                if (outputDevice == null)
                {
                    outputDevice = new WaveOut();
                    outputDevice.PlaybackStopped += ButtonStop_Click;
                    outputDevice.Init(MainTrack.audio);
                    ButtonPause.Enabled = true;
                    ButtonPause.BackColor = Color.White;
                    ButtonStop.Enabled = true;
                    ButtonStop.BackColor = Color.White;
                    Trackbar.Enabled = true;
                    Trackbar.Value = 0;

                }
                outputDevice?.Play();
                Timer.Start();
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            outputDevice.Stop();
            MainTrack.audio.Dispose();
            MainTrack.audio = null;
            outputDevice.Dispose();
            outputDevice = null;
            ButtonPause.Enabled = false;
            ButtonPause.BackColor = Color.LightGray;
            ButtonStop.Enabled = false;
            ButtonStop.BackColor = Color.LightGray;
            Timer.Stop();
            Trackbar.Enabled = false;
        }

        private List<AudioFileReader> affectedTracks()
        {
            List<AudioFileReader> tracksToMix = new List<AudioFileReader>();

            foreach (var track in tracksList)
            {
                if (track.trackID == 0) continue;
                if (track.audio != null)
                {
                    AudioFileReader afr = new AudioFileReader(track.audio.FileName);
                    afr.Volume = track.audio.Volume;
                    
                    tracksToMix.Add(afr);
                }
            }
            return tracksToMix;
        }

        private void MixTracks()
        {
            List<AudioFileReader> tracksToMix = affectedTracks();
            if (tracksToMix.Count > 0)
            {
                MixingSampleProvider mixer2 = new MixingSampleProvider(tracksToMix);
                MainTrack.audio?.Dispose();
                WaveFileWriter.CreateWaveFile(MainTrack.filepath, mixer2.ToWaveProvider());
                foreach (var t in tracksToMix) t.Dispose();
                mixer2.RemoveAllMixerInputs();
                MainTrack.audio = new AudioFileReader(MainTrack.filepath);
                LabelMainTrackDuration.Text = MainTrack.audio.TotalTime.ToString(@"mm\:ss");
                mixer2 = null;

                Trackbar.Maximum = (int)MainTrack.audio.TotalTime.TotalSeconds;
                Trackbar.Value = 0;
            }

        }

        private void ButtonDelay_Click(object sender, EventArgs e)
        {
            var TrackToDelay = SelectedTrack();

            if (TrackToDelay != null)
            {
                DelayTrack(TrackToDelay, ShowDialogBox("delay"), TrackToDelay.tempFilepath);
                UpdateWaveform(TrackToDelay);
                UpdateDuration(TrackToDelay);
                MixTracks();
            }
            else MessageBox.Show("No track selected!");

        }

        private void ButtonTrimStart_Click(object sender, EventArgs e)
        {
            var TrackToTrim = SelectedTrack();

            if (TrackToTrim != null)
            {
                TrimTrack(TrackToTrim, ShowDialogBox("trimStart"));
                UpdateWaveform(TrackToTrim);
                UpdateDuration(TrackToTrim);
                MixTracks();
            }
            else MessageBox.Show("No track selected!");
        }

        private void ButtonTrimEnd_Click(object sender, EventArgs e)
        {
            var TrackToTrim = SelectedTrack();

            if (TrackToTrim != null)
            {
                TrimTrack(TrackToTrim, ShowDialogBox("trimEnd"), true);
                UpdateWaveform(TrackToTrim);
                UpdateDuration(TrackToTrim);
                MixTracks();
            }
            else MessageBox.Show("No track selected!");
        }

        private void UpdateDuration(ProjectTrack track)
        {
            switch (track.trackID)
            {
                case 1:
                    LabelTrack1Duration.Text = track.audio.TotalTime.ToString(@"mm\:ss");
                    break;
                case 2:
                    LabelTrack2Duration.Text = track.audio.TotalTime.ToString(@"mm\:ss");
                    break;
                case 3:
                    LabelTrack3Duration.Text = track.audio.TotalTime.ToString(@"mm\:ss");
                    break;
                default:
                    break;
            }
        }

        private void ButtonFadeIn_Click(object sender, EventArgs e)
        {
            var TrackToFade = SelectedTrack();

            if (TrackToFade != null)
            {
                FadeTrack(TrackToFade, ShowDialogBox("fadeIn"));
                UpdateWaveform(TrackToFade);
                UpdateDuration(TrackToFade);
                MixTracks();
            }

            else MessageBox.Show("No track selected!");
        }

        private void ButtonTrack1Edit_Click(object sender, EventArgs e)
        {
            Track1.markedForEdit = !Track1.markedForEdit;
            if (Track1.markedForEdit)
            {
                if (Track2.markedForEdit) ButtonTrack2Edit_Click(sender, e);
                if (Track3.markedForEdit) ButtonTrack3Edit_Click(sender, e);
                ButtonTrack1Edit.BackColor = Color.Green;
                ButtonTrack1Edit.ForeColor = Color.White;
            }
            else
            {
                ButtonTrack1Edit.BackColor = Color.Maroon;
                ButtonTrack1Edit.ForeColor = Color.Silver;
            }
        }

        private void ButtonTrack2Edit_Click(object sender, EventArgs e)
        {
            Track2.markedForEdit = !Track2.markedForEdit;
            if (Track2.markedForEdit)
            {
                if (Track1.markedForEdit) ButtonTrack1Edit_Click(sender, e);
                if (Track3.markedForEdit) ButtonTrack3Edit_Click(sender, e);
                ButtonTrack2Edit.BackColor = Color.Green;
                ButtonTrack2Edit.ForeColor = Color.White;
            }
            else
            {
                ButtonTrack2Edit.BackColor = Color.Maroon;
                ButtonTrack2Edit.ForeColor = Color.Silver;
            }
        }

        private void ButtonTrack3Edit_Click(object sender, EventArgs e)
        {
            Track3.markedForEdit = !Track3.markedForEdit;
            if (Track3.markedForEdit)
            {
                if (Track1.markedForEdit) ButtonTrack1Edit_Click(sender, e);
                if (Track2.markedForEdit) ButtonTrack2Edit_Click(sender, e);
                ButtonTrack3Edit.BackColor = Color.Green;
                ButtonTrack3Edit.ForeColor = Color.White;
            }
            else
            {
                ButtonTrack3Edit.BackColor = Color.Maroon;
                ButtonTrack3Edit.ForeColor = Color.Silver;
            }
        }

        public void CreateBlankWavFile(int seconds)
        {
            var format = new WaveFormat(44100, 2);
            using (var writer = new WaveFileWriter(dir + "blank.wav", format))
            {
                var oneSecondSilence = new byte[format.AverageBytesPerSecond];
                for (int n = 0; n < seconds + 1; n++)
                {
                    writer.Write(oneSecondSilence, 0, oneSecondSilence.Length);
                }
            }

        }

        private void ButtonPause_Click(object sender, EventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Pause();
                Timer.Stop();
            }
        }

        public int ShowDialogBox(string tool)
        {
            InputBox ip = new InputBox(tool);

            switch (ip.ShowDialog())
            {
                case DialogResult.OK:
                    return int.Parse(ip.TextboxInput.Text);
                case DialogResult.Cancel:
                    return 0;
                default:
                    return 0;
            }

        }

        private void ButtonTrack1Open_Click(object sender, EventArgs e)
        {
            if (opf.ShowDialog() == DialogResult.OK)
            {
                OpenTrack(Track1);
                LabelTrack1Name.Text = opf.FileName;
                UpdateWaveform(Track1);
                UpdateDuration(Track1);
                MixTracks();
                ButtonTrack1Delete.Enabled = true;
                ButtonTrack1Edit.Visible = true;
            }

        }

        private void ButtonTrack2Open_Click(object sender, EventArgs e)
        {
            if (opf.ShowDialog() == DialogResult.OK)
            {
                OpenTrack(Track2);
                LabelTrack2Name.Text = opf.FileName;
                UpdateWaveform(Track2);
                UpdateDuration(Track2);
                MixTracks();
                ButtonTrack2Delete.Enabled = true;
                ButtonTrack2Edit.Visible = true;
            }
        }

        private void ButtonTrack3Open_Click(object sender, EventArgs e)
        {
            if (opf.ShowDialog() == DialogResult.OK)
            {
                OpenTrack(Track3);
                LabelTrack3Name.Text = opf.FileName;
                UpdateWaveform(Track3);
                UpdateDuration(Track3);
                MixTracks();
                ButtonTrack3Delete.Enabled = true;
                ButtonTrack3Edit.Visible = true;
            }
        }

        private void OpenTrack(ProjectTrack track)
        {
            track.audio?.Dispose();

            if (opf.FileName.EndsWith("ogg"))
            {
                track.audio = OggToWav(track);
            }
            else
            {
                try
                {
                    track.audio = new AudioFileReader(opf.FileName);

                    if (track.audio.WaveFormat.SampleRate != projectRate)
                    {
                        string tempFilePath = track.tempFilepath;
                        WaveFileWriter.CreateWaveFile(tempFilePath, track.audio);
                        track.audio.Dispose();
                        track.audio = new AudioFileReader(ResampleWave(projectRate, tempFilePath, track));
                    }
                    else
                    {
                        WaveFileWriter.CreateWaveFile(track.filepath, track.audio);
                        track.audio = new AudioFileReader(track.filepath);
                        WaveFileWriter.CreateWaveFile(track.tempFilepath, track.audio);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                
            }
        }

        private string ResampleWave(int outRate, string filepath, ProjectTrack track)
        {
            WaveFileReader wfr = new WaveFileReader(filepath);
            string outFile = track.filepath;
            var outFormat = new WaveFormat(outRate, wfr.WaveFormat.Channels);
            var mfr = new MediaFoundationResampler(wfr, outFormat);
            WaveFileWriter.CreateWaveFile(outFile, mfr);
            wfr.Dispose();

            return outFile;
        }

        private AudioFileReader OggToWav(ProjectTrack track)
        {
            vorbisWaveReader = new VorbisWaveReader(opf.FileName);

            if (vorbisWaveReader.WaveFormat.SampleRate != projectRate)
            {
                string tempFilePath = track.tempFilepath;
                WaveFileWriter.CreateWaveFile(tempFilePath, vorbisWaveReader);
                return new AudioFileReader(ResampleWave(projectRate, tempFilePath, track));
            }
            else
            {
                WaveFileWriter.CreateWaveFile(track.filepath, vorbisWaveReader);
                return new AudioFileReader(track.filepath);
            }
        }

        private void DelayTrack(ProjectTrack track, int seconds, string tempName)
        {
            CreateBlankWavFile(seconds - 1);
            WaveFileReader waveFileReader = new WaveFileReader(track.filepath);

            using (var wfr = new AudioFileReader(dir + "blank.wav"))
            {
                WaveFileWriter.CreateWaveFile(track.tempFilepath, wfr.FollowedBy(waveFileReader.ToSampleProvider()).ToWaveProvider());
                track.audio.Dispose();
                track.audio = null;
                waveFileReader.Dispose();
                waveFileReader = null;
                if (File.Exists(track.filepath)) File.Delete(track.filepath);
                File.Copy(track.tempFilepath, track.filepath);
                track.audio = new AudioFileReader(track.filepath);
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            projectRate = int.Parse(comboBox1.SelectedItem.ToString());
            foreach (var track in tracksList)
            {
                if (track.trackID == 0) continue;
                if (track.audio != null)
                {
                    track.audio.Dispose();
                    track.audio = new AudioFileReader(ResampleWave(projectRate, track.tempFilepath, track));
                    UpdateWaveform(track);
                }

            }
            MixTracks();
        }

        bool rewind = false;
        double rewindTo;

        private void Trackbar_Scroll(object sender, EventArgs e)
        {
            rewindTo = Trackbar.Value / (double)Trackbar.Maximum;
        }

        private void Trackbar_MouseDown(object sender, MouseEventArgs e)
        {
            rewind = true;
        }

        private void Trackbar_MouseUp(object sender, MouseEventArgs e)
        {
            MainTrack.audio.Position = (long)(rewindTo * MainTrack.audio.Length);
            rewind = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {            
            if (!rewind)
                Trackbar.Value = (int)((double)MainTrack.audio.Position / MainTrack.audio.Length * Trackbar.Maximum);
        }

        private void DuplicateTrack(ProjectTrack track, int seconds)
        {
            if (File.Exists(dir + "loop_temp.wav")) File.Delete(dir + "loop_temp.wav");
            File.Copy(track.filepath, dir + "loop_temp.wav");

            WaveFileReader wfr = new WaveFileReader(dir + "loop_temp.wav"); //single loop

            using (var wave = new WaveFileReader(track.filepath))
            {
                WaveFileWriter.CreateWaveFile(track.tempFilepath, wave.ToSampleProvider().FollowedBy(wfr.ToSampleProvider()).ToWaveProvider());
            }

            track.audio?.Dispose();
            wfr.Dispose();

            if (File.Exists(track.filepath)) File.Delete(track.filepath);
            File.Copy(track.tempFilepath, track.filepath);

            track.audio = new AudioFileReader(track.filepath);
        }

        private void Blendzior_FormClosed(object sender, FormClosedEventArgs e)
        {
            CleanUp(true);
        }

        private void TrimTrack(ProjectTrack track, int seconds, bool end = false)
        {
            using (var wave = new WaveFileReader(track.filepath))
                if (!end)
                {
                    wave.Skip(seconds);
                    WaveFileWriter.CreateWaveFile(track.tempFilepath, wave);
                    track.audio.Dispose();
                    track.audio = null;
                    wave.Dispose();

                    if (File.Exists(track.filepath)) File.Delete(track.filepath);
                    File.Copy(track.tempFilepath, track.filepath);
                    track.audio = new AudioFileReader(track.filepath);
                }
                else
                {
                    WaveFileWriter.CreateWaveFile(track.tempFilepath,
                        wave.ToSampleProvider().Take(track.audio.TotalTime - TimeSpan.FromSeconds(seconds)).ToWaveProvider());
                    track.audio.Dispose();
                    track.audio = null;
                    wave.Dispose();

                    if (File.Exists(track.filepath)) File.Delete(track.filepath);
                    File.Copy(track.tempFilepath, track.filepath);
                    track.audio = new AudioFileReader(track.filepath);
                }
        }

        private void ButtonVolume_Click(object sender, EventArgs e)
        {
            var TrackToRevolume = SelectedTrack();

            if (TrackToRevolume != null)
            {
                using (var slider = new SliderForm(TrackToRevolume, "volume"))
                {
                    slider.ShowDialog();
                    TrackToRevolume.audio.Volume = slider.valueF;

                    UpdateWaveform(TrackToRevolume);
                    MixTracks();
                }
            }
            else MessageBox.Show("No track selected!");
        }

        private void ButtonTrack1Delete_Click(object sender, EventArgs e)
        {
            Track1.audio.Dispose();
            Track1.audio = null;
            LabelTrack1Name.Text = "None";
            MixTracks();
            ButtonTrack1Delete.Enabled = false;
            ButtonTrack1Edit.Visible = false;
            Track1.markedForEdit = false;
            waveViewer1.WaveStream = null;
        }

        private void ButtonTrack2Delete_Click(object sender, EventArgs e)
        {
            Track2.audio.Dispose();
            Track2.audio = null;
            LabelTrack1Name.Text = "None";
            MixTracks();
            ButtonTrack2Delete.Enabled = false;
            ButtonTrack2Edit.Visible = false;
            Track2.markedForEdit = false;
            waveViewer2.WaveStream = null;
        }

        private void ButtonTrack3Delete_Click(object sender, EventArgs e)
        {
            Track3.audio.Dispose();
            Track3.audio = null;
            LabelTrack1Name.Text = "None";
            MixTracks();
            ButtonTrack3Delete.Enabled = false;
            Track1.markedForEdit = false;
            ButtonTrack3Edit.Visible = false;
            waveViewer3.WaveStream = null;
        }

        SaveFileDialog sfd = new SaveFileDialog() {
            Filter = "wav files|.wav"
        };

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainTrack.audio != null)
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                    WaveFileWriter.CreateWaveFile(sfd.FileName, MainTrack.audio);
            }
            else MessageBox.Show("No tracks in the project!");
                
        }

        private void ButtonDuplicate_Click(object sender, EventArgs e)
        {
            var TrackToLoop = SelectedTrack();

            if (TrackToLoop != null)
            {
                DuplicateTrack(TrackToLoop, ShowDialogBox("loop"));
                UpdateWaveform(TrackToLoop);
                MixTracks();
            }
            else MessageBox.Show("No track selected!");
        }

        private void FadeTrack(ProjectTrack track, int seconds, bool end = false)
        {
            using (var wave = new WaveFileReader(track.filepath))
            if (!end)
            {
                var fadedtrack = new FadeInOutSampleProvider(wave.ToSampleProvider(), true);
                fadedtrack.BeginFadeIn(seconds * 1000);
                WaveFileWriter.CreateWaveFile(track.tempFilepath, fadedtrack.ToWaveProvider());
                track.audio.Dispose();
                track.audio = null;
                wave.Dispose();

                if (File.Exists(track.filepath)) File.Delete(track.filepath);
                File.Copy(track.tempFilepath, track.filepath);
                track.audio = new AudioFileReader(track.filepath);
            }
            else
            {
                var fadedtrack = new FadeInOutSampleProvider(wave.ToSampleProvider());
                    
                fadedtrack.BeginFadeOut(seconds * 1000);
                WaveFileWriter.CreateWaveFile(track.tempFilepath, fadedtrack.ToWaveProvider());
                track.audio.Dispose();
                track.audio = null;
                wave.Dispose();
                if (File.Exists(track.filepath)) File.Delete(track.filepath);
                File.Copy(track.tempFilepath, track.filepath);
                track.audio = new AudioFileReader(track.filepath);
            }
        }

        private void CleanUp(bool endProgram = false)
        {
            foreach (var track in tracksList)
                track.audio?.Dispose();
            var FilesToRemove = Directory.GetFiles(dir);
            foreach (var file in FilesToRemove)
                File.Delete(file);
            if (endProgram) Directory.Delete(dir);
        }

        private void UpdateWaveform(ProjectTrack track)
        {
            switch (track.trackID)
            {
                case 1:
                    waveViewer1.SamplesPerPixel = (int)(projectRate * (track.audio.TotalTime.TotalSeconds / waveViewer1.Width));
                    waveViewer1.WaveStream = track.audio;
                    break;
                case 2:
                    waveViewer2.SamplesPerPixel = (int)(projectRate * (track.audio.TotalTime.TotalSeconds / waveViewer2.Width));
                    waveViewer2.WaveStream = track.audio;
                    break;
                case 3:
                    waveViewer3.SamplesPerPixel = (int)(projectRate * (track.audio.TotalTime.TotalSeconds / waveViewer3.Width));
                    waveViewer3.WaveStream = track.audio;
                    break;
                default:
                    break;
            }
        }
    }
}
