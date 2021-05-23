namespace PaintFlipper
{
    partial class ColorFilterForm
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
            this.buttonFilterM = new System.Windows.Forms.Button();
            this.buttonFilterY = new System.Windows.Forms.Button();
            this.buttonFilterCM = new System.Windows.Forms.Button();
            this.buttonFilterMY = new System.Windows.Forms.Button();
            this.buttonFilterCY = new System.Windows.Forms.Button();
            this.buttonFilterC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFilterM
            // 
            this.buttonFilterM.Location = new System.Drawing.Point(13, 41);
            this.buttonFilterM.Name = "buttonFilterM";
            this.buttonFilterM.Size = new System.Drawing.Size(136, 23);
            this.buttonFilterM.TabIndex = 0;
            this.buttonFilterM.Text = "Magenta";
            this.buttonFilterM.UseVisualStyleBackColor = true;
            this.buttonFilterM.Click += new System.EventHandler(this.buttonFilterM_Click);
            // 
            // buttonFilterY
            // 
            this.buttonFilterY.Location = new System.Drawing.Point(13, 71);
            this.buttonFilterY.Name = "buttonFilterY";
            this.buttonFilterY.Size = new System.Drawing.Size(136, 23);
            this.buttonFilterY.TabIndex = 1;
            this.buttonFilterY.Text = "Żółty";
            this.buttonFilterY.UseVisualStyleBackColor = true;
            this.buttonFilterY.Click += new System.EventHandler(this.buttonFilterY_Click);
            // 
            // buttonFilterCM
            // 
            this.buttonFilterCM.Location = new System.Drawing.Point(13, 100);
            this.buttonFilterCM.Name = "buttonFilterCM";
            this.buttonFilterCM.Size = new System.Drawing.Size(136, 23);
            this.buttonFilterCM.TabIndex = 2;
            this.buttonFilterCM.Text = "Cyan + Magenta";
            this.buttonFilterCM.UseVisualStyleBackColor = true;
            this.buttonFilterCM.Click += new System.EventHandler(this.buttonFilterCM_Click);
            // 
            // buttonFilterMY
            // 
            this.buttonFilterMY.Location = new System.Drawing.Point(12, 129);
            this.buttonFilterMY.Name = "buttonFilterMY";
            this.buttonFilterMY.Size = new System.Drawing.Size(137, 23);
            this.buttonFilterMY.TabIndex = 3;
            this.buttonFilterMY.Text = "Magenta + Żółty";
            this.buttonFilterMY.UseVisualStyleBackColor = true;
            this.buttonFilterMY.Click += new System.EventHandler(this.buttonFilterMY_Click);
            // 
            // buttonFilterCY
            // 
            this.buttonFilterCY.Location = new System.Drawing.Point(13, 158);
            this.buttonFilterCY.Name = "buttonFilterCY";
            this.buttonFilterCY.Size = new System.Drawing.Size(136, 23);
            this.buttonFilterCY.TabIndex = 4;
            this.buttonFilterCY.Text = "Żółty + Cyan";
            this.buttonFilterCY.UseVisualStyleBackColor = true;
            this.buttonFilterCY.Click += new System.EventHandler(this.buttonFilterCY_Click);
            // 
            // buttonFilterC
            // 
            this.buttonFilterC.Location = new System.Drawing.Point(13, 12);
            this.buttonFilterC.Name = "buttonFilterC";
            this.buttonFilterC.Size = new System.Drawing.Size(136, 23);
            this.buttonFilterC.TabIndex = 5;
            this.buttonFilterC.Text = "Niebieskozielony (Cyan)";
            this.buttonFilterC.UseVisualStyleBackColor = true;
            this.buttonFilterC.Click += new System.EventHandler(this.buttonFilterC_Click);
            // 
            // ColorFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 193);
            this.Controls.Add(this.buttonFilterC);
            this.Controls.Add(this.buttonFilterCY);
            this.Controls.Add(this.buttonFilterMY);
            this.Controls.Add(this.buttonFilterCM);
            this.Controls.Add(this.buttonFilterY);
            this.Controls.Add(this.buttonFilterM);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ColorFilterForm";
            this.Text = "Filtruj kolor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFilterM;
        private System.Windows.Forms.Button buttonFilterY;
        private System.Windows.Forms.Button buttonFilterCM;
        private System.Windows.Forms.Button buttonFilterMY;
        private System.Windows.Forms.Button buttonFilterCY;
        private System.Windows.Forms.Button buttonFilterC;
    }
}