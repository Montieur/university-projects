namespace ImageViewer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonChangeDir = new System.Windows.Forms.Button();
            this.buttonMoveLeft = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveRight = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonRotRight = new System.Windows.Forms.Button();
            this.buttonRotLeft = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zoomIndicator = new System.Windows.Forms.Label();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(15, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            // 
            // buttonChangeDir
            // 
            this.buttonChangeDir.Location = new System.Drawing.Point(511, 13);
            this.buttonChangeDir.Margin = new System.Windows.Forms.Padding(10);
            this.buttonChangeDir.Name = "buttonChangeDir";
            this.buttonChangeDir.Size = new System.Drawing.Size(103, 34);
            this.buttonChangeDir.TabIndex = 3;
            this.buttonChangeDir.Text = "Wybierz folder...";
            this.buttonChangeDir.UseVisualStyleBackColor = true;
            this.buttonChangeDir.Click += new System.EventHandler(this.buttonChangeDir_Click);
            // 
            // buttonMoveLeft
            // 
            this.buttonMoveLeft.Location = new System.Drawing.Point(26, 18);
            this.buttonMoveLeft.Name = "buttonMoveLeft";
            this.buttonMoveLeft.Size = new System.Drawing.Size(30, 25);
            this.buttonMoveLeft.TabIndex = 4;
            this.buttonMoveLeft.Text = "◀";
            this.buttonMoveLeft.UseVisualStyleBackColor = true;
            this.buttonMoveLeft.Click += new System.EventHandler(this.buttonMoveLeft_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(62, 2);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(30, 25);
            this.buttonMoveUp.TabIndex = 5;
            this.buttonMoveUp.Text = "▲";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveRight
            // 
            this.buttonMoveRight.Location = new System.Drawing.Point(98, 18);
            this.buttonMoveRight.Name = "buttonMoveRight";
            this.buttonMoveRight.Size = new System.Drawing.Size(30, 25);
            this.buttonMoveRight.TabIndex = 6;
            this.buttonMoveRight.Text = "▶";
            this.buttonMoveRight.UseVisualStyleBackColor = true;
            this.buttonMoveRight.Click += new System.EventHandler(this.buttonMoveRight_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(62, 33);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(30, 25);
            this.buttonMoveDown.TabIndex = 7;
            this.buttonMoveDown.Text = "▼";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonRotRight
            // 
            this.buttonRotRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRotRight.Location = new System.Drawing.Point(208, 0);
            this.buttonRotRight.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRotRight.Name = "buttonRotRight";
            this.buttonRotRight.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.buttonRotRight.Size = new System.Drawing.Size(37, 56);
            this.buttonRotRight.TabIndex = 8;
            this.buttonRotRight.Text = "⭮";
            this.buttonRotRight.UseVisualStyleBackColor = true;
            this.buttonRotRight.Click += new System.EventHandler(this.buttonRotRight_Click);
            // 
            // buttonRotLeft
            // 
            this.buttonRotLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRotLeft.Location = new System.Drawing.Point(171, 0);
            this.buttonRotLeft.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRotLeft.Name = "buttonRotLeft";
            this.buttonRotLeft.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.buttonRotLeft.Size = new System.Drawing.Size(37, 56);
            this.buttonRotLeft.TabIndex = 9;
            this.buttonRotLeft.Text = "⭯";
            this.buttonRotLeft.UseVisualStyleBackColor = true;
            this.buttonRotLeft.Click += new System.EventHandler(this.buttonRotLeft_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.zoomIndicator);
            this.panel1.Controls.Add(this.buttonChangeDir);
            this.panel1.Controls.Add(this.buttonZoomOut);
            this.panel1.Controls.Add(this.buttonZoomIn);
            this.panel1.Controls.Add(this.buttonMoveRight);
            this.panel1.Controls.Add(this.buttonMoveLeft);
            this.panel1.Controls.Add(this.buttonRotRight);
            this.panel1.Controls.Add(this.buttonRotLeft);
            this.panel1.Controls.Add(this.buttonMoveUp);
            this.panel1.Controls.Add(this.buttonMoveDown);
            this.panel1.Location = new System.Drawing.Point(12, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 62);
            this.panel1.TabIndex = 11;
            // 
            // zoomIndicator
            // 
            this.zoomIndicator.AutoSize = true;
            this.zoomIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zoomIndicator.Location = new System.Drawing.Point(354, 23);
            this.zoomIndicator.Name = "zoomIndicator";
            this.zoomIndicator.Size = new System.Drawing.Size(50, 20);
            this.zoomIndicator.TabIndex = 13;
            this.zoomIndicator.Text = "100%";
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZoomOut.Location = new System.Drawing.Point(315, 17);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(33, 33);
            this.buttonZoomOut.TabIndex = 12;
            this.buttonZoomOut.Text = "-";
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.buttonZoomOut_Click);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZoomIn.Location = new System.Drawing.Point(283, 17);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(33, 33);
            this.buttonZoomIn.TabIndex = 11;
            this.buttonZoomIn.Text = "+";
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.buttonZoomIn_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(481, 19);
            this.listView1.Margin = new System.Windows.Forms.Padding(10);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(169, 276);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 381);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(685, 420);
            this.Name = "Form1";
            this.Text = "Przeglądarka obrazów - Albert Przytuła";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void PictureBox1_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonChangeDir;
        private System.Windows.Forms.Button buttonMoveLeft;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveRight;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonRotRight;
        private System.Windows.Forms.Button buttonRotLeft;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label zoomIndicator;
    }
}

