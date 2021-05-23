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

namespace PaintFlipper
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CreateCanvas();
            setPenSizes();
        }

        public void CreateCanvas()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            bmpcp = new Bitmap(bmp);
        }

        public void redrawImage(Bitmap b)
        {
            g.DrawImageUnscaled(b, new Point(0,0));
        }

        FIP.FIP fip = new FIP.FIP();
        Graphics g;
        public Bitmap bmp, bmpcp;
        bool drawing = false;
        bool fill = false;
        bool ctrlPressed = false;
        Point start = new Point();
        Point end = new Point();
        List<Point> points = new List<Point>();
        int startAngle = 90;
        int sweepAngle = 180;
        

        char tool = 'p';
        SolidBrush sBrush = new SolidBrush(Color.Black);
        Pen cPen;

        int[] sizes = new int[10];
        private void setPenSizes()
        {
            cPen = new Pen(sBrush);
            cPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            for (int i = 0; i< 10; i++)
            {
                sizes[i] = i * 3 + 1;
                comboBoxBrushSize.Items.Add(sizes[i]);
            }
            comboBoxBrushSize.SelectedIndex = 0;
        }

        

        private void drawShape(PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bmp, new Point(0, 0));

            switch (tool)
            {
                // punkt
                case 'p':
                    e.Graphics.DrawLine(cPen, start, end);
                    break;

                // linia
                case 'l':
                    e.Graphics.DrawLine(cPen, start, end);
                    break;

                // kwadrat/prostokąt
                case 'k':

                    if (ctrlPressed)
                    {
                        int width = Math.Max(end.X - start.X, end.Y - start.Y);
                        if (fill)
                            e.Graphics.FillRectangle(cPen.Brush, start.X, start.Y, width, width);
                        else
                            e.Graphics.DrawRectangle(cPen, start.X, start.Y, width, width);
                        break;
                    }
                    else
                    {
                        if (fill)
                            e.Graphics.FillRectangle(cPen.Brush, start.X, start.Y, end.X - start.X, end.Y - start.Y);
                        else
                            e.Graphics.DrawRectangle(cPen, start.X, start.Y, end.X - start.X, end.Y - start.Y);
                        break;
                    }

                // koło/elipsa
                case 'c':
                    if (ctrlPressed)
                    {
                        int width = Math.Max(end.X - start.X, end.Y - start.Y);
                        if (fill)
                            e.Graphics.FillEllipse(cPen.Brush, start.X, start.Y, width, width);
                        else
                            e.Graphics.DrawEllipse(cPen, start.X, start.Y, width, width);
                        break;
                    }
                    else
                    {
                        if (fill)
                            e.Graphics.FillEllipse(cPen.Brush, start.X, start.Y, end.X - start.X, end.Y - start.Y);
                        else
                            e.Graphics.DrawEllipse(cPen, start.X, start.Y, end.X - start.X, end.Y - start.Y);
                        break;
                    }
                    
                // łuk
                case 'a':

                    if(end.X > start.X && end.Y > start.Y)
                        e.Graphics.DrawArc(cPen, start.X, start.Y, end.X - start.X, end.Y - start.Y, startAngle, sweepAngle);
                    break;

                // wycinek koła
                case 't':
                    if (end.X > start.X && end.Y > start.Y)
                    {

                        if (ctrlPressed)
                        {
                            int width = Math.Max(end.X - start.X, end.Y - start.Y);
                            if (fill)
                                e.Graphics.FillPie(cPen.Brush, start.X, start.Y, width, width, startAngle, sweepAngle);
                            else
                                e.Graphics.DrawPie(cPen, start.X, start.Y, width, width, startAngle, sweepAngle);
                            break;
                        }
                        else
                        {
                            if (fill)
                                e.Graphics.FillPie(cPen.Brush, start.X, start.Y, end.X - start.X, end.Y - start.Y, startAngle, sweepAngle);
                            else
                                e.Graphics.DrawPie(cPen, start.X, start.Y, end.X - start.X, end.Y - start.Y, startAngle, sweepAngle);
                            break;
                        }

                    }
                    break;


                default:
                    break;
            }

        }

        private void drawShape()
        {
            g.DrawImageUnscaled(bmp, new Point(0, 0));

            switch (tool)
            {
                // punkt
                case 'p':
                    g.DrawLine(cPen, start, end);
                    break;

                // linia
                case 'l':
                    g.DrawLine(cPen, start, end);
                    break;

                // kwadrat/prostokąt
                case 'k':
                    if (ctrlPressed)
                    {
                        int width = Math.Max(end.X - start.X, end.Y - start.Y);
                        if (fill)
                            g.FillRectangle(cPen.Brush, start.X, start.Y, width, width);
                        else
                            g.DrawRectangle(cPen, start.X, start.Y, width, width);
                        break;
                    }
                    else
                    {
                        if (fill)
                            g.FillRectangle(cPen.Brush, start.X, start.Y, end.X - start.X, end.Y - start.Y);
                        else
                            g.DrawRectangle(cPen, start.X, start.Y, end.X - start.X, end.Y - start.Y);
                        break;
                    }

                // koło/elipsa
                case 'c':
                    if (ctrlPressed)
                    {
                        int width = Math.Max(end.X - start.X, end.Y - start.Y);
                        if (fill)
                            g.FillEllipse(cPen.Brush, start.X, start.Y, width, width);
                        else
                            g.DrawEllipse(cPen, start.X, start.Y, width, width);
                        break;
                    }
                    else
                    {
                        if (fill)
                            g.FillEllipse(cPen.Brush, start.X, start.Y, end.X - start.X, end.Y - start.Y);
                        else
                            g.DrawEllipse(cPen, start.X, start.Y, end.X - start.X, end.Y - start.Y);
                        break;
                    }

                // łuk
                case 'a':
                    if (end.X > start.X && end.Y > start.Y)
                        g.DrawArc(cPen, start.X, start.Y, end.X - start.X, end.Y - start.Y, startAngle, sweepAngle);
                    break;

                // wycinek koła
                case 't':
                    if (end.X > start.X && end.Y > start.Y)
                    {

                        if (ctrlPressed)
                        {
                            int width = Math.Max(end.X - start.X, end.Y - start.Y);
                            if (fill)
                                g.FillPie(cPen.Brush, start.X, start.Y, width, width, startAngle, sweepAngle);
                            else
                                g.DrawPie(cPen, start.X, start.Y, width, width, startAngle, sweepAngle);
                            break;
                        }
                        else
                        {
                            if (fill)
                                g.FillPie(cPen.Brush, start.X, start.Y, end.X - start.X, end.Y - start.Y, startAngle, sweepAngle);
                            else
                                g.DrawPie(cPen, start.X, start.Y, end.X - start.X, end.Y - start.Y, startAngle, sweepAngle);
                            break;
                        }


                    }
                    break;

                // wielokąt
                case 'w':
                    points.Add(end);
                    Point[] polyPoints = new Point[points.Count];

                    for (int i = 0; i < points.Count; i++)
                    {
                        polyPoints[i] = points[i];
                    }
                    if (points.Count > 1)
                    {
                        if (fill)
                            g.FillPolygon(sBrush, polyPoints);
                        else
                            g.DrawPolygon(cPen, polyPoints);
                    }
                    break;

                case 'b':
                    points.Add(end);
                    
                    if (points.Count == 4)
                    {
                        g.DrawBezier(cPen, points[0], points[1], points[2], points[3]);
                        points.Clear();
                    }
                    break;


                default:
                    break;
            }

        }



        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = bmpcp;
            drawing = true;
            start = e.Location;
            end = e.Location;

            bmpcp = new Bitmap(bmp);
        }

        private string getToolName()
        {
            switch (tool)
            {
                case 'p':
                    return "Punkt";
                case 'l':
                    return "Linia";
                case 'k':
                    return "Prostokąt | (CTRL - kwadrat)";
                case 'c':
                    return "Elipsa | (CTRL - koło)";
                case 'a':
                    return "Łuk";
                case 'b':
                    return "Krzywa Beziera";
                case 'w':
                    return "Wielokąt";
                case 't':
                    return "Wycinek koła | (CTRL - proporcje 1:1)";
                default:
                    return "Narzędzie";
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            end = e.Location;

            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString() + " | X,Y: " + end.X + "," + end.Y;
            


            if (drawing)
            {

                // if pencil tool picked
                if (tool == 'p')
                {
                    g.DrawLine(cPen, start, end);
                    start = end;
                }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
            drawShape();
            redrawImage(bmp);
            //pictureBox1.CreateGraphics().DrawImageUnscaled(bmp, new Point(0, 0));
        }


        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImageUnscaled(bmp, new Point(0, 0));
            if (drawing)
            {
                drawShape(e);
            }
        }

        private void showAngleProperties(bool c)
        {
            labelStAngle.Visible = c;
            labelSwAngle.Visible = c;
            textBoxStAngle.Visible = c;
            textBoxSwAngle.Visible = c;
        }

        private void buttonPointTool_Click(object sender, EventArgs e)
        {
            tool = 'p';
            checkBoxFill.Visible = false;
            cPen.Color = labelColorPreview.BackColor;
            showAngleProperties(false);
            buttonColorChange.Enabled = true;
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void buttonLineTool_Click(object sender, EventArgs e)
        {
            tool = 'l';
            checkBoxFill.Visible = false;
            cPen.Color = labelColorPreview.BackColor;
            showAngleProperties(false);
            buttonColorChange.Enabled = true;
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void buttonEllipseTool_Click(object sender, EventArgs e)
        {
            tool = 'c';
            checkBoxFill.Visible = true;
            cPen.Color = labelColorPreview.BackColor;
            showAngleProperties(false);
            buttonColorChange.Enabled = true;
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void buttonRectTool_Click(object sender, EventArgs e)
        {
            tool = 'k';
            checkBoxFill.Visible = true;
            cPen.Color = labelColorPreview.BackColor;
            showAngleProperties(false);
            buttonColorChange.Enabled = true;
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void checkBoxFill_CheckedChanged(object sender, EventArgs e)
        {
            fill = !fill;
        }

        private void buttonArcTool_Click(object sender, EventArgs e)
        {
            tool = 'a';
            checkBoxFill.Visible = false;
            cPen.Color = labelColorPreview.BackColor;
            showAngleProperties(true);
            buttonColorChange.Enabled = true;
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void buttonPieTool_Click(object sender, EventArgs e)
        {
            tool = 't';
            checkBoxFill.Visible = true;
            cPen.Color = labelColorPreview.BackColor;
            showAngleProperties(true);
            buttonColorChange.Enabled = true;
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void buttonBezierTool_Click(object sender, EventArgs e)
        {
            tool = 'b';
            points.Clear();
            checkBoxFill.Visible = false;
            cPen.Color = labelColorPreview.BackColor;
            showAngleProperties(false);
            buttonColorChange.Enabled = true;
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void buttonPolygonTool_Click(object sender, EventArgs e)
        {
            tool = 'w';
            checkBoxFill.Visible = true;
            cPen.Color = labelColorPreview.BackColor;
            showAngleProperties(false);
            buttonColorChange.Enabled = true;
            points.Clear();
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void buttonEraserTool_Click(object sender, EventArgs e)
        {
            tool = 'p';
            checkBoxFill.Visible = false;
            cPen.Color = Color.White;
            showAngleProperties(false);
            buttonColorChange.Enabled = false;
            statusLabel1.Text = getToolName() + " | " + cPen.Color.ToString();
        }

        private void buttonColorChange_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.Color = labelColorPreview.BackColor;
            cd.ShowDialog();
            labelColorPreview.BackColor = cd.Color;
            sBrush.Color = cd.Color;
            cPen.Color = cd.Color;
        }

        private void comboBoxBrushSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPen.Width = sizes[comboBoxBrushSize.SelectedIndex] + 1;
        }

        private void textBoxStAngle_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (textBoxStAngle.Text != "") 
                x = int.Parse(textBoxStAngle.Text);
            if (x > 360)
            {
                textBoxStAngle.Text = "360";
                startAngle = 360;
            }
            startAngle = x;
                
        }

        private void textBoxSwAngle_TextChanged(object sender, EventArgs e)
        {
            int x = 0;
            if (textBoxSwAngle.Text != "")
                x = Int32.Parse(textBoxSwAngle.Text);
            if (x > 360)
            {
                textBoxSwAngle.Text = "360";
                sweepAngle = 360;
            }
            sweepAngle = x;
        }

        
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrlPressed = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) ctrlPressed = false;
        }

        private void textBoxSwAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void menu1SubItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxStAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void menu1SubItem2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void menu1SubItem3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap readBitmap = new Bitmap(openFileDialog1.FileName);
                
                Width += readBitmap.Width - pictureBox1.Width;
                pictureBox1.Width = readBitmap.Width;
                Height += readBitmap.Height - pictureBox1.Height;
                pictureBox1.Height = readBitmap.Height;
                
                CreateCanvas();

                redrawImage(readBitmap);

                pictureBox1.Refresh();
            }
        }

        private void menu1SubItem4_Click(object sender, EventArgs e)
        {
            ResizeForm r = new ResizeForm(this);
            r.ShowDialog();
        }

        private void clearMenuTool_Click(object sender, EventArgs e)
        {
            CreateCanvas();
            pictureBox1.Image = bmp;
        }

        private void resizeImageMenuTool_Click(object sender, EventArgs e)
        {
            ResizeForm r = new ResizeForm(this);
            r.ShowDialog();
        }

        private void buttonContrast_Click(object sender, EventArgs e)
        {
            bmpcp = bmp;
            new RangeSelectForm(this, RangeSelectForm.ProcessType.Contrast).Show();
        }

        private void buttonBrightness_Click(object sender, EventArgs e)
        {
            bmpcp = bmp;
            new RangeSelectForm(this, RangeSelectForm.ProcessType.Brightness).Show();
        }

        private void buttonGamma_Click(object sender, EventArgs e)
        {
            bmpcp = bmp;
            new RangeSelectForm(this, RangeSelectForm.ProcessType.Gamma).Show();
        }

        private void rotateImageMenuTool_Click(object sender, EventArgs e)
        {
            bmpcp = bmp;
            new RangeSelectForm(this, RangeSelectForm.ProcessType.Rotation).Show();
        }

        private void buttonHistogram_Click(object sender, EventArgs e)
        {
            int[,] RGBhistogram = fip.RGBHistogram(bmp);

            new HistogramForm(this, RGBhistogram).Show();
            
        }

       

        private void BlacknWhiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.ToBlackwhite(bmp, 105);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.NegativeImageColor(bmp);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.InverseImage(bmp, 110);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void EdgeDetectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.ImageSobelFilterColor(bmp);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void OilPaintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.OilPaint(bmp, 5, 30);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void CharcoalStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.SketchCharcoal(bmp);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void SketchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.Sketch(bmp);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void ColorFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ColorFilterForm(this).Show();
        }

        private void GSAvgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.ToGreyscaleAVG(bmp);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void GSLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.ToGreyscaleLightness(bmp);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void GSLuminanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap newBmp = fip.ToGreyscale(bmp);
            CreateCanvas();
            redrawImage(newBmp);
            pictureBox1.Refresh();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            bmp.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
        }



    }
}
