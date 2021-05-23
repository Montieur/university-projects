using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        const int listMinHeight = 276;
        Size picMinSize = new Size(474, 301);
        double zoom = 1.0;
        int dV, dH = 0;
        List<Image> images = new List<Image>();
        Image viewedImage;

        private void populate(string dirPath)
        {
            listView1.Items.Clear();
            images.Clear();
            ImageList thumbnails = new ImageList();
            thumbnails.ImageSize = new Size(50, 50);
            
            string[] paths = Directory.GetFiles(dirPath);
            List<string> extensions = new List<string> { ".jpg", ".png", ".gif", ".jpeg", ".bmp", ".tiff", ".exif" };

            int i = 0;
            try
            {
                foreach (string path in paths)
                    if (extensions.Contains(Path.GetExtension(path).ToLowerInvariant()))
                    {
                        Image pic = Image.FromFile(path);
                        images.Add(pic);
                        thumbnails.Images.Add(pic);
                        listView1.Items.Add(path.Remove(0, path.LastIndexOf('\\') + 1), i);
                        i++;
                    }
            }
            catch (Exception e) { MessageBox.Show(e.Message + e.StackTrace + e.Source);}

            listView1.SmallImageList = thumbnails;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int widthDiff = Size.Width - MinimumSize.Width;
            int heightDiff = Size.Height - MinimumSize.Height;
            
            pictureBox1.Height = picMinSize.Height + heightDiff;
            pictureBox1.Width = picMinSize.Width + widthDiff;

            if (pictureBox1.Image != null)
            {
                zoomIndicator.Text = ((int)(zoom * 100)).ToString() + '%';
                pictureBox1.Image = redrawImage(viewedImage);
            }

            listView1.Height = listMinHeight + heightDiff;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                zoom = 1.0;
                int i = listView1.SelectedItems[0].Index;
                viewedImage = images.ElementAt(i);
                pictureBox1.Location = new Point(pictureBox1.Location.X - dH, pictureBox1.Location.Y - dV);
                dV = 0;
                dH = 0;

                while (viewedImage.Width * zoom > pictureBox1.Width || viewedImage.Height * zoom > pictureBox1.Height)
                    zoom -= 0.1;
                zoomIndicator.Text = ((int)(zoom * 100)).ToString() + '%';
                pictureBox1.Image = redrawImage(viewedImage);
            }
            catch (Exception) { }
        }

        private void buttonChangeDir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.png;*.jpg;*.gif;*.jpeg;*.tiff;*.exif;*.bmp";
            ofd.ValidateNames = false;
            ofd.CheckFileExists = false;
            ofd.CheckPathExists = true;
            ofd.FileName = "Wybór folderu";

            if (ofd.ShowDialog() == DialogResult.OK)
                populate(Path.GetDirectoryName(ofd.FileName));
        }

        private void buttonRotLeft_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Image rotatedImg = viewedImage;
                rotatedImg.RotateFlip(RotateFlipType.Rotate270FlipNone);
                pictureBox1.Image = redrawImage(rotatedImg);
            }
        }

        private void buttonRotRight_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Image rotatedImg = viewedImage;
                rotatedImg.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = redrawImage(rotatedImg);
            }
        }

        private Image redrawImage(Image img)
        {
            Bitmap bmp = new Bitmap(img, Convert.ToInt32(img.Width * zoom), Convert.ToInt32(img.Height * zoom));
            Graphics g = Graphics.FromImage(bmp);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            return bmp;
        }

        private void buttonZoomIn_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (zoom < 4) zoom = zoom + 0.1;
                zoomIndicator.Text = ((int)(zoom * 100)).ToString() + '%';
                pictureBox1.Image = redrawImage(viewedImage);
            }
        }

        private void buttonZoomOut_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (zoom > 0.2) zoom = zoom - 0.1;
                zoomIndicator.Text = ((int)(zoom * 100)).ToString() + '%';
                pictureBox1.Image = redrawImage(viewedImage);
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                if (viewedImage.Width * zoom > pictureBox1.Width || viewedImage.Height * zoom > pictureBox1.Height)
                    while (viewedImage.Width * zoom > pictureBox1.Width || viewedImage.Height * zoom > pictureBox1.Height)
                        zoom -= 0.1;
                else if (viewedImage.Width * (zoom + 0.1) < pictureBox1.Width || viewedImage.Height * (zoom + 0.1) < pictureBox1.Height)
                    while (viewedImage.Width * (zoom + 0.1) < pictureBox1.Width && viewedImage.Height * (zoom + 0.1) < pictureBox1.Height)
                        zoom += 0.1;

                zoomIndicator.Text = ((int)(zoom * 100)).ToString() + '%';
                pictureBox1.Image = redrawImage(viewedImage);
            }
        }

        private void moveImgH(int x)
        {
            dH += x;
            pictureBox1.Location = new Point(pictureBox1.Location.X + x, pictureBox1.Location.Y);
        }

        private void moveImgV(int x)
        {
            dV += x;
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + x);
        }

        private void buttonMoveUp_Click(object sender, EventArgs e) { moveImgV(-10); }
        private void buttonMoveDown_Click(object sender, EventArgs e) { moveImgV(10); }
        private void buttonMoveLeft_Click(object sender, EventArgs e) { moveImgH(-10);}
        private void buttonMoveRight_Click(object sender, EventArgs e) { moveImgH(10);}
            
        bool mousePressed = false;
        int mouseX, mouseY;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mousePressed = true;
                mouseX = e.Y;
                mouseY = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
            dH += mouseY - e.Y;
            dV += mouseX - e.X;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
            {
                moveImgV(e.Y - mouseX);
                moveImgH(e.X - mouseY);
            }
        }

        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta != 0)
            {
                if (e.Delta > 0)
                {
                    buttonZoomIn_Click(sender, e);
                }
                if (e.Delta < 0)
                {
                    buttonZoomOut_Click(sender, e);
                }
            }

        }

    }
}