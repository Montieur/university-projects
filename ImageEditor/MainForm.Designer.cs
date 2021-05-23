namespace PaintFlipper
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxFill = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxSwAngle = new System.Windows.Forms.TextBox();
            this.textBoxStAngle = new System.Windows.Forms.TextBox();
            this.labelSwAngle = new System.Windows.Forms.Label();
            this.labelStAngle = new System.Windows.Forms.Label();
            this.buttonColorChange = new System.Windows.Forms.Button();
            this.labelColorPreview = new System.Windows.Forms.Label();
            this.labelBrushColor = new System.Windows.Forms.Label();
            this.comboBoxBrushSize = new System.Windows.Forms.ComboBox();
            this.labelBrushSize = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeImageMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateImageMenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.efektyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlacknWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konwersjaDoSzarościToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GSAvgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GSLightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GSLuminanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OilPaintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CharcoalStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SketchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ColorFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonContrast = new System.Windows.Forms.Button();
            this.buttonBrightness = new System.Windows.Forms.Button();
            this.buttonGamma = new System.Windows.Forms.Button();
            this.buttonHistogram = new System.Windows.Forms.Button();
            this.buttonEraserTool = new System.Windows.Forms.Button();
            this.buttonBezierTool = new System.Windows.Forms.Button();
            this.buttonPolygonTool = new System.Windows.Forms.Button();
            this.buttonPieTool = new System.Windows.Forms.Button();
            this.buttonArcTool = new System.Windows.Forms.Button();
            this.buttonEllipseTool = new System.Windows.Forms.Button();
            this.buttonRectTool = new System.Windows.Forms.Button();
            this.buttonLineTool = new System.Windows.Forms.Button();
            this.buttonPointTool = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EdgeDetectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Narzędzia";
            // 
            // checkBoxFill
            // 
            this.checkBoxFill.AutoSize = true;
            this.checkBoxFill.Location = new System.Drawing.Point(12, 86);
            this.checkBoxFill.Name = "checkBoxFill";
            this.checkBoxFill.Size = new System.Drawing.Size(86, 17);
            this.checkBoxFill.TabIndex = 11;
            this.checkBoxFill.Text = "Wypełnienie";
            this.checkBoxFill.UseVisualStyleBackColor = true;
            this.checkBoxFill.Visible = false;
            this.checkBoxFill.CheckedChanged += new System.EventHandler(this.checkBoxFill_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxSwAngle);
            this.panel1.Controls.Add(this.textBoxStAngle);
            this.panel1.Controls.Add(this.labelSwAngle);
            this.panel1.Controls.Add(this.labelStAngle);
            this.panel1.Controls.Add(this.buttonColorChange);
            this.panel1.Controls.Add(this.labelColorPreview);
            this.panel1.Controls.Add(this.checkBoxFill);
            this.panel1.Controls.Add(this.labelBrushColor);
            this.panel1.Controls.Add(this.comboBoxBrushSize);
            this.panel1.Controls.Add(this.labelBrushSize);
            this.panel1.Location = new System.Drawing.Point(16, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 166);
            this.panel1.TabIndex = 13;
            // 
            // textBoxSwAngle
            // 
            this.textBoxSwAngle.Location = new System.Drawing.Point(60, 136);
            this.textBoxSwAngle.Name = "textBoxSwAngle";
            this.textBoxSwAngle.Size = new System.Drawing.Size(43, 20);
            this.textBoxSwAngle.TabIndex = 15;
            this.textBoxSwAngle.Text = "180";
            this.textBoxSwAngle.Visible = false;
            this.textBoxSwAngle.TextChanged += new System.EventHandler(this.textBoxSwAngle_TextChanged);
            this.textBoxSwAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSwAngle_KeyPress);
            // 
            // textBoxStAngle
            // 
            this.textBoxStAngle.Location = new System.Drawing.Point(60, 110);
            this.textBoxStAngle.Name = "textBoxStAngle";
            this.textBoxStAngle.Size = new System.Drawing.Size(43, 20);
            this.textBoxStAngle.TabIndex = 14;
            this.textBoxStAngle.Text = "90";
            this.textBoxStAngle.Visible = false;
            this.textBoxStAngle.TextChanged += new System.EventHandler(this.textBoxStAngle_TextChanged);
            this.textBoxStAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStAngle_KeyPress);
            // 
            // labelSwAngle
            // 
            this.labelSwAngle.AutoSize = true;
            this.labelSwAngle.Location = new System.Drawing.Point(18, 139);
            this.labelSwAngle.Name = "labelSwAngle";
            this.labelSwAngle.Size = new System.Drawing.Size(36, 13);
            this.labelSwAngle.TabIndex = 13;
            this.labelSwAngle.Text = "Przez:";
            this.labelSwAngle.Visible = false;
            // 
            // labelStAngle
            // 
            this.labelStAngle.AutoSize = true;
            this.labelStAngle.Location = new System.Drawing.Point(30, 113);
            this.labelStAngle.Name = "labelStAngle";
            this.labelStAngle.Size = new System.Drawing.Size(24, 13);
            this.labelStAngle.TabIndex = 12;
            this.labelStAngle.Text = "Od:";
            this.labelStAngle.Visible = false;
            // 
            // buttonColorChange
            // 
            this.buttonColorChange.Location = new System.Drawing.Point(12, 58);
            this.buttonColorChange.Name = "buttonColorChange";
            this.buttonColorChange.Size = new System.Drawing.Size(92, 22);
            this.buttonColorChange.TabIndex = 4;
            this.buttonColorChange.Text = "Zmień kolor...";
            this.buttonColorChange.UseVisualStyleBackColor = true;
            this.buttonColorChange.Click += new System.EventHandler(this.buttonColorChange_Click);
            // 
            // labelColorPreview
            // 
            this.labelColorPreview.BackColor = System.Drawing.Color.Black;
            this.labelColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColorPreview.Location = new System.Drawing.Point(67, 36);
            this.labelColorPreview.Name = "labelColorPreview";
            this.labelColorPreview.Size = new System.Drawing.Size(44, 19);
            this.labelColorPreview.TabIndex = 3;
            // 
            // labelBrushColor
            // 
            this.labelBrushColor.AutoSize = true;
            this.labelBrushColor.Location = new System.Drawing.Point(4, 37);
            this.labelBrushColor.Name = "labelBrushColor";
            this.labelBrushColor.Size = new System.Drawing.Size(34, 13);
            this.labelBrushColor.TabIndex = 2;
            this.labelBrushColor.Text = "Kolor:";
            // 
            // comboBoxBrushSize
            // 
            this.comboBoxBrushSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBrushSize.FormattingEnabled = true;
            this.comboBoxBrushSize.Location = new System.Drawing.Point(67, 3);
            this.comboBoxBrushSize.Name = "comboBoxBrushSize";
            this.comboBoxBrushSize.Size = new System.Drawing.Size(44, 21);
            this.comboBoxBrushSize.TabIndex = 1;
            this.comboBoxBrushSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrushSize_SelectedIndexChanged);
            // 
            // labelBrushSize
            // 
            this.labelBrushSize.AutoSize = true;
            this.labelBrushSize.Location = new System.Drawing.Point(4, 6);
            this.labelBrushSize.Name = "labelBrushSize";
            this.labelBrushSize.Size = new System.Drawing.Size(50, 13);
            this.labelBrushSize.TabIndex = 0;
            this.labelBrushSize.Text = "Grubość:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Bitmap Image (*.bmp)|*.bmp";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1,
            this.obrazToolStripMenuItem,
            this.efektyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.SaveAsMenuItem});
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(38, 20);
            this.menuItem1.Text = "Plik";
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(141, 22);
            this.OpenMenuItem.Text = "Otwórz...";
            this.OpenMenuItem.Click += new System.EventHandler(this.menu1SubItem3_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.Size = new System.Drawing.Size(141, 22);
            this.SaveAsMenuItem.Text = "Zapisz jako...";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.menu1SubItem2_Click);
            // 
            // obrazToolStripMenuItem
            // 
            this.obrazToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearMenuTool,
            this.resizeImageMenuTool,
            this.rotateImageMenuTool});
            this.obrazToolStripMenuItem.Name = "obrazToolStripMenuItem";
            this.obrazToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.obrazToolStripMenuItem.Text = "Obraz";
            // 
            // clearMenuTool
            // 
            this.clearMenuTool.Name = "clearMenuTool";
            this.clearMenuTool.Size = new System.Drawing.Size(160, 22);
            this.clearMenuTool.Text = "Czyść";
            this.clearMenuTool.Click += new System.EventHandler(this.clearMenuTool_Click);
            // 
            // resizeImageMenuTool
            // 
            this.resizeImageMenuTool.Name = "resizeImageMenuTool";
            this.resizeImageMenuTool.Size = new System.Drawing.Size(160, 22);
            this.resizeImageMenuTool.Text = "Zmień rozmiar...";
            this.resizeImageMenuTool.Click += new System.EventHandler(this.resizeImageMenuTool_Click);
            // 
            // rotateImageMenuTool
            // 
            this.rotateImageMenuTool.Name = "rotateImageMenuTool";
            this.rotateImageMenuTool.Size = new System.Drawing.Size(160, 22);
            this.rotateImageMenuTool.Text = "Obróć...";
            this.rotateImageMenuTool.Click += new System.EventHandler(this.rotateImageMenuTool_Click);
            // 
            // efektyToolStripMenuItem
            // 
            this.efektyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlacknWhiteToolStripMenuItem,
            this.negativeToolStripMenuItem,
            this.inverseToolStripMenuItem,
            this.konwersjaDoSzarościToolStripMenuItem,
            this.toolStripSeparator1,
            this.OilPaintToolStripMenuItem,
            this.CharcoalStripMenuItem,
            this.SketchToolStripMenuItem,
            this.toolStripSeparator2,
            this.ColorFilterToolStripMenuItem,
            this.EdgeDetectToolStripMenuItem});
            this.efektyToolStripMenuItem.Name = "efektyToolStripMenuItem";
            this.efektyToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.efektyToolStripMenuItem.Text = "Efekty";
            // 
            // BlacknWhiteToolStripMenuItem
            // 
            this.BlacknWhiteToolStripMenuItem.Name = "BlacknWhiteToolStripMenuItem";
            this.BlacknWhiteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.BlacknWhiteToolStripMenuItem.Text = "Czerń i biel";
            this.BlacknWhiteToolStripMenuItem.Click += new System.EventHandler(this.BlacknWhiteToolStripMenuItem_Click);
            // 
            // negativeToolStripMenuItem
            // 
            this.negativeToolStripMenuItem.Name = "negativeToolStripMenuItem";
            this.negativeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.negativeToolStripMenuItem.Text = "Negatyw";
            this.negativeToolStripMenuItem.Click += new System.EventHandler(this.negativeToolStripMenuItem_Click);
            // 
            // inverseToolStripMenuItem
            // 
            this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
            this.inverseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.inverseToolStripMenuItem.Text = "Inwersja";
            this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
            // 
            // konwersjaDoSzarościToolStripMenuItem
            // 
            this.konwersjaDoSzarościToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GSAvgToolStripMenuItem,
            this.GSLightToolStripMenuItem,
            this.GSLuminanceToolStripMenuItem});
            this.konwersjaDoSzarościToolStripMenuItem.Name = "konwersjaDoSzarościToolStripMenuItem";
            this.konwersjaDoSzarościToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.konwersjaDoSzarościToolStripMenuItem.Text = "Konwersja do szarości";
            // 
            // GSAvgToolStripMenuItem
            // 
            this.GSAvgToolStripMenuItem.Name = "GSAvgToolStripMenuItem";
            this.GSAvgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GSAvgToolStripMenuItem.Text = "Po średniej";
            this.GSAvgToolStripMenuItem.Click += new System.EventHandler(this.GSAvgToolStripMenuItem_Click);
            // 
            // GSLightToolStripMenuItem
            // 
            this.GSLightToolStripMenuItem.Name = "GSLightToolStripMenuItem";
            this.GSLightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GSLightToolStripMenuItem.Text = "Po jasności";
            this.GSLightToolStripMenuItem.Click += new System.EventHandler(this.GSLightToolStripMenuItem_Click);
            // 
            // GSLuminanceToolStripMenuItem
            // 
            this.GSLuminanceToolStripMenuItem.Name = "GSLuminanceToolStripMenuItem";
            this.GSLuminanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GSLuminanceToolStripMenuItem.Text = "Po luminancji";
            this.GSLuminanceToolStripMenuItem.Click += new System.EventHandler(this.GSLuminanceToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(186, 6);
            // 
            // OilPaintToolStripMenuItem
            // 
            this.OilPaintToolStripMenuItem.Name = "OilPaintToolStripMenuItem";
            this.OilPaintToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.OilPaintToolStripMenuItem.Text = "Farby olejne";
            this.OilPaintToolStripMenuItem.Click += new System.EventHandler(this.OilPaintToolStripMenuItem_Click);
            // 
            // CharcoalStripMenuItem
            // 
            this.CharcoalStripMenuItem.Name = "CharcoalStripMenuItem";
            this.CharcoalStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.CharcoalStripMenuItem.Text = "Węgiel";
            this.CharcoalStripMenuItem.Click += new System.EventHandler(this.CharcoalStripMenuItem_Click);
            // 
            // SketchToolStripMenuItem
            // 
            this.SketchToolStripMenuItem.Name = "SketchToolStripMenuItem";
            this.SketchToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.SketchToolStripMenuItem.Text = "Szkic";
            this.SketchToolStripMenuItem.Click += new System.EventHandler(this.SketchToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(186, 6);
            // 
            // ColorFilterToolStripMenuItem
            // 
            this.ColorFilterToolStripMenuItem.Name = "ColorFilterToolStripMenuItem";
            this.ColorFilterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ColorFilterToolStripMenuItem.Text = "Filtruj kolor";
            this.ColorFilterToolStripMenuItem.Click += new System.EventHandler(this.ColorFilterToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(787, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(38, 17);
            this.statusLabel1.Text = "Punkt";
            // 
            // buttonContrast
            // 
            this.buttonContrast.Location = new System.Drawing.Point(16, 311);
            this.buttonContrast.Name = "buttonContrast";
            this.buttonContrast.Size = new System.Drawing.Size(114, 23);
            this.buttonContrast.TabIndex = 16;
            this.buttonContrast.Text = "Kontrast";
            this.buttonContrast.UseVisualStyleBackColor = true;
            this.buttonContrast.Click += new System.EventHandler(this.buttonContrast_Click);
            // 
            // buttonBrightness
            // 
            this.buttonBrightness.Location = new System.Drawing.Point(16, 333);
            this.buttonBrightness.Name = "buttonBrightness";
            this.buttonBrightness.Size = new System.Drawing.Size(114, 23);
            this.buttonBrightness.TabIndex = 17;
            this.buttonBrightness.Text = "Jasność";
            this.buttonBrightness.UseVisualStyleBackColor = true;
            this.buttonBrightness.Click += new System.EventHandler(this.buttonBrightness_Click);
            // 
            // buttonGamma
            // 
            this.buttonGamma.Location = new System.Drawing.Point(16, 355);
            this.buttonGamma.Name = "buttonGamma";
            this.buttonGamma.Size = new System.Drawing.Size(114, 23);
            this.buttonGamma.TabIndex = 18;
            this.buttonGamma.Text = "Gamma";
            this.buttonGamma.UseVisualStyleBackColor = true;
            this.buttonGamma.Click += new System.EventHandler(this.buttonGamma_Click);
            // 
            // buttonHistogram
            // 
            this.buttonHistogram.Location = new System.Drawing.Point(16, 387);
            this.buttonHistogram.Name = "buttonHistogram";
            this.buttonHistogram.Size = new System.Drawing.Size(114, 23);
            this.buttonHistogram.TabIndex = 19;
            this.buttonHistogram.Text = "Histogram";
            this.buttonHistogram.UseVisualStyleBackColor = true;
            this.buttonHistogram.Click += new System.EventHandler(this.buttonHistogram_Click);
            // 
            // buttonEraserTool
            // 
            this.buttonEraserTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEraserTool.Image = global::PaintFlipper.Properties.Resources.eraser;
            this.buttonEraserTool.Location = new System.Drawing.Point(16, 110);
            this.buttonEraserTool.Name = "buttonEraserTool";
            this.buttonEraserTool.Size = new System.Drawing.Size(114, 23);
            this.buttonEraserTool.TabIndex = 12;
            this.buttonEraserTool.UseVisualStyleBackColor = true;
            this.buttonEraserTool.Click += new System.EventHandler(this.buttonEraserTool_Click);
            // 
            // buttonBezierTool
            // 
            this.buttonBezierTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBezierTool.Image = global::PaintFlipper.Properties.Resources.bezier;
            this.buttonBezierTool.Location = new System.Drawing.Point(106, 50);
            this.buttonBezierTool.Name = "buttonBezierTool";
            this.buttonBezierTool.Size = new System.Drawing.Size(24, 24);
            this.buttonBezierTool.TabIndex = 10;
            this.buttonBezierTool.UseVisualStyleBackColor = true;
            this.buttonBezierTool.Click += new System.EventHandler(this.buttonBezierTool_Click);
            // 
            // buttonPolygonTool
            // 
            this.buttonPolygonTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPolygonTool.Image = global::PaintFlipper.Properties.Resources.polygon;
            this.buttonPolygonTool.Location = new System.Drawing.Point(106, 80);
            this.buttonPolygonTool.Name = "buttonPolygonTool";
            this.buttonPolygonTool.Size = new System.Drawing.Size(24, 24);
            this.buttonPolygonTool.TabIndex = 9;
            this.buttonPolygonTool.UseVisualStyleBackColor = true;
            this.buttonPolygonTool.Click += new System.EventHandler(this.buttonPolygonTool_Click);
            // 
            // buttonPieTool
            // 
            this.buttonPieTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPieTool.Image = global::PaintFlipper.Properties.Resources.pie;
            this.buttonPieTool.Location = new System.Drawing.Point(46, 80);
            this.buttonPieTool.Name = "buttonPieTool";
            this.buttonPieTool.Size = new System.Drawing.Size(24, 24);
            this.buttonPieTool.TabIndex = 8;
            this.buttonPieTool.UseVisualStyleBackColor = true;
            this.buttonPieTool.Click += new System.EventHandler(this.buttonPieTool_Click);
            // 
            // buttonArcTool
            // 
            this.buttonArcTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArcTool.Image = global::PaintFlipper.Properties.Resources.arc;
            this.buttonArcTool.Location = new System.Drawing.Point(76, 50);
            this.buttonArcTool.Name = "buttonArcTool";
            this.buttonArcTool.Size = new System.Drawing.Size(24, 24);
            this.buttonArcTool.TabIndex = 7;
            this.buttonArcTool.UseVisualStyleBackColor = true;
            this.buttonArcTool.Click += new System.EventHandler(this.buttonArcTool_Click);
            // 
            // buttonEllipseTool
            // 
            this.buttonEllipseTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEllipseTool.Image = global::PaintFlipper.Properties.Resources.circle;
            this.buttonEllipseTool.Location = new System.Drawing.Point(16, 80);
            this.buttonEllipseTool.Name = "buttonEllipseTool";
            this.buttonEllipseTool.Size = new System.Drawing.Size(24, 24);
            this.buttonEllipseTool.TabIndex = 5;
            this.buttonEllipseTool.UseVisualStyleBackColor = true;
            this.buttonEllipseTool.Click += new System.EventHandler(this.buttonEllipseTool_Click);
            // 
            // buttonRectTool
            // 
            this.buttonRectTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRectTool.Image = global::PaintFlipper.Properties.Resources.rect;
            this.buttonRectTool.Location = new System.Drawing.Point(76, 80);
            this.buttonRectTool.Name = "buttonRectTool";
            this.buttonRectTool.Size = new System.Drawing.Size(24, 24);
            this.buttonRectTool.TabIndex = 4;
            this.buttonRectTool.UseVisualStyleBackColor = true;
            this.buttonRectTool.Click += new System.EventHandler(this.buttonRectTool_Click);
            // 
            // buttonLineTool
            // 
            this.buttonLineTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLineTool.Image = global::PaintFlipper.Properties.Resources.line;
            this.buttonLineTool.Location = new System.Drawing.Point(46, 50);
            this.buttonLineTool.Name = "buttonLineTool";
            this.buttonLineTool.Size = new System.Drawing.Size(24, 24);
            this.buttonLineTool.TabIndex = 3;
            this.buttonLineTool.UseVisualStyleBackColor = true;
            this.buttonLineTool.Click += new System.EventHandler(this.buttonLineTool_Click);
            // 
            // buttonPointTool
            // 
            this.buttonPointTool.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPointTool.Image = global::PaintFlipper.Properties.Resources.point;
            this.buttonPointTool.Location = new System.Drawing.Point(16, 50);
            this.buttonPointTool.Name = "buttonPointTool";
            this.buttonPointTool.Size = new System.Drawing.Size(24, 24);
            this.buttonPointTool.TabIndex = 1;
            this.buttonPointTool.UseVisualStyleBackColor = true;
            this.buttonPointTool.Click += new System.EventHandler(this.buttonPointTool_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(140, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(632, 335);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // EdgeDetectToolStripMenuItem
            // 
            this.EdgeDetectToolStripMenuItem.Name = "EdgeDetectToolStripMenuItem";
            this.EdgeDetectToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.EdgeDetectToolStripMenuItem.Text = "Wykrywanie krawędzi";
            this.EdgeDetectToolStripMenuItem.Click += new System.EventHandler(this.EdgeDetectToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 461);
            this.Controls.Add(this.buttonHistogram);
            this.Controls.Add(this.buttonGamma);
            this.Controls.Add(this.buttonBrightness);
            this.Controls.Add(this.buttonContrast);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEraserTool);
            this.Controls.Add(this.buttonBezierTool);
            this.Controls.Add(this.buttonPolygonTool);
            this.Controls.Add(this.buttonPieTool);
            this.Controls.Add(this.buttonArcTool);
            this.Controls.Add(this.buttonEllipseTool);
            this.Controls.Add(this.buttonRectTool);
            this.Controls.Add(this.buttonLineTool);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPointTool);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "MainForm";
            this.Text = "Edytor graficzny - Albert Przytuła";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPointTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLineTool;
        private System.Windows.Forms.Button buttonRectTool;
        private System.Windows.Forms.Button buttonEllipseTool;
        private System.Windows.Forms.Button buttonArcTool;
        private System.Windows.Forms.Button buttonPieTool;
        private System.Windows.Forms.Button buttonPolygonTool;
        private System.Windows.Forms.Button buttonBezierTool;
        private System.Windows.Forms.CheckBox checkBoxFill;
        private System.Windows.Forms.Button buttonEraserTool;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonColorChange;
        private System.Windows.Forms.Label labelColorPreview;
        private System.Windows.Forms.Label labelBrushColor;
        private System.Windows.Forms.ComboBox comboBoxBrushSize;
        private System.Windows.Forms.Label labelBrushSize;
        private System.Windows.Forms.TextBox textBoxSwAngle;
        private System.Windows.Forms.TextBox textBoxStAngle;
        private System.Windows.Forms.Label labelSwAngle;
        private System.Windows.Forms.Label labelStAngle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem menuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.ToolStripMenuItem obrazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuTool;
        private System.Windows.Forms.ToolStripMenuItem resizeImageMenuTool;
        private System.Windows.Forms.Button buttonContrast;
        private System.Windows.Forms.Button buttonBrightness;
        private System.Windows.Forms.Button buttonGamma;
        private System.Windows.Forms.ToolStripMenuItem rotateImageMenuTool;
        private System.Windows.Forms.Button buttonHistogram;
        private System.Windows.Forms.ToolStripMenuItem efektyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlacknWhiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konwersjaDoSzarościToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GSAvgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GSLightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GSLuminanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OilPaintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CharcoalStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SketchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ColorFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EdgeDetectToolStripMenuItem;
    }
}

