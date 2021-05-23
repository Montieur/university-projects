namespace Odtwieracz
{
    partial class FilePicker
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
            this.label3 = new System.Windows.Forms.Label();
            this.listDirs = new System.Windows.Forms.ListBox();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.addFileButton = new System.Windows.Forms.Button();
            this.dirTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dodaj z pliku:";
            // 
            // listDirs
            // 
            this.listDirs.FormattingEnabled = true;
            this.listDirs.Location = new System.Drawing.Point(16, 59);
            this.listDirs.Name = "listDirs";
            this.listDirs.Size = new System.Drawing.Size(169, 147);
            this.listDirs.TabIndex = 5;
            this.listDirs.SelectedIndexChanged += new System.EventHandler(this.listDirs_SelectedIndexChanged);
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.Location = new System.Drawing.Point(191, 59);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(169, 147);
            this.listFiles.TabIndex = 6;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            // 
            // addFileButton
            // 
            this.addFileButton.Enabled = false;
            this.addFileButton.Location = new System.Drawing.Point(285, 28);
            this.addFileButton.Name = "addFileButton";
            this.addFileButton.Size = new System.Drawing.Size(75, 25);
            this.addFileButton.TabIndex = 7;
            this.addFileButton.Text = "Dodaj";
            this.addFileButton.UseVisualStyleBackColor = true;
            this.addFileButton.Click += new System.EventHandler(this.addFileButton_Click);
            // 
            // dirTextBox
            // 
            this.dirTextBox.Enabled = false;
            this.dirTextBox.Location = new System.Drawing.Point(16, 31);
            this.dirTextBox.Name = "dirTextBox";
            this.dirTextBox.Size = new System.Drawing.Size(263, 20);
            this.dirTextBox.TabIndex = 8;
            // 
            // FilePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 220);
            this.Controls.Add(this.dirTextBox);
            this.Controls.Add(this.addFileButton);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.listDirs);
            this.Controls.Add(this.label3);
            this.Name = "FilePicker";
            this.Text = "Dodaj utwór";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listDirs;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Button addFileButton;
        private System.Windows.Forms.TextBox dirTextBox;
    }
}