
namespace MiningMap
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonSettings = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonShowDialog = new System.Windows.Forms.RadioButton();
            this.radioButtonChangeColor = new System.Windows.Forms.RadioButton();
            this.radioButtonCreateMarker = new System.Windows.Forms.RadioButton();
            this.labelPoint1 = new System.Windows.Forms.Label();
            this.numeric1PointX = new System.Windows.Forms.NumericUpDown();
            this.numeric1PointY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numeric2PointY = new System.Windows.Forms.NumericUpDown();
            this.numeric2PointX = new System.Windows.Forms.NumericUpDown();
            this.labelPoint2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numeric3PointY = new System.Windows.Forms.NumericUpDown();
            this.numeric3PointX = new System.Windows.Forms.NumericUpDown();
            this.labelPoint3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numeric4PointY = new System.Windows.Forms.NumericUpDown();
            this.numeric4PointX = new System.Windows.Forms.NumericUpDown();
            this.labelPoint4 = new System.Windows.Forms.Label();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1PointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1PointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2PointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2PointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric3PointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric3PointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric4PointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric4PointX)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(13, 30);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(449, 408);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            this.gMapControl.Load += new System.EventHandler(this.MapLoaded);
            this.gMapControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapMouseDown);
            this.gMapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapMouseMove);
            this.gMapControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapMouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip";
            // 
            // buttonSettings
            // 
            this.buttonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(29, 24);
            this.buttonSettings.Text = "Открыть окно настроек";
            this.buttonSettings.Click += new System.EventHandler(this.openSettingWindow);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(472, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Управление выделенной областью";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(472, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 81);
            this.label2.TabIndex = 3;
            this.label2.Text = "Действие, совершаемое при попадании маркера в выделенную область:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonShowDialog
            // 
            this.radioButtonShowDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonShowDialog.AutoSize = true;
            this.radioButtonShowDialog.Checked = true;
            this.radioButtonShowDialog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonShowDialog.Location = new System.Drawing.Point(472, 327);
            this.radioButtonShowDialog.Name = "radioButtonShowDialog";
            this.radioButtonShowDialog.Size = new System.Drawing.Size(285, 28);
            this.radioButtonShowDialog.TabIndex = 4;
            this.radioButtonShowDialog.TabStop = true;
            this.radioButtonShowDialog.Text = "Отобразить диалоговое окно";
            this.radioButtonShowDialog.UseVisualStyleBackColor = true;
            this.radioButtonShowDialog.CheckedChanged += new System.EventHandler(this.actionChangedToShowWindow);
            // 
            // radioButtonChangeColor
            // 
            this.radioButtonChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonChangeColor.AutoSize = true;
            this.radioButtonChangeColor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonChangeColor.Location = new System.Drawing.Point(472, 361);
            this.radioButtonChangeColor.Name = "radioButtonChangeColor";
            this.radioButtonChangeColor.Size = new System.Drawing.Size(239, 28);
            this.radioButtonChangeColor.TabIndex = 5;
            this.radioButtonChangeColor.TabStop = true;
            this.radioButtonChangeColor.Text = "Изменить цвет маркера";
            this.radioButtonChangeColor.UseVisualStyleBackColor = true;
            this.radioButtonChangeColor.CheckedChanged += new System.EventHandler(this.actionChangedToChangeColors);
            // 
            // radioButtonCreateMarker
            // 
            this.radioButtonCreateMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCreateMarker.AutoSize = true;
            this.radioButtonCreateMarker.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonCreateMarker.Location = new System.Drawing.Point(472, 395);
            this.radioButtonCreateMarker.Name = "radioButtonCreateMarker";
            this.radioButtonCreateMarker.Size = new System.Drawing.Size(266, 28);
            this.radioButtonCreateMarker.TabIndex = 6;
            this.radioButtonCreateMarker.TabStop = true;
            this.radioButtonCreateMarker.Text = "Создать случайный маркер";
            this.radioButtonCreateMarker.UseVisualStyleBackColor = true;
            this.radioButtonCreateMarker.CheckedChanged += new System.EventHandler(this.actionChangedToCreateRandom);
            // 
            // labelPoint1
            // 
            this.labelPoint1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint1.AutoSize = true;
            this.labelPoint1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint1.Location = new System.Drawing.Point(472, 63);
            this.labelPoint1.Name = "labelPoint1";
            this.labelPoint1.Size = new System.Drawing.Size(74, 24);
            this.labelPoint1.TabIndex = 7;
            this.labelPoint1.Text = "Точка 1";
            this.toolTipMain.SetToolTip(this.labelPoint1, "Левая нижняя точка");
            // 
            // numeric1PointX
            // 
            this.numeric1PointX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric1PointX.DecimalPlaces = 1;
            this.numeric1PointX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric1PointX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric1PointX.Location = new System.Drawing.Point(587, 59);
            this.numeric1PointX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric1PointX.Name = "numeric1PointX";
            this.numeric1PointX.Size = new System.Drawing.Size(83, 32);
            this.numeric1PointX.TabIndex = 8;
            this.numeric1PointX.Tag = "0X";
            // 
            // numeric1PointY
            // 
            this.numeric1PointY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric1PointY.DecimalPlaces = 1;
            this.numeric1PointY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric1PointY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric1PointY.Location = new System.Drawing.Point(701, 59);
            this.numeric1PointY.Name = "numeric1PointY";
            this.numeric1PointY.Size = new System.Drawing.Size(83, 32);
            this.numeric1PointY.TabIndex = 9;
            this.numeric1PointY.Tag = "0Y";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(561, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(675, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(675, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Y";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(561, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "X";
            // 
            // numeric2PointY
            // 
            this.numeric2PointY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric2PointY.DecimalPlaces = 1;
            this.numeric2PointY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric2PointY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric2PointY.Location = new System.Drawing.Point(701, 97);
            this.numeric2PointY.Name = "numeric2PointY";
            this.numeric2PointY.Size = new System.Drawing.Size(83, 32);
            this.numeric2PointY.TabIndex = 14;
            this.numeric2PointY.Tag = "1Y";
            // 
            // numeric2PointX
            // 
            this.numeric2PointX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric2PointX.DecimalPlaces = 1;
            this.numeric2PointX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric2PointX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric2PointX.Location = new System.Drawing.Point(587, 97);
            this.numeric2PointX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric2PointX.Name = "numeric2PointX";
            this.numeric2PointX.Size = new System.Drawing.Size(83, 32);
            this.numeric2PointX.TabIndex = 13;
            this.numeric2PointX.Tag = "1X";
            // 
            // labelPoint2
            // 
            this.labelPoint2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint2.AutoSize = true;
            this.labelPoint2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint2.Location = new System.Drawing.Point(472, 101);
            this.labelPoint2.Name = "labelPoint2";
            this.labelPoint2.Size = new System.Drawing.Size(74, 24);
            this.labelPoint2.TabIndex = 12;
            this.labelPoint2.Text = "Точка 2";
            this.toolTipMain.SetToolTip(this.labelPoint2, "Левая верхняя точка");
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(675, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 24);
            this.label9.TabIndex = 21;
            this.label9.Text = "Y";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(561, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 20;
            this.label10.Text = "X";
            // 
            // numeric3PointY
            // 
            this.numeric3PointY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric3PointY.DecimalPlaces = 1;
            this.numeric3PointY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric3PointY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric3PointY.Location = new System.Drawing.Point(701, 135);
            this.numeric3PointY.Name = "numeric3PointY";
            this.numeric3PointY.Size = new System.Drawing.Size(83, 32);
            this.numeric3PointY.TabIndex = 19;
            this.numeric3PointY.Tag = "2Y";
            // 
            // numeric3PointX
            // 
            this.numeric3PointX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric3PointX.DecimalPlaces = 1;
            this.numeric3PointX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric3PointX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric3PointX.Location = new System.Drawing.Point(587, 135);
            this.numeric3PointX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric3PointX.Name = "numeric3PointX";
            this.numeric3PointX.Size = new System.Drawing.Size(83, 32);
            this.numeric3PointX.TabIndex = 18;
            this.numeric3PointX.Tag = "2X";
            // 
            // labelPoint3
            // 
            this.labelPoint3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint3.AutoSize = true;
            this.labelPoint3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint3.Location = new System.Drawing.Point(472, 139);
            this.labelPoint3.Name = "labelPoint3";
            this.labelPoint3.Size = new System.Drawing.Size(74, 24);
            this.labelPoint3.TabIndex = 17;
            this.labelPoint3.Text = "Точка 3";
            this.toolTipMain.SetToolTip(this.labelPoint3, "Правая верхняя точка");
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(675, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 26;
            this.label12.Text = "Y";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(561, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "X";
            // 
            // numeric4PointY
            // 
            this.numeric4PointY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric4PointY.DecimalPlaces = 1;
            this.numeric4PointY.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric4PointY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric4PointY.Location = new System.Drawing.Point(701, 173);
            this.numeric4PointY.Name = "numeric4PointY";
            this.numeric4PointY.Size = new System.Drawing.Size(83, 32);
            this.numeric4PointY.TabIndex = 24;
            this.numeric4PointY.Tag = "3Y";
            // 
            // numeric4PointX
            // 
            this.numeric4PointX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numeric4PointX.DecimalPlaces = 1;
            this.numeric4PointX.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numeric4PointX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeric4PointX.Location = new System.Drawing.Point(587, 173);
            this.numeric4PointX.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numeric4PointX.Name = "numeric4PointX";
            this.numeric4PointX.Size = new System.Drawing.Size(83, 32);
            this.numeric4PointX.TabIndex = 23;
            this.numeric4PointX.Tag = "3X";
            // 
            // labelPoint4
            // 
            this.labelPoint4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPoint4.AutoSize = true;
            this.labelPoint4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint4.Location = new System.Drawing.Point(472, 177);
            this.labelPoint4.Name = "labelPoint4";
            this.labelPoint4.Size = new System.Drawing.Size(74, 24);
            this.labelPoint4.TabIndex = 22;
            this.labelPoint4.Text = "Точка 4";
            this.toolTipMain.SetToolTip(this.labelPoint4, "Правая нижняя точка");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.numeric4PointY);
            this.Controls.Add(this.numeric4PointX);
            this.Controls.Add(this.labelPoint4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numeric3PointY);
            this.Controls.Add(this.numeric3PointX);
            this.Controls.Add(this.labelPoint3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numeric2PointY);
            this.Controls.Add(this.numeric2PointX);
            this.Controls.Add(this.labelPoint2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeric1PointY);
            this.Controls.Add(this.numeric1PointX);
            this.Controls.Add(this.labelPoint1);
            this.Controls.Add(this.radioButtonCreateMarker);
            this.Controls.Add(this.radioButtonChangeColor);
            this.Controls.Add(this.radioButtonShowDialog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gMapControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mining Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainFormIsClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1PointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric1PointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2PointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric2PointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric3PointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric3PointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric4PointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric4PointX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton buttonSettings;
        private System.Windows.Forms.RadioButton radioButtonShowDialog;
        private System.Windows.Forms.RadioButton radioButtonChangeColor;
        private System.Windows.Forms.RadioButton radioButtonCreateMarker;
        private System.Windows.Forms.Label labelPoint1;
        private System.Windows.Forms.NumericUpDown numeric1PointX;
        private System.Windows.Forms.NumericUpDown numeric1PointY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numeric2PointY;
        private System.Windows.Forms.NumericUpDown numeric2PointX;
        private System.Windows.Forms.Label labelPoint2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numeric3PointY;
        private System.Windows.Forms.NumericUpDown numeric3PointX;
        private System.Windows.Forms.Label labelPoint3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numeric4PointY;
        private System.Windows.Forms.NumericUpDown numeric4PointX;
        private System.Windows.Forms.Label labelPoint4;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

