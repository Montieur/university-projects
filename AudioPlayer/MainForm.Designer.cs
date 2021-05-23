namespace Odtwieracz
{
    partial class MainForm
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
            this.PlaylistBox = new System.Windows.Forms.ListBox();
            this.TrackTimeBar = new System.Windows.Forms.TrackBar();
            this.PlaylistTimeLabel = new System.Windows.Forms.Label();
            this.PlaylistTotalTimeLabel = new System.Windows.Forms.Label();
            this.TrackTimeAtLabel = new System.Windows.Forms.Label();
            this.TrackLengthLabel = new System.Windows.Forms.Label();
            this.SlashLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ArtistLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.YearLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BitrateLabel = new System.Windows.Forms.Label();
            this.TrackTimer = new System.Windows.Forms.Timer(this.components);
            this.ImagePicturebox = new System.Windows.Forms.PictureBox();
            this.ButtonMoveUp = new System.Windows.Forms.Button();
            this.ButtonMoveDown = new System.Windows.Forms.Button();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonInfinity = new System.Windows.Forms.Button();
            this.ButtonLoop = new System.Windows.Forms.Button();
            this.ButtonShuffle = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.VolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.labelPlus = new System.Windows.Forms.Label();
            this.labelMinus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeBar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaylistBox
            // 
            this.PlaylistBox.BackColor = System.Drawing.Color.LemonChiffon;
            this.PlaylistBox.Font = new System.Drawing.Font("Bahnschrift SemiLight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PlaylistBox.FormattingEnabled = true;
            this.PlaylistBox.ItemHeight = 16;
            this.PlaylistBox.Location = new System.Drawing.Point(13, 291);
            this.PlaylistBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.PlaylistBox.Name = "PlaylistBox";
            this.PlaylistBox.Size = new System.Drawing.Size(309, 132);
            this.PlaylistBox.TabIndex = 3;
            this.PlaylistBox.SelectedIndexChanged += new System.EventHandler(this.PlaylistBox_SelectedIndexChanged);
            this.PlaylistBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlaylistBox_MouseDoubleClick);
            // 
            // TrackTimeBar
            // 
            this.TrackTimeBar.AutoSize = false;
            this.TrackTimeBar.LargeChange = 1;
            this.TrackTimeBar.Location = new System.Drawing.Point(13, 231);
            this.TrackTimeBar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TrackTimeBar.Name = "TrackTimeBar";
            this.TrackTimeBar.Size = new System.Drawing.Size(286, 18);
            this.TrackTimeBar.TabIndex = 11;
            this.TrackTimeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackTimeBar.Scroll += new System.EventHandler(this.TrackTimeBar_Scroll);
            this.TrackTimeBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackTimeBar_MouseDown);
            this.TrackTimeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackTimeBar_MouseUp);
            // 
            // PlaylistTimeLabel
            // 
            this.PlaylistTimeLabel.AutoSize = true;
            this.PlaylistTimeLabel.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistTimeLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.PlaylistTimeLabel.Location = new System.Drawing.Point(147, 431);
            this.PlaylistTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlaylistTimeLabel.Name = "PlaylistTimeLabel";
            this.PlaylistTimeLabel.Size = new System.Drawing.Size(72, 16);
            this.PlaylistTimeLabel.TabIndex = 12;
            this.PlaylistTimeLabel.Text = "00:00:00";
            // 
            // PlaylistTotalTimeLabel
            // 
            this.PlaylistTotalTimeLabel.AutoSize = true;
            this.PlaylistTotalTimeLabel.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaylistTotalTimeLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.PlaylistTotalTimeLabel.Location = new System.Drawing.Point(221, 431);
            this.PlaylistTotalTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PlaylistTotalTimeLabel.Name = "PlaylistTotalTimeLabel";
            this.PlaylistTotalTimeLabel.Size = new System.Drawing.Size(88, 16);
            this.PlaylistTotalTimeLabel.TabIndex = 13;
            this.PlaylistTotalTimeLabel.Text = "/ 00:00:00";
            // 
            // TrackTimeAtLabel
            // 
            this.TrackTimeAtLabel.AutoSize = true;
            this.TrackTimeAtLabel.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackTimeAtLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.TrackTimeAtLabel.Location = new System.Drawing.Point(231, 171);
            this.TrackTimeAtLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrackTimeAtLabel.Name = "TrackTimeAtLabel";
            this.TrackTimeAtLabel.Size = new System.Drawing.Size(65, 22);
            this.TrackTimeAtLabel.TabIndex = 14;
            this.TrackTimeAtLabel.Text = "00:00";
            // 
            // TrackLengthLabel
            // 
            this.TrackLengthLabel.AutoSize = true;
            this.TrackLengthLabel.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackLengthLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.TrackLengthLabel.Location = new System.Drawing.Point(231, 201);
            this.TrackLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrackLengthLabel.Name = "TrackLengthLabel";
            this.TrackLengthLabel.Size = new System.Drawing.Size(65, 22);
            this.TrackLengthLabel.TabIndex = 15;
            this.TrackLengthLabel.Text = "00:00";
            // 
            // SlashLabel
            // 
            this.SlashLabel.AutoSize = true;
            this.SlashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlashLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SlashLabel.Location = new System.Drawing.Point(231, 181);
            this.SlashLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SlashLabel.Name = "SlashLabel";
            this.SlashLabel.Size = new System.Drawing.Size(68, 26);
            this.SlashLabel.TabIndex = 16;
            this.SlashLabel.Text = "--------";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.TitleLabel.Location = new System.Drawing.Point(0, 19);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(71, 16);
            this.TitleLabel.TabIndex = 20;
            this.TitleLabel.Text = "(title)";
            // 
            // ArtistLabel
            // 
            this.ArtistLabel.AutoSize = true;
            this.ArtistLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ArtistLabel.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ArtistLabel.Location = new System.Drawing.Point(0, 0);
            this.ArtistLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 9);
            this.ArtistLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.ArtistLabel.Name = "ArtistLabel";
            this.ArtistLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.ArtistLabel.Size = new System.Drawing.Size(63, 19);
            this.ArtistLabel.TabIndex = 21;
            this.ArtistLabel.Text = "(artist)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.ArtistLabel);
            this.panel1.ForeColor = System.Drawing.Color.Orange;
            this.panel1.Location = new System.Drawing.Point(106, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 87);
            this.panel1.TabIndex = 22;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.YearLabel.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.YearLabel.Location = new System.Drawing.Point(0, 19);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 9);
            this.YearLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.YearLabel.Size = new System.Drawing.Size(49, 19);
            this.YearLabel.TabIndex = 22;
            this.YearLabel.Text = "(year)";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GenreLabel.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.GenreLabel.Location = new System.Drawing.Point(0, 0);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.GenreLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.GenreLabel.Size = new System.Drawing.Size(56, 19);
            this.GenreLabel.TabIndex = 23;
            this.GenreLabel.Text = "(genre)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BitrateLabel);
            this.panel2.Controls.Add(this.YearLabel);
            this.panel2.Controls.Add(this.GenreLabel);
            this.panel2.ForeColor = System.Drawing.Color.Orange;
            this.panel2.Location = new System.Drawing.Point(12, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 55);
            this.panel2.TabIndex = 23;
            // 
            // BitrateLabel
            // 
            this.BitrateLabel.AutoSize = true;
            this.BitrateLabel.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitrateLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.BitrateLabel.Location = new System.Drawing.Point(0, 38);
            this.BitrateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 9);
            this.BitrateLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.BitrateLabel.Name = "BitrateLabel";
            this.BitrateLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.BitrateLabel.Size = new System.Drawing.Size(70, 19);
            this.BitrateLabel.TabIndex = 24;
            this.BitrateLabel.Text = "(bitrate)";
            // 
            // TrackTimer
            // 
            this.TrackTimer.Interval = 1000;
            this.TrackTimer.Tick += new System.EventHandler(this.TrackTimer_Tick);
            // 
            // ImagePicturebox
            // 
            this.ImagePicturebox.BackgroundImage = global::Odtwieracz.Properties.Resources.thumbnail;
            this.ImagePicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImagePicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagePicturebox.Location = new System.Drawing.Point(10, 12);
            this.ImagePicturebox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ImagePicturebox.Name = "ImagePicturebox";
            this.ImagePicturebox.Size = new System.Drawing.Size(90, 90);
            this.ImagePicturebox.TabIndex = 19;
            this.ImagePicturebox.TabStop = false;
            // 
            // ButtonMoveUp
            // 
            this.ButtonMoveUp.BackgroundImage = global::Odtwieracz.Properties.Resources.moveup;
            this.ButtonMoveUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonMoveUp.FlatAppearance.BorderSize = 0;
            this.ButtonMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMoveUp.Location = new System.Drawing.Point(250, 254);
            this.ButtonMoveUp.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMoveUp.Name = "ButtonMoveUp";
            this.ButtonMoveUp.Size = new System.Drawing.Size(24, 34);
            this.ButtonMoveUp.TabIndex = 18;
            this.ButtonMoveUp.UseVisualStyleBackColor = true;
            this.ButtonMoveUp.Click += new System.EventHandler(this.ButtonMoveUp_Click);
            // 
            // ButtonMoveDown
            // 
            this.ButtonMoveDown.BackgroundImage = global::Odtwieracz.Properties.Resources.movedown;
            this.ButtonMoveDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonMoveDown.FlatAppearance.BorderSize = 0;
            this.ButtonMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMoveDown.Location = new System.Drawing.Point(272, 254);
            this.ButtonMoveDown.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonMoveDown.Name = "ButtonMoveDown";
            this.ButtonMoveDown.Size = new System.Drawing.Size(24, 34);
            this.ButtonMoveDown.TabIndex = 17;
            this.ButtonMoveDown.UseVisualStyleBackColor = true;
            this.ButtonMoveDown.Click += new System.EventHandler(this.ButtonMoveDown_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackgroundImage = global::Odtwieracz.Properties.Resources.remove;
            this.ButtonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonRemove.FlatAppearance.BorderSize = 0;
            this.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemove.Location = new System.Drawing.Point(212, 254);
            this.ButtonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(40, 34);
            this.ButtonRemove.TabIndex = 10;
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackgroundImage = global::Odtwieracz.Properties.Resources.add;
            this.ButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonAdd.FlatAppearance.BorderSize = 0;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Location = new System.Drawing.Point(174, 254);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(40, 34);
            this.ButtonAdd.TabIndex = 9;
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonInfinity
            // 
            this.ButtonInfinity.BackgroundImage = global::Odtwieracz.Properties.Resources.infinity;
            this.ButtonInfinity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonInfinity.FlatAppearance.BorderSize = 0;
            this.ButtonInfinity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfinity.Location = new System.Drawing.Point(86, 254);
            this.ButtonInfinity.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonInfinity.Name = "ButtonInfinity";
            this.ButtonInfinity.Size = new System.Drawing.Size(40, 34);
            this.ButtonInfinity.TabIndex = 8;
            this.ButtonInfinity.UseVisualStyleBackColor = true;
            this.ButtonInfinity.Click += new System.EventHandler(this.ButtonInfinity_Click);
            // 
            // ButtonLoop
            // 
            this.ButtonLoop.BackgroundImage = global::Odtwieracz.Properties.Resources.loop;
            this.ButtonLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonLoop.FlatAppearance.BorderSize = 0;
            this.ButtonLoop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLoop.Location = new System.Drawing.Point(48, 254);
            this.ButtonLoop.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonLoop.Name = "ButtonLoop";
            this.ButtonLoop.Size = new System.Drawing.Size(40, 34);
            this.ButtonLoop.TabIndex = 7;
            this.ButtonLoop.UseVisualStyleBackColor = true;
            this.ButtonLoop.Click += new System.EventHandler(this.ButtonLoop_Click);
            // 
            // ButtonShuffle
            // 
            this.ButtonShuffle.BackgroundImage = global::Odtwieracz.Properties.Resources.shuffle_off;
            this.ButtonShuffle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonShuffle.FlatAppearance.BorderSize = 0;
            this.ButtonShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShuffle.Location = new System.Drawing.Point(10, 254);
            this.ButtonShuffle.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonShuffle.Name = "ButtonShuffle";
            this.ButtonShuffle.Size = new System.Drawing.Size(40, 34);
            this.ButtonShuffle.TabIndex = 6;
            this.ButtonShuffle.UseVisualStyleBackColor = true;
            this.ButtonShuffle.Click += new System.EventHandler(this.ButtonShuffle_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.BackgroundImage = global::Odtwieracz.Properties.Resources.prev;
            this.ButtonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonPrev.FlatAppearance.BorderSize = 0;
            this.ButtonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPrev.Location = new System.Drawing.Point(13, 175);
            this.ButtonPrev.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(42, 42);
            this.ButtonPrev.TabIndex = 5;
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.BackgroundImage = global::Odtwieracz.Properties.Resources.next;
            this.ButtonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonNext.FlatAppearance.BorderSize = 0;
            this.ButtonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNext.Location = new System.Drawing.Point(181, 175);
            this.ButtonNext.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(42, 42);
            this.ButtonNext.TabIndex = 4;
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.BackgroundImage = global::Odtwieracz.Properties.Resources.pause1;
            this.ButtonPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonPause.FlatAppearance.BorderSize = 0;
            this.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPause.Location = new System.Drawing.Point(97, 175);
            this.ButtonPause.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(42, 42);
            this.ButtonPause.TabIndex = 2;
            this.ButtonPause.UseVisualStyleBackColor = true;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.BackgroundImage = global::Odtwieracz.Properties.Resources.stop1;
            this.ButtonStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonStop.FlatAppearance.BorderSize = 0;
            this.ButtonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStop.Location = new System.Drawing.Point(139, 175);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(42, 42);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.OnButtonStopClick);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.BackgroundImage = global::Odtwieracz.Properties.Resources.play1;
            this.ButtonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonPlay.FlatAppearance.BorderSize = 0;
            this.ButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlay.Location = new System.Drawing.Point(55, 175);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(42, 42);
            this.ButtonPlay.TabIndex = 0;
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.OnButtonPlayClick);
            // 
            // VolumeTrackBar
            // 
            this.VolumeTrackBar.AutoSize = false;
            this.VolumeTrackBar.LargeChange = 1;
            this.VolumeTrackBar.Location = new System.Drawing.Point(305, 181);
            this.VolumeTrackBar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.VolumeTrackBar.Maximum = 100;
            this.VolumeTrackBar.Name = "VolumeTrackBar";
            this.VolumeTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.VolumeTrackBar.Size = new System.Drawing.Size(18, 96);
            this.VolumeTrackBar.TabIndex = 24;
            this.VolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeTrackBar.Value = 50;
            this.VolumeTrackBar.Scroll += new System.EventHandler(this.VolumeTrackBar_Scroll);
            // 
            // labelPlus
            // 
            this.labelPlus.AutoSize = true;
            this.labelPlus.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlus.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelPlus.Location = new System.Drawing.Point(302, 166);
            this.labelPlus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlus.Name = "labelPlus";
            this.labelPlus.Size = new System.Drawing.Size(21, 22);
            this.labelPlus.TabIndex = 25;
            this.labelPlus.Text = "+";
            // 
            // labelMinus
            // 
            this.labelMinus.AutoSize = true;
            this.labelMinus.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinus.ForeColor = System.Drawing.Color.LemonChiffon;
            this.labelMinus.Location = new System.Drawing.Point(302, 267);
            this.labelMinus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinus.Name = "labelMinus";
            this.labelMinus.Size = new System.Drawing.Size(22, 22);
            this.labelMinus.TabIndex = 26;
            this.labelMinus.Text = "-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(333, 455);
            this.Controls.Add(this.VolumeTrackBar);
            this.Controls.Add(this.labelPlus);
            this.Controls.Add(this.labelMinus);
            this.Controls.Add(this.PlaylistTotalTimeLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TrackLengthLabel);
            this.Controls.Add(this.TrackTimeAtLabel);
            this.Controls.Add(this.ImagePicturebox);
            this.Controls.Add(this.ButtonMoveUp);
            this.Controls.Add(this.ButtonMoveDown);
            this.Controls.Add(this.SlashLabel);
            this.Controls.Add(this.PlaylistTimeLabel);
            this.Controls.Add(this.TrackTimeBar);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonInfinity);
            this.Controls.Add(this.ButtonLoop);
            this.Controls.Add(this.ButtonShuffle);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.PlaylistBox);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonPlay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Gramofon";
            ((System.ComponentModel.ISupportInitialize)(this.TrackTimeBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.ListBox PlaylistBox;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Button ButtonShuffle;
        private System.Windows.Forms.Button ButtonLoop;
        private System.Windows.Forms.Button ButtonInfinity;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.TrackBar TrackTimeBar;
        private System.Windows.Forms.Label PlaylistTimeLabel;
        private System.Windows.Forms.Label PlaylistTotalTimeLabel;
        private System.Windows.Forms.Label TrackTimeAtLabel;
        private System.Windows.Forms.Label TrackLengthLabel;
        private System.Windows.Forms.Label SlashLabel;
        private System.Windows.Forms.Button ButtonMoveDown;
        private System.Windows.Forms.Button ButtonMoveUp;
        private System.Windows.Forms.PictureBox ImagePicturebox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ArtistLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BitrateLabel;
        public System.Windows.Forms.Timer TrackTimer;
        private System.Windows.Forms.TrackBar VolumeTrackBar;
        private System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.Label labelMinus;
    }
}

