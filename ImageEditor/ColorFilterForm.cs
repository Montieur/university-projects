using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintFlipper
{
    public partial class ColorFilterForm : Form
    {
        MainForm AppPtr;
        FIP.FIP fip = new FIP.FIP();

        public ColorFilterForm(MainForm ptr)
        {
            InitializeComponent();
            AppPtr = ptr;
        }

        private void filterColor(string color)
        {
            Bitmap newBmp = fip.ColorFiltration(AppPtr.bmp, color);
            AppPtr.CreateCanvas();
            AppPtr.redrawImage(newBmp);
            AppPtr.pictureBox1.Refresh();
        }

        private void buttonFilterC_Click(object sender, EventArgs e)
        {
            filterColor("Cyan");
        }

        private void buttonFilterM_Click(object sender, EventArgs e)
        {
            filterColor("Magenta");
        }

        private void buttonFilterY_Click(object sender, EventArgs e)
        {
            filterColor("Yellow");
        }

        private void buttonFilterCM_Click(object sender, EventArgs e)
        {
            filterColor("Cyan-Magenta");
        }

        private void buttonFilterMY_Click(object sender, EventArgs e)
        {
            filterColor("Magenta-Yellow");
        }

        private void buttonFilterCY_Click(object sender, EventArgs e)
        {
            filterColor("Yellow-Cyan");
        }
    }
}
