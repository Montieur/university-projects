using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FIP;
using AForge.Imaging.Filters;

namespace PaintFlipper
{
    public partial class RangeSelectForm : Form
    {
        MainForm AppPtr;
        FIP.FIP fip = new FIP.FIP();
        ProcessType processType;
        

        public enum ProcessType
        {
            Brightness,
            Contrast,
            Gamma,
            Rotation,
            Resize
        }

        private void setTool()
        {
            switch (processType)
            {
                case ProcessType.Rotation:
                    label.Text = "Obrót o:";
                    trackBar.Maximum = 359;
                    trackBar.Minimum = 0;
                    trackBar.Value = 0;
                    break;

                case ProcessType.Brightness:
                    label.Text = "Jasność:";
                    trackBar.Maximum = 255;
                    trackBar.Minimum = -255;
                    trackBar.Value = 0;
                    break;

                case ProcessType.Contrast:
                    label.Text = "Kontrast:";
                    trackBar.Maximum = 255;
                    trackBar.Minimum = -255;
                    trackBar.Value = 0;
                    break;

                case ProcessType.Gamma:
                    label.Text = "Gamma";
                    trackBar.Minimum = -10;
                    trackBar.Maximum = 10;
                    trackBar.Value = 1;

                    break;

                case ProcessType.Resize:
                    break;

                default:
                    break;
            }
            textBox.Text = trackBar.Value.ToString();

        }

        public RangeSelectForm(MainForm ptr, ProcessType pt)
        {
            processType = pt;
            AppPtr = ptr;
            InitializeComponent();
            setTool();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            textBox.Text = trackBar.Value.ToString();
            switch (processType)
            {
                case ProcessType.Rotation:
                    AppPtr.bmp = fip.Rotate(AppPtr.bmpcp, trackBar.Value);
                    
                    break;
                case ProcessType.Brightness:
                    BrightnessCorrection bc = new BrightnessCorrection(trackBar.Value);
                    AppPtr.bmp = bc.Apply(AppPtr.bmpcp);
                    break;

                case ProcessType.Contrast:
                    ContrastCorrection cc = new ContrastCorrection(trackBar.Value);
                    AppPtr.bmp = cc.Apply(AppPtr.bmpcp);
                    break;

                case ProcessType.Gamma:
                    AppPtr.bmp = fip.GammaCorrection(AppPtr.bmpcp, trackBar.Value);
                    break;
                case ProcessType.Resize:
                    break;

                default:
                    break;
            }
            
            AppPtr.pictureBox1.Refresh();
        }
    
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Bitmap nbmp = AppPtr.bmp;
            AppPtr.CreateCanvas();
            AppPtr.redrawImage(nbmp);

            save = true;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            AppPtr.bmp = AppPtr.bmpcp;
            AppPtr.pictureBox1.Refresh();
            Close();
        }

        bool save = false;

        private void RangeSelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!save) AppPtr.bmp = AppPtr.bmpcp;
            AppPtr.pictureBox1.Refresh();

        }
    }
}
