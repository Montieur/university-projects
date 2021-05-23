
namespace Blenderv2
{
    partial class AudioMixer
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
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonTrack1Open = new System.Windows.Forms.Button();
            this.ButtonTrack2Open = new System.Windows.Forms.Button();
            this.ButtonTrack3Open = new System.Windows.Forms.Button();
            this.ButtonTrimStart = new System.Windows.Forms.Button();
            this.ButtonTrimEnd = new System.Windows.Forms.Button();
            this.ButtonDuplicate = new System.Windows.Forms.Button();
            this.ButtonDelay = new System.Windows.Forms.Button();
            this.ButtonFadeIn = new System.Windows.Forms.Button();
            this.LabelTrack1Border = new System.Windows.Forms.Label();
            this.LabelTrack2Border = new System.Windows.Forms.Label();
            this.LabelTrack3Border = new System.Windows.Forms.Label();
            this.LabelStrTrack1 = new System.Windows.Forms.Label();
            this.LabelStrTrack2 = new System.Windows.Forms.Label();
            this.LabelStrTrack3 = new System.Windows.Forms.Label();
            this.LabelSeparator = new System.Windows.Forms.Label();
            this.ButtonTrack1Delete = new System.Windows.Forms.Button();
            this.ButtonTrack2Delete = new System.Windows.Forms.Button();
            this.ButtonTrack3Delete = new System.Windows.Forms.Button();
            this.ButtonTrack1Edit = new System.Windows.Forms.Button();
            this.ButtonTrack2Edit = new System.Windows.Forms.Button();
            this.ButtonTrack3Edit = new System.Windows.Forms.Button();
            this.waveViewer3 = new NAudio.Gui.WaveViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelStrProjectRate = new System.Windows.Forms.Label();
            this.LabelTrack1Name = new System.Windows.Forms.Label();
            this.LabelTrack2Name = new System.Windows.Forms.Label();
            this.LabelTrack3Name = new System.Windows.Forms.Label();
            this.Trackbar = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonVolume = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.waveViewer2 = new NAudio.Gui.WaveViewer();
            this.waveViewer1 = new NAudio.Gui.WaveViewer();
            this.LabelStrZeroes = new System.Windows.Forms.Label();
            this.LabelMainTrackDuration = new System.Windows.Forms.Label();
            this.LabelTrack1Duration = new System.Windows.Forms.Label();
            this.LabelTrack2Duration = new System.Windows.Forms.Label();
            this.LabelTrack3Duration = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Location = new System.Drawing.Point(20, 44);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(75, 39);
            this.ButtonPlay.TabIndex = 0;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = false;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackColor = System.Drawing.Color.LightGray;
            this.ButtonPause.Enabled = false;
            this.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPause.Location = new System.Drawing.Point(101, 44);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(75, 39);
            this.ButtonPause.TabIndex = 1;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.UseVisualStyleBackColor = false;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackColor = System.Drawing.Color.LightGray;
            this.ButtonStop.Enabled = false;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Location = new System.Drawing.Point(182, 44);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 39);
            this.ButtonStop.TabIndex = 2;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = false;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonTrack1Open
            // 
            this.ButtonTrack1Open.Location = new System.Drawing.Point(20, 210);
            this.ButtonTrack1Open.Name = "ButtonTrack1Open";
            this.ButtonTrack1Open.Size = new System.Drawing.Size(80, 24);
            this.ButtonTrack1Open.TabIndex = 4;
            this.ButtonTrack1Open.Text = "Open";
            this.ButtonTrack1Open.UseVisualStyleBackColor = true;
            this.ButtonTrack1Open.Click += new System.EventHandler(this.ButtonTrack1Open_Click);
            // 
            // ButtonTrack2Open
            // 
            this.ButtonTrack2Open.Location = new System.Drawing.Point(20, 316);
            this.ButtonTrack2Open.Name = "ButtonTrack2Open";
            this.ButtonTrack2Open.Size = new System.Drawing.Size(80, 24);
            this.ButtonTrack2Open.TabIndex = 5;
            this.ButtonTrack2Open.Text = "Open";
            this.ButtonTrack2Open.UseVisualStyleBackColor = true;
            this.ButtonTrack2Open.Click += new System.EventHandler(this.ButtonTrack2Open_Click);
            // 
            // ButtonTrack3Open
            // 
            this.ButtonTrack3Open.Location = new System.Drawing.Point(20, 421);
            this.ButtonTrack3Open.Name = "ButtonTrack3Open";
            this.ButtonTrack3Open.Size = new System.Drawing.Size(80, 24);
            this.ButtonTrack3Open.TabIndex = 6;
            this.ButtonTrack3Open.Text = "Open";
            this.ButtonTrack3Open.UseVisualStyleBackColor = true;
            this.ButtonTrack3Open.Click += new System.EventHandler(this.ButtonTrack3Open_Click);
            // 
            // ButtonTrimStart
            // 
            this.ButtonTrimStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrimStart.Location = new System.Drawing.Point(566, 32);
            this.ButtonTrimStart.Name = "ButtonTrimStart";
            this.ButtonTrimStart.Size = new System.Drawing.Size(74, 36);
            this.ButtonTrimStart.TabIndex = 7;
            this.ButtonTrimStart.Text = "Trim from start";
            this.ButtonTrimStart.UseVisualStyleBackColor = true;
            this.ButtonTrimStart.Click += new System.EventHandler(this.ButtonTrimStart_Click);
            // 
            // ButtonTrimEnd
            // 
            this.ButtonTrimEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrimEnd.Location = new System.Drawing.Point(566, 71);
            this.ButtonTrimEnd.Name = "ButtonTrimEnd";
            this.ButtonTrimEnd.Size = new System.Drawing.Size(74, 36);
            this.ButtonTrimEnd.TabIndex = 8;
            this.ButtonTrimEnd.Text = "Trim from end";
            this.ButtonTrimEnd.UseVisualStyleBackColor = true;
            this.ButtonTrimEnd.Click += new System.EventHandler(this.ButtonTrimEnd_Click);
            // 
            // ButtonDuplicate
            // 
            this.ButtonDuplicate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDuplicate.Location = new System.Drawing.Point(644, 32);
            this.ButtonDuplicate.Name = "ButtonDuplicate";
            this.ButtonDuplicate.Size = new System.Drawing.Size(74, 36);
            this.ButtonDuplicate.TabIndex = 9;
            this.ButtonDuplicate.Text = "Duplicate";
            this.ButtonDuplicate.UseVisualStyleBackColor = true;
            this.ButtonDuplicate.Click += new System.EventHandler(this.ButtonDuplicate_Click);
            // 
            // ButtonDelay
            // 
            this.ButtonDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelay.Location = new System.Drawing.Point(644, 71);
            this.ButtonDelay.Name = "ButtonDelay";
            this.ButtonDelay.Size = new System.Drawing.Size(74, 36);
            this.ButtonDelay.TabIndex = 10;
            this.ButtonDelay.Text = "Delay";
            this.ButtonDelay.UseVisualStyleBackColor = true;
            this.ButtonDelay.Click += new System.EventHandler(this.ButtonDelay_Click);
            // 
            // ButtonFadeIn
            // 
            this.ButtonFadeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFadeIn.Location = new System.Drawing.Point(722, 32);
            this.ButtonFadeIn.Name = "ButtonFadeIn";
            this.ButtonFadeIn.Size = new System.Drawing.Size(74, 36);
            this.ButtonFadeIn.TabIndex = 11;
            this.ButtonFadeIn.Text = "Fade in";
            this.ButtonFadeIn.UseVisualStyleBackColor = true;
            this.ButtonFadeIn.Click += new System.EventHandler(this.ButtonFadeIn_Click);
            // 
            // LabelTrack1Border
            // 
            this.LabelTrack1Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTrack1Border.ForeColor = System.Drawing.Color.Black;
            this.LabelTrack1Border.Location = new System.Drawing.Point(14, 159);
            this.LabelTrack1Border.Name = "LabelTrack1Border";
            this.LabelTrack1Border.Size = new System.Drawing.Size(785, 107);
            this.LabelTrack1Border.TabIndex = 13;
            // 
            // LabelTrack2Border
            // 
            this.LabelTrack2Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTrack2Border.ForeColor = System.Drawing.Color.Black;
            this.LabelTrack2Border.Location = new System.Drawing.Point(14, 265);
            this.LabelTrack2Border.Name = "LabelTrack2Border";
            this.LabelTrack2Border.Size = new System.Drawing.Size(785, 107);
            this.LabelTrack2Border.TabIndex = 14;
            // 
            // LabelTrack3Border
            // 
            this.LabelTrack3Border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelTrack3Border.ForeColor = System.Drawing.Color.Black;
            this.LabelTrack3Border.Location = new System.Drawing.Point(14, 371);
            this.LabelTrack3Border.Name = "LabelTrack3Border";
            this.LabelTrack3Border.Size = new System.Drawing.Size(785, 107);
            this.LabelTrack3Border.TabIndex = 15;
            // 
            // LabelStrTrack1
            // 
            this.LabelStrTrack1.AutoSize = true;
            this.LabelStrTrack1.Location = new System.Drawing.Point(17, 163);
            this.LabelStrTrack1.Name = "LabelStrTrack1";
            this.LabelStrTrack1.Size = new System.Drawing.Size(44, 13);
            this.LabelStrTrack1.TabIndex = 16;
            this.LabelStrTrack1.Text = "Track 1";
            // 
            // LabelStrTrack2
            // 
            this.LabelStrTrack2.AutoSize = true;
            this.LabelStrTrack2.Location = new System.Drawing.Point(17, 269);
            this.LabelStrTrack2.Name = "LabelStrTrack2";
            this.LabelStrTrack2.Size = new System.Drawing.Size(44, 13);
            this.LabelStrTrack2.TabIndex = 17;
            this.LabelStrTrack2.Text = "Track 2";
            // 
            // LabelStrTrack3
            // 
            this.LabelStrTrack3.AutoSize = true;
            this.LabelStrTrack3.Location = new System.Drawing.Point(17, 375);
            this.LabelStrTrack3.Name = "LabelStrTrack3";
            this.LabelStrTrack3.Size = new System.Drawing.Size(44, 13);
            this.LabelStrTrack3.TabIndex = 18;
            this.LabelStrTrack3.Text = "Track 3";
            // 
            // LabelSeparator
            // 
            this.LabelSeparator.BackColor = System.Drawing.Color.Black;
            this.LabelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelSeparator.Location = new System.Drawing.Point(187, 159);
            this.LabelSeparator.Name = "LabelSeparator";
            this.LabelSeparator.Size = new System.Drawing.Size(5, 319);
            this.LabelSeparator.TabIndex = 19;
            // 
            // ButtonTrack1Delete
            // 
            this.ButtonTrack1Delete.Enabled = false;
            this.ButtonTrack1Delete.Location = new System.Drawing.Point(101, 210);
            this.ButtonTrack1Delete.Name = "ButtonTrack1Delete";
            this.ButtonTrack1Delete.Size = new System.Drawing.Size(80, 24);
            this.ButtonTrack1Delete.TabIndex = 20;
            this.ButtonTrack1Delete.Text = "Delete";
            this.ButtonTrack1Delete.UseVisualStyleBackColor = true;
            this.ButtonTrack1Delete.Click += new System.EventHandler(this.ButtonTrack1Delete_Click);
            // 
            // ButtonTrack2Delete
            // 
            this.ButtonTrack2Delete.Enabled = false;
            this.ButtonTrack2Delete.Location = new System.Drawing.Point(101, 316);
            this.ButtonTrack2Delete.Name = "ButtonTrack2Delete";
            this.ButtonTrack2Delete.Size = new System.Drawing.Size(80, 24);
            this.ButtonTrack2Delete.TabIndex = 21;
            this.ButtonTrack2Delete.Text = "Delete";
            this.ButtonTrack2Delete.UseVisualStyleBackColor = true;
            this.ButtonTrack2Delete.Click += new System.EventHandler(this.ButtonTrack2Delete_Click);
            // 
            // ButtonTrack3Delete
            // 
            this.ButtonTrack3Delete.Enabled = false;
            this.ButtonTrack3Delete.Location = new System.Drawing.Point(101, 421);
            this.ButtonTrack3Delete.Name = "ButtonTrack3Delete";
            this.ButtonTrack3Delete.Size = new System.Drawing.Size(80, 24);
            this.ButtonTrack3Delete.TabIndex = 22;
            this.ButtonTrack3Delete.Text = "Delete";
            this.ButtonTrack3Delete.UseVisualStyleBackColor = true;
            this.ButtonTrack3Delete.Click += new System.EventHandler(this.ButtonTrack3Delete_Click);
            // 
            // ButtonTrack1Edit
            // 
            this.ButtonTrack1Edit.BackColor = System.Drawing.Color.Maroon;
            this.ButtonTrack1Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrack1Edit.ForeColor = System.Drawing.Color.Silver;
            this.ButtonTrack1Edit.Location = new System.Drawing.Point(20, 236);
            this.ButtonTrack1Edit.Name = "ButtonTrack1Edit";
            this.ButtonTrack1Edit.Size = new System.Drawing.Size(161, 24);
            this.ButtonTrack1Edit.TabIndex = 23;
            this.ButtonTrack1Edit.Text = "Select for edit";
            this.ButtonTrack1Edit.UseVisualStyleBackColor = false;
            this.ButtonTrack1Edit.Visible = false;
            this.ButtonTrack1Edit.Click += new System.EventHandler(this.ButtonTrack1Edit_Click);
            // 
            // ButtonTrack2Edit
            // 
            this.ButtonTrack2Edit.BackColor = System.Drawing.Color.Maroon;
            this.ButtonTrack2Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrack2Edit.ForeColor = System.Drawing.Color.Silver;
            this.ButtonTrack2Edit.Location = new System.Drawing.Point(20, 342);
            this.ButtonTrack2Edit.Name = "ButtonTrack2Edit";
            this.ButtonTrack2Edit.Size = new System.Drawing.Size(161, 24);
            this.ButtonTrack2Edit.TabIndex = 27;
            this.ButtonTrack2Edit.Text = "Select for edit";
            this.ButtonTrack2Edit.UseVisualStyleBackColor = false;
            this.ButtonTrack2Edit.Visible = false;
            this.ButtonTrack2Edit.Click += new System.EventHandler(this.ButtonTrack2Edit_Click);
            // 
            // ButtonTrack3Edit
            // 
            this.ButtonTrack3Edit.BackColor = System.Drawing.Color.Maroon;
            this.ButtonTrack3Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrack3Edit.ForeColor = System.Drawing.Color.Silver;
            this.ButtonTrack3Edit.Location = new System.Drawing.Point(20, 448);
            this.ButtonTrack3Edit.Name = "ButtonTrack3Edit";
            this.ButtonTrack3Edit.Size = new System.Drawing.Size(161, 24);
            this.ButtonTrack3Edit.TabIndex = 28;
            this.ButtonTrack3Edit.Text = "Select for edit";
            this.ButtonTrack3Edit.UseVisualStyleBackColor = false;
            this.ButtonTrack3Edit.Visible = false;
            this.ButtonTrack3Edit.Click += new System.EventHandler(this.ButtonTrack3Edit_Click);
            // 
            // waveViewer3
            // 
            this.waveViewer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.waveViewer3.ForeColor = System.Drawing.Color.Red;
            this.waveViewer3.Location = new System.Drawing.Point(202, 391);
            this.waveViewer3.Name = "waveViewer3";
            this.waveViewer3.SamplesPerPixel = 1024;
            this.waveViewer3.Size = new System.Drawing.Size(583, 70);
            this.waveViewer3.StartPosition = ((long)(0));
            this.waveViewer3.TabIndex = 35;
            this.waveViewer3.WaveStream = null;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(360, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelStrProjectRate
            // 
            this.LabelStrProjectRate.AutoSize = true;
            this.LabelStrProjectRate.Location = new System.Drawing.Point(358, 37);
            this.LabelStrProjectRate.Name = "LabelStrProjectRate";
            this.LabelStrProjectRate.Size = new System.Drawing.Size(64, 13);
            this.LabelStrProjectRate.TabIndex = 38;
            this.LabelStrProjectRate.Text = "Project rate:";
            // 
            // LabelTrack1Name
            // 
            this.LabelTrack1Name.AutoSize = true;
            this.LabelTrack1Name.Location = new System.Drawing.Point(199, 163);
            this.LabelTrack1Name.Name = "LabelTrack1Name";
            this.LabelTrack1Name.Size = new System.Drawing.Size(33, 13);
            this.LabelTrack1Name.TabIndex = 40;
            this.LabelTrack1Name.Text = "None";
            // 
            // LabelTrack2Name
            // 
            this.LabelTrack2Name.AutoSize = true;
            this.LabelTrack2Name.Location = new System.Drawing.Point(199, 269);
            this.LabelTrack2Name.Name = "LabelTrack2Name";
            this.LabelTrack2Name.Size = new System.Drawing.Size(33, 13);
            this.LabelTrack2Name.TabIndex = 41;
            this.LabelTrack2Name.Text = "None";
            // 
            // LabelTrack3Name
            // 
            this.LabelTrack3Name.AutoSize = true;
            this.LabelTrack3Name.Location = new System.Drawing.Point(199, 375);
            this.LabelTrack3Name.Name = "LabelTrack3Name";
            this.LabelTrack3Name.Size = new System.Drawing.Size(33, 13);
            this.LabelTrack3Name.TabIndex = 42;
            this.LabelTrack3Name.Text = "None";
            // 
            // Trackbar
            // 
            this.Trackbar.AutoSize = false;
            this.Trackbar.Enabled = false;
            this.Trackbar.LargeChange = 1;
            this.Trackbar.Location = new System.Drawing.Point(13, 112);
            this.Trackbar.Name = "Trackbar";
            this.Trackbar.Size = new System.Drawing.Size(785, 23);
            this.Trackbar.TabIndex = 43;
            this.Trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Trackbar.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            this.Trackbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Trackbar_MouseDown);
            this.Trackbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Trackbar_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // ButtonVolume
            // 
            this.ButtonVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVolume.Location = new System.Drawing.Point(722, 71);
            this.ButtonVolume.Name = "ButtonVolume";
            this.ButtonVolume.Size = new System.Drawing.Size(74, 36);
            this.ButtonVolume.TabIndex = 46;
            this.ButtonVolume.Text = "Volume";
            this.ButtonVolume.UseVisualStyleBackColor = true;
            this.ButtonVolume.Click += new System.EventHandler(this.ButtonVolume_Click);
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // waveViewer2
            // 
            this.waveViewer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.waveViewer2.ForeColor = System.Drawing.Color.Red;
            this.waveViewer2.Location = new System.Drawing.Point(202, 285);
            this.waveViewer2.Name = "waveViewer2";
            this.waveViewer2.SamplesPerPixel = 128;
            this.waveViewer2.Size = new System.Drawing.Size(583, 70);
            this.waveViewer2.StartPosition = ((long)(0));
            this.waveViewer2.TabIndex = 48;
            this.waveViewer2.WaveStream = null;
            // 
            // waveViewer1
            // 
            this.waveViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.waveViewer1.ForeColor = System.Drawing.Color.SeaGreen;
            this.waveViewer1.Location = new System.Drawing.Point(202, 179);
            this.waveViewer1.Name = "waveViewer1";
            this.waveViewer1.SamplesPerPixel = 1;
            this.waveViewer1.Size = new System.Drawing.Size(583, 70);
            this.waveViewer1.StartPosition = ((long)(0));
            this.waveViewer1.TabIndex = 49;
            this.waveViewer1.WaveStream = null;
            // 
            // LabelStrZeroes
            // 
            this.LabelStrZeroes.AutoSize = true;
            this.LabelStrZeroes.Location = new System.Drawing.Point(10, 131);
            this.LabelStrZeroes.Name = "LabelStrZeroes";
            this.LabelStrZeroes.Size = new System.Drawing.Size(34, 13);
            this.LabelStrZeroes.TabIndex = 50;
            this.LabelStrZeroes.Text = "00:00";
            // 
            // LabelMainTrackDuration
            // 
            this.LabelMainTrackDuration.AutoSize = true;
            this.LabelMainTrackDuration.Location = new System.Drawing.Point(761, 131);
            this.LabelMainTrackDuration.Name = "LabelMainTrackDuration";
            this.LabelMainTrackDuration.Size = new System.Drawing.Size(34, 13);
            this.LabelMainTrackDuration.TabIndex = 51;
            this.LabelMainTrackDuration.Text = "00:00";
            // 
            // LabelTrack1Duration
            // 
            this.LabelTrack1Duration.AutoSize = true;
            this.LabelTrack1Duration.Location = new System.Drawing.Point(760, 163);
            this.LabelTrack1Duration.Name = "LabelTrack1Duration";
            this.LabelTrack1Duration.Size = new System.Drawing.Size(34, 13);
            this.LabelTrack1Duration.TabIndex = 52;
            this.LabelTrack1Duration.Text = "00:00";
            // 
            // LabelTrack2Duration
            // 
            this.LabelTrack2Duration.AutoSize = true;
            this.LabelTrack2Duration.Location = new System.Drawing.Point(760, 269);
            this.LabelTrack2Duration.Name = "LabelTrack2Duration";
            this.LabelTrack2Duration.Size = new System.Drawing.Size(34, 13);
            this.LabelTrack2Duration.TabIndex = 53;
            this.LabelTrack2Duration.Text = "00:00";
            // 
            // LabelTrack3Duration
            // 
            this.LabelTrack3Duration.AutoSize = true;
            this.LabelTrack3Duration.Location = new System.Drawing.Point(760, 375);
            this.LabelTrack3Duration.Name = "LabelTrack3Duration";
            this.LabelTrack3Duration.Size = new System.Drawing.Size(34, 13);
            this.LabelTrack3Duration.TabIndex = 54;
            this.LabelTrack3Duration.Text = "00:00";
            // 
            // AudioMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 490);
            this.Controls.Add(this.LabelTrack3Duration);
            this.Controls.Add(this.LabelTrack2Duration);
            this.Controls.Add(this.LabelTrack1Duration);
            this.Controls.Add(this.LabelMainTrackDuration);
            this.Controls.Add(this.LabelStrZeroes);
            this.Controls.Add(this.waveViewer1);
            this.Controls.Add(this.waveViewer2);
            this.Controls.Add(this.ButtonVolume);
            this.Controls.Add(this.Trackbar);
            this.Controls.Add(this.LabelTrack3Name);
            this.Controls.Add(this.LabelTrack2Name);
            this.Controls.Add(this.LabelTrack1Name);
            this.Controls.Add(this.LabelStrProjectRate);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.waveViewer3);
            this.Controls.Add(this.ButtonTrack3Edit);
            this.Controls.Add(this.ButtonTrack2Edit);
            this.Controls.Add(this.ButtonTrack1Edit);
            this.Controls.Add(this.ButtonTrack3Delete);
            this.Controls.Add(this.ButtonTrack2Delete);
            this.Controls.Add(this.ButtonTrack1Delete);
            this.Controls.Add(this.LabelSeparator);
            this.Controls.Add(this.LabelStrTrack3);
            this.Controls.Add(this.LabelStrTrack2);
            this.Controls.Add(this.LabelStrTrack1);
            this.Controls.Add(this.ButtonFadeIn);
            this.Controls.Add(this.ButtonDelay);
            this.Controls.Add(this.ButtonDuplicate);
            this.Controls.Add(this.ButtonTrimEnd);
            this.Controls.Add(this.ButtonTrimStart);
            this.Controls.Add(this.ButtonTrack3Open);
            this.Controls.Add(this.ButtonTrack2Open);
            this.Controls.Add(this.ButtonTrack1Open);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.LabelTrack1Border);
            this.Controls.Add(this.LabelTrack2Border);
            this.Controls.Add(this.LabelTrack3Border);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AudioMixer";
            this.Text = "AudioMixer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Blendzior_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Trackbar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonTrack1Open;
        private System.Windows.Forms.Button ButtonTrack2Open;
        private System.Windows.Forms.Button ButtonTrack3Open;
        private System.Windows.Forms.Button ButtonTrimStart;
        private System.Windows.Forms.Button ButtonTrimEnd;
        private System.Windows.Forms.Button ButtonDuplicate;
        private System.Windows.Forms.Button ButtonDelay;
        private System.Windows.Forms.Button ButtonFadeIn;
        private System.Windows.Forms.Label LabelTrack1Border;
        private System.Windows.Forms.Label LabelTrack2Border;
        private System.Windows.Forms.Label LabelTrack3Border;
        private System.Windows.Forms.Label LabelStrTrack1;
        private System.Windows.Forms.Label LabelStrTrack2;
        private System.Windows.Forms.Label LabelStrTrack3;
        private System.Windows.Forms.Label LabelSeparator;
        private System.Windows.Forms.Button ButtonTrack1Delete;
        private System.Windows.Forms.Button ButtonTrack2Delete;
        private System.Windows.Forms.Button ButtonTrack3Delete;
        private System.Windows.Forms.Button ButtonTrack1Edit;
        private System.Windows.Forms.Button ButtonTrack2Edit;
        private System.Windows.Forms.Button ButtonTrack3Edit;
        private NAudio.Gui.WaveViewer waveViewer3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LabelStrProjectRate;
        private System.Windows.Forms.Label LabelTrack1Name;
        private System.Windows.Forms.Label LabelTrack2Name;
        private System.Windows.Forms.Label LabelTrack3Name;
        private System.Windows.Forms.TrackBar Trackbar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Button ButtonVolume;
        public System.Windows.Forms.Timer Timer;
        private NAudio.Gui.WaveViewer waveViewer2;
        private NAudio.Gui.WaveViewer waveViewer1;
        private System.Windows.Forms.Label LabelStrZeroes;
        private System.Windows.Forms.Label LabelMainTrackDuration;
        private System.Windows.Forms.Label LabelTrack1Duration;
        private System.Windows.Forms.Label LabelTrack2Duration;
        private System.Windows.Forms.Label LabelTrack3Duration;
    }
}

