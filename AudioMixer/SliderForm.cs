using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blenderv2
{
    public partial class SliderForm : Form
    {

        public SliderForm(ProjectTrack t, string option)
        {
            InitializeComponent();
            if (option == "volume")
            {
                valueF = t.audio.Volume;
                trackBar1.Value = (int) (valueF * 20);
            }
            if (option == "pitch")
            {
                valueF = t.pitch;
                trackBar1.Value = (int)(valueF * 20);
            }
            LabelValue.Text = valueF.ToString();
        }

        public float valueF;

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            valueF = trackBar1.Value / 20f;
            LabelValue.Text = valueF.ToString();
        }
    }
}
