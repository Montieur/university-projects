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
    public partial class HistogramForm : Form
    {

        

        public HistogramForm(MainForm ptr, int[,] histogram)
        {

            InitializeComponent();

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            Bitmap bg = new Bitmap(w, h);
            Graphics.FromImage(bg).Clear(Color.White);
            pictureBox1.Image = bg;


            Point pt1, pt2;

            int highestValue = 0;

            int[] highestColors = new int[3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 256; j++)
                {
                    if (histogram[i, j] > highestValue) 
                        highestValue = histogram[i, j];

                    if(histogram[i, j] > highestColors[i]) 
                        highestColors[i] = histogram[i, j];

                }

                
            }
            

            

            for (int i = 0; i < 3; i++)
            {

                pt1 = new Point(1, 1);
                for (int j = 1; j < 256; j++)
                {
                    

                    int saturation = histogram[i, j];

                    double value = (double)saturation / (highestValue + 1);

                    int y = (int)(value * h);

                    pt2 = new Point(j*2, y);

                    if (i == 0)
                    {
                        bg.SetPixel(j*2, y, Color.Red);
                        Graphics.FromImage(bg).DrawLine(new Pen(Color.Red), pt1, pt2);
                    }

                    if (i == 1)
                    {
                        bg.SetPixel(j * 2, y, Color.Green);
                        Graphics.FromImage(bg).DrawLine(new Pen(Color.Green), pt1, pt2);
                    }

                    if (i == 2)
                    {
                        bg.SetPixel(j*2, y, Color.Blue);
                        Graphics.FromImage(bg).DrawLine(new Pen(Color.Blue), pt1, pt2);
                    }
                        
                    
                        

                    pt1 = pt2;

                }

            }

            bg.RotateFlip(RotateFlipType.RotateNoneFlipY);

        }

        

        
    }
}
