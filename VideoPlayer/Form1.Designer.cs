namespace Filmowiec
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.ButtonPause = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonNext = new System.Windows.Forms.Button();
            this.ButtonPrev = new System.Windows.Forms.Button();
            this.LabelVideoAt = new System.Windows.Forms.Label();
            this.LabelVideoLength = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrackBar = new System.Windows.Forms.TrackBar();
            this.LabelSlash1 = new System.Windows.Forms.Label();
            this.PanelTime = new System.Windows.Forms.Panel();
            this.ListBoxPlaylist = new System.Windows.Forms.ListBox();
            this.PanelPlaylist = new System.Windows.Forms.Panel();
            this.LabelPlaylistLength = new System.Windows.Forms.Label();
            this.LabelSlash2 = new System.Windows.Forms.Label();
            this.LabelPlaylistAt = new System.Windows.Forms.Label();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.ButtonMoveUp = new System.Windows.Forms.Button();
            this.ButtonRemoveVideo = new System.Windows.Forms.Button();
            this.ButtonAddVideo = new System.Windows.Forms.Button();
            this.ButtonLoadPlaylist = new System.Windows.Forms.Button();
            this.ButtonSavePlaylist = new System.Windows.Forms.Button();
            this.checkBoxLoop = new System.Windows.Forms.CheckBox();
            this.checkBoxLoopPlaylist = new System.Windows.Forms.CheckBox();
            this.checkBoxRandomize = new System.Windows.Forms.CheckBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).BeginInit();
            this.PanelTime.SuspendLayout();
            this.PanelPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(0, 27);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(480, 320);
            this.MediaPlayer.TabIndex = 1;
            this.MediaPlayer.MouseMoveEvent += new AxWMPLib._WMPOCXEvents_MouseMoveEventHandler(this.MediaPlayer_MouseMoveEvent);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Location = new System.Drawing.Point(23, 374);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(50, 33);
            this.ButtonPlay.TabIndex = 4;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // ButtonPause
            // 
            this.ButtonPause.Location = new System.Drawing.Point(79, 374);
            this.ButtonPause.Name = "ButtonPause";
            this.ButtonPause.Size = new System.Drawing.Size(50, 33);
            this.ButtonPause.TabIndex = 5;
            this.ButtonPause.Text = "Pause";
            this.ButtonPause.UseVisualStyleBackColor = true;
            this.ButtonPause.Click += new System.EventHandler(this.ButtonPause_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(135, 374);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(50, 33);
            this.ButtonStop.TabIndex = 6;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonNext
            // 
            this.ButtonNext.Location = new System.Drawing.Point(265, 374);
            this.ButtonNext.Name = "ButtonNext";
            this.ButtonNext.Size = new System.Drawing.Size(50, 33);
            this.ButtonNext.TabIndex = 7;
            this.ButtonNext.Text = "Next";
            this.ButtonNext.UseVisualStyleBackColor = true;
            this.ButtonNext.Click += new System.EventHandler(this.ButtonNext_Click);
            // 
            // ButtonPrev
            // 
            this.ButtonPrev.Location = new System.Drawing.Point(209, 374);
            this.ButtonPrev.Name = "ButtonPrev";
            this.ButtonPrev.Size = new System.Drawing.Size(50, 33);
            this.ButtonPrev.TabIndex = 8;
            this.ButtonPrev.Text = "Prev";
            this.ButtonPrev.UseVisualStyleBackColor = true;
            this.ButtonPrev.Click += new System.EventHandler(this.ButtonPrev_Click);
            // 
            // LabelVideoAt
            // 
            this.LabelVideoAt.AutoSize = true;
            this.LabelVideoAt.BackColor = System.Drawing.Color.Black;
            this.LabelVideoAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVideoAt.ForeColor = System.Drawing.Color.White;
            this.LabelVideoAt.Location = new System.Drawing.Point(0, 0);
            this.LabelVideoAt.Name = "LabelVideoAt";
            this.LabelVideoAt.Size = new System.Drawing.Size(66, 25);
            this.LabelVideoAt.TabIndex = 11;
            this.LabelVideoAt.Text = "00:00";
            // 
            // LabelVideoLength
            // 
            this.LabelVideoLength.AutoSize = true;
            this.LabelVideoLength.BackColor = System.Drawing.Color.Black;
            this.LabelVideoLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVideoLength.ForeColor = System.Drawing.Color.White;
            this.LabelVideoLength.Location = new System.Drawing.Point(69, 0);
            this.LabelVideoLength.Name = "LabelVideoLength";
            this.LabelVideoLength.Size = new System.Drawing.Size(66, 25);
            this.LabelVideoLength.TabIndex = 12;
            this.LabelVideoLength.Text = "00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // TrackBar
            // 
            this.TrackBar.AutoSize = false;
            this.TrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.TrackBar.LargeChange = 1;
            this.TrackBar.Location = new System.Drawing.Point(0, 347);
            this.TrackBar.Name = "TrackBar";
            this.TrackBar.Size = new System.Drawing.Size(481, 18);
            this.TrackBar.TabIndex = 15;
            this.TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TrackBar.Scroll += new System.EventHandler(this.TrackBar_Scroll);
            this.TrackBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseDown);
            this.TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TrackBar_MouseUp);
            // 
            // LabelSlash1
            // 
            this.LabelSlash1.BackColor = System.Drawing.Color.Black;
            this.LabelSlash1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSlash1.ForeColor = System.Drawing.Color.White;
            this.LabelSlash1.Location = new System.Drawing.Point(59, 0);
            this.LabelSlash1.Name = "LabelSlash1";
            this.LabelSlash1.Size = new System.Drawing.Size(15, 25);
            this.LabelSlash1.TabIndex = 16;
            this.LabelSlash1.Text = "/";
            // 
            // PanelTime
            // 
            this.PanelTime.BackColor = System.Drawing.Color.Transparent;
            this.PanelTime.Controls.Add(this.LabelSlash1);
            this.PanelTime.Controls.Add(this.LabelVideoAt);
            this.PanelTime.Controls.Add(this.LabelVideoLength);
            this.PanelTime.Location = new System.Drawing.Point(348, 27);
            this.PanelTime.Name = "PanelTime";
            this.PanelTime.Size = new System.Drawing.Size(132, 25);
            this.PanelTime.TabIndex = 17;
            // 
            // ListBoxPlaylist
            // 
            this.ListBoxPlaylist.FormattingEnabled = true;
            this.ListBoxPlaylist.Location = new System.Drawing.Point(4, 3);
            this.ListBoxPlaylist.Name = "ListBoxPlaylist";
            this.ListBoxPlaylist.Size = new System.Drawing.Size(184, 329);
            this.ListBoxPlaylist.TabIndex = 18;
            this.ListBoxPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxPlaylist_MouseDoubleClick);
            // 
            // PanelPlaylist
            // 
            this.PanelPlaylist.Controls.Add(this.LabelPlaylistLength);
            this.PanelPlaylist.Controls.Add(this.LabelSlash2);
            this.PanelPlaylist.Controls.Add(this.LabelPlaylistAt);
            this.PanelPlaylist.Controls.Add(this.buttonMoveDown);
            this.PanelPlaylist.Controls.Add(this.ButtonMoveUp);
            this.PanelPlaylist.Controls.Add(this.ButtonRemoveVideo);
            this.PanelPlaylist.Controls.Add(this.ButtonAddVideo);
            this.PanelPlaylist.Controls.Add(this.ButtonLoadPlaylist);
            this.PanelPlaylist.Controls.Add(this.ButtonSavePlaylist);
            this.PanelPlaylist.Controls.Add(this.ListBoxPlaylist);
            this.PanelPlaylist.Location = new System.Drawing.Point(482, 27);
            this.PanelPlaylist.Name = "PanelPlaylist";
            this.PanelPlaylist.Size = new System.Drawing.Size(200, 408);
            this.PanelPlaylist.TabIndex = 19;
            // 
            // LabelPlaylistLength
            // 
            this.LabelPlaylistLength.AutoSize = true;
            this.LabelPlaylistLength.BackColor = System.Drawing.SystemColors.Control;
            this.LabelPlaylistLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlaylistLength.ForeColor = System.Drawing.Color.Black;
            this.LabelPlaylistLength.Location = new System.Drawing.Point(102, 335);
            this.LabelPlaylistLength.Name = "LabelPlaylistLength";
            this.LabelPlaylistLength.Size = new System.Drawing.Size(80, 24);
            this.LabelPlaylistLength.TabIndex = 17;
            this.LabelPlaylistLength.Text = "00:00:00";
            // 
            // LabelSlash2
            // 
            this.LabelSlash2.BackColor = System.Drawing.SystemColors.Control;
            this.LabelSlash2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSlash2.ForeColor = System.Drawing.Color.Black;
            this.LabelSlash2.Location = new System.Drawing.Point(90, 335);
            this.LabelSlash2.Name = "LabelSlash2";
            this.LabelSlash2.Size = new System.Drawing.Size(15, 25);
            this.LabelSlash2.TabIndex = 17;
            this.LabelSlash2.Text = "/";
            // 
            // LabelPlaylistAt
            // 
            this.LabelPlaylistAt.AutoSize = true;
            this.LabelPlaylistAt.BackColor = System.Drawing.SystemColors.Control;
            this.LabelPlaylistAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlaylistAt.ForeColor = System.Drawing.Color.Black;
            this.LabelPlaylistAt.Location = new System.Drawing.Point(15, 335);
            this.LabelPlaylistAt.Margin = new System.Windows.Forms.Padding(0);
            this.LabelPlaylistAt.Name = "LabelPlaylistAt";
            this.LabelPlaylistAt.Size = new System.Drawing.Size(80, 24);
            this.LabelPlaylistAt.TabIndex = 17;
            this.LabelPlaylistAt.Text = "00:00:00";
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(174, 382);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(20, 19);
            this.buttonMoveDown.TabIndex = 24;
            this.buttonMoveDown.Text = "▼";
            this.buttonMoveDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // ButtonMoveUp
            // 
            this.ButtonMoveUp.Location = new System.Drawing.Point(174, 360);
            this.ButtonMoveUp.Name = "ButtonMoveUp";
            this.ButtonMoveUp.Size = new System.Drawing.Size(20, 20);
            this.ButtonMoveUp.TabIndex = 20;
            this.ButtonMoveUp.Text = "▲";
            this.ButtonMoveUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonMoveUp.UseVisualStyleBackColor = true;
            this.ButtonMoveUp.Click += new System.EventHandler(this.ButtonMoveUp_Click);
            // 
            // ButtonRemoveVideo
            // 
            this.ButtonRemoveVideo.Location = new System.Drawing.Point(46, 364);
            this.ButtonRemoveVideo.Name = "ButtonRemoveVideo";
            this.ButtonRemoveVideo.Size = new System.Drawing.Size(40, 33);
            this.ButtonRemoveVideo.TabIndex = 23;
            this.ButtonRemoveVideo.Text = "Del.";
            this.ButtonRemoveVideo.UseVisualStyleBackColor = true;
            this.ButtonRemoveVideo.Click += new System.EventHandler(this.ButtonRemoveVideo_Click);
            // 
            // ButtonAddVideo
            // 
            this.ButtonAddVideo.Location = new System.Drawing.Point(4, 364);
            this.ButtonAddVideo.Name = "ButtonAddVideo";
            this.ButtonAddVideo.Size = new System.Drawing.Size(40, 33);
            this.ButtonAddVideo.TabIndex = 22;
            this.ButtonAddVideo.Text = "Add";
            this.ButtonAddVideo.UseVisualStyleBackColor = true;
            this.ButtonAddVideo.Click += new System.EventHandler(this.ButtonAddVideo_Click);
            // 
            // ButtonLoadPlaylist
            // 
            this.ButtonLoadPlaylist.Location = new System.Drawing.Point(130, 364);
            this.ButtonLoadPlaylist.Name = "ButtonLoadPlaylist";
            this.ButtonLoadPlaylist.Size = new System.Drawing.Size(40, 33);
            this.ButtonLoadPlaylist.TabIndex = 21;
            this.ButtonLoadPlaylist.Text = "Load";
            this.ButtonLoadPlaylist.UseVisualStyleBackColor = true;
            this.ButtonLoadPlaylist.Click += new System.EventHandler(this.ButtonLoadPlaylist_Click);
            // 
            // ButtonSavePlaylist
            // 
            this.ButtonSavePlaylist.Location = new System.Drawing.Point(88, 364);
            this.ButtonSavePlaylist.Name = "ButtonSavePlaylist";
            this.ButtonSavePlaylist.Size = new System.Drawing.Size(40, 33);
            this.ButtonSavePlaylist.TabIndex = 20;
            this.ButtonSavePlaylist.Text = "Save";
            this.ButtonSavePlaylist.UseVisualStyleBackColor = true;
            this.ButtonSavePlaylist.Click += new System.EventHandler(this.ButtonSavePlaylist_Click);
            // 
            // checkBoxLoop
            // 
            this.checkBoxLoop.AutoSize = true;
            this.checkBoxLoop.Location = new System.Drawing.Point(363, 370);
            this.checkBoxLoop.Name = "checkBoxLoop";
            this.checkBoxLoop.Size = new System.Drawing.Size(79, 17);
            this.checkBoxLoop.TabIndex = 20;
            this.checkBoxLoop.Text = "Loop video";
            this.checkBoxLoop.UseVisualStyleBackColor = true;
            // 
            // checkBoxLoopPlaylist
            // 
            this.checkBoxLoopPlaylist.AutoSize = true;
            this.checkBoxLoopPlaylist.Location = new System.Drawing.Point(363, 390);
            this.checkBoxLoopPlaylist.Name = "checkBoxLoopPlaylist";
            this.checkBoxLoopPlaylist.Size = new System.Drawing.Size(84, 17);
            this.checkBoxLoopPlaylist.TabIndex = 21;
            this.checkBoxLoopPlaylist.Text = "Loop playlist";
            this.checkBoxLoopPlaylist.UseVisualStyleBackColor = true;
            // 
            // checkBoxRandomize
            // 
            this.checkBoxRandomize.AutoSize = true;
            this.checkBoxRandomize.Location = new System.Drawing.Point(363, 410);
            this.checkBoxRandomize.Name = "checkBoxRandomize";
            this.checkBoxRandomize.Size = new System.Drawing.Size(79, 17);
            this.checkBoxRandomize.TabIndex = 22;
            this.checkBoxRandomize.Text = "Randomize";
            this.checkBoxRandomize.UseVisualStyleBackColor = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 435);
            this.Controls.Add(this.checkBoxRandomize);
            this.Controls.Add(this.checkBoxLoopPlaylist);
            this.Controls.Add(this.checkBoxLoop);
            this.Controls.Add(this.PanelPlaylist);
            this.Controls.Add(this.PanelTime);
            this.Controls.Add(this.TrackBar);
            this.Controls.Add(this.ButtonPrev);
            this.Controls.Add(this.ButtonNext);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonPause);
            this.Controls.Add(this.ButtonPlay);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Filmowiec";
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBar)).EndInit();
            this.PanelTime.ResumeLayout(false);
            this.PanelTime.PerformLayout();
            this.PanelPlaylist.ResumeLayout(false);
            this.PanelPlaylist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Button ButtonPlay;
        private System.Windows.Forms.Button ButtonPause;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonNext;
        private System.Windows.Forms.Button ButtonPrev;
        private System.Windows.Forms.Label LabelVideoAt;
        private System.Windows.Forms.Label LabelVideoLength;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TrackBar TrackBar;
        private System.Windows.Forms.Label LabelSlash1;
        private System.Windows.Forms.Panel PanelTime;
        private System.Windows.Forms.ListBox ListBoxPlaylist;
        private System.Windows.Forms.Panel PanelPlaylist;
        private System.Windows.Forms.Button ButtonLoadPlaylist;
        private System.Windows.Forms.Button ButtonSavePlaylist;
        private System.Windows.Forms.Button ButtonRemoveVideo;
        private System.Windows.Forms.Button ButtonAddVideo;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button ButtonMoveUp;
        private System.Windows.Forms.CheckBox checkBoxLoop;
        private System.Windows.Forms.CheckBox checkBoxLoopPlaylist;
        private System.Windows.Forms.CheckBox checkBoxRandomize;
        public System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LabelPlaylistLength;
        private System.Windows.Forms.Label LabelSlash2;
        private System.Windows.Forms.Label LabelPlaylistAt;
    }
}

