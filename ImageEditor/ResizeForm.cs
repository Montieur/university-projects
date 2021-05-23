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
    public partial class ResizeForm : Form
    {
        MainForm AppPtr;

        public ResizeForm(MainForm refi)
        {
            AppPtr = refi;
            InitializeComponent();
            
            textBoxWidth.Text = refi.pictureBox1.Width.ToString();
            textBoxHeight.Text = refi.pictureBox1.Height.ToString();
        }


        private void ResizeForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TextBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap temp = new Bitmap(AppPtr.bmp);

            
                AppPtr.pictureBox1.Width = int.Parse(textBoxWidth.Text);
                AppPtr.pictureBox1.Height = int.Parse(textBoxHeight.Text);
                AppPtr.CreateCanvas();
                AppPtr.redrawImage(temp);

                Close();
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
