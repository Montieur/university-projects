
namespace Blenderv2
{
    partial class InputBox
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
            this.LabelTool = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.LabelStrSeconds = new System.Windows.Forms.Label();
            this.TextboxInput = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TextboxInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTool
            // 
            this.LabelTool.AutoSize = true;
            this.LabelTool.BackColor = System.Drawing.Color.White;
            this.LabelTool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTool.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelTool.Location = new System.Drawing.Point(12, 14);
            this.LabelTool.Name = "LabelTool";
            this.LabelTool.Size = new System.Drawing.Size(89, 17);
            this.LabelTool.TabIndex = 1;
            this.LabelTool.Text = "Fade out for:";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(7, 70);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 2;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirm.Location = new System.Drawing.Point(105, 70);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(75, 23);
            this.ButtonConfirm.TabIndex = 3;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            // 
            // LabelStrSeconds
            // 
            this.LabelStrSeconds.AutoSize = true;
            this.LabelStrSeconds.BackColor = System.Drawing.Color.White;
            this.LabelStrSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStrSeconds.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LabelStrSeconds.Location = new System.Drawing.Point(108, 41);
            this.LabelStrSeconds.Name = "LabelStrSeconds";
            this.LabelStrSeconds.Size = new System.Drawing.Size(61, 17);
            this.LabelStrSeconds.TabIndex = 4;
            this.LabelStrSeconds.Text = "seconds";
            // 
            // TextboxInput
            // 
            this.TextboxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextboxInput.Location = new System.Drawing.Point(35, 38);
            this.TextboxInput.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.TextboxInput.Name = "TextboxInput";
            this.TextboxInput.Size = new System.Drawing.Size(69, 23);
            this.TextboxInput.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ButtonConfirm);
            this.panel1.Controls.Add(this.ButtonCancel);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 100);
            this.panel1.TabIndex = 6;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(197, 110);
            this.ControlBox = false;
            this.Controls.Add(this.LabelTool);
            this.Controls.Add(this.TextboxInput);
            this.Controls.Add(this.LabelStrSeconds);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            ((System.ComponentModel.ISupportInitialize)(this.TextboxInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTool;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonConfirm;
        private System.Windows.Forms.Label LabelStrSeconds;
        public System.Windows.Forms.NumericUpDown TextboxInput;
        private System.Windows.Forms.Panel panel1;
    }
}