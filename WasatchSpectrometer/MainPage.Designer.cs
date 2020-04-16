namespace WasatchSpectrometer
{
    partial class MainPage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRecordDark = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxXAxis = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBoxMeasureSetting = new System.Windows.Forms.GroupBox();
            this.groupBoxPreflash = new System.Windows.Forms.GroupBox();
            this.radioButtonPreflashOff = new System.Windows.Forms.RadioButton();
            this.numericUpDownPreflashTime = new System.Windows.Forms.NumericUpDown();
            this.radioButtonPreflashOn = new System.Windows.Forms.RadioButton();
            this.labelPreflash = new System.Windows.Forms.Label();
            this.numericUpDownBoxcarSmooth = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCircles = new System.Windows.Forms.NumericUpDown();
            this.groupBoxBackground = new System.Windows.Forms.GroupBox();
            this.radioButtonInSitu = new System.Windows.Forms.RadioButton();
            this.radioButtonSubtract = new System.Windows.Forms.RadioButton();
            this.labelBoxcarSmooth = new System.Windows.Forms.Label();
            this.labelCircles = new System.Windows.Forms.Label();
            this.groupBoxMeasureMode = new System.Windows.Forms.GroupBox();
            this.radioButtonAverage = new System.Windows.Forms.RadioButton();
            this.radioButtonSum = new System.Windows.Forms.RadioButton();
            this.groupBoxWorkMode = new System.Windows.Forms.GroupBox();
            this.comboBoxWorkMode = new System.Windows.Forms.ComboBox();
            this.numericUpDownIntegrationTime = new System.Windows.Forms.NumericUpDown();
            this.labelIntegrationTime = new System.Windows.Forms.Label();
            this.labelWorkMode = new System.Windows.Forms.Label();
            this.groupBoxLaser = new System.Windows.Forms.GroupBox();
            this.labelLaserPower = new System.Windows.Forms.Label();
            this.numericUpDownLaserPerc = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxLaserStatus = new System.Windows.Forms.PictureBox();
            this.btnLaser = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSpectrum = new System.Windows.Forms.TabPage();
            this.chartRawSpec = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageDark = new System.Windows.Forms.TabPage();
            this.chartDark = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageTemp = new System.Windows.Forms.TabPage();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageEEPROM = new System.Windows.Forms.TabPage();
            this.groupBoxBadPixel = new System.Windows.Forms.GroupBox();
            this.dataGridViewBadPixel = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPixelPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSpec = new System.Windows.Forms.ComboBox();
            this.backgroundWorkerIntegrate = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxMeasureSetting.SuspendLayout();
            this.groupBoxPreflash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreflashTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBoxcarSmooth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircles)).BeginInit();
            this.groupBoxBackground.SuspendLayout();
            this.groupBoxMeasureMode.SuspendLayout();
            this.groupBoxWorkMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntegrationTime)).BeginInit();
            this.groupBoxLaser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaserPerc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaserStatus)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPageSpectrum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRawSpec)).BeginInit();
            this.tabPageDark.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDark)).BeginInit();
            this.tabPageTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.tabPageEEPROM.SuspendLayout();
            this.groupBoxBadPixel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBadPixel)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(912, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "进度：";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRecordDark,
            this.toolStripMenuItemExit});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Silver;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem1.Text = "菜单";
            // 
            // toolStripMenuItemRecordDark
            // 
            this.toolStripMenuItemRecordDark.Name = "toolStripMenuItemRecordDark";
            this.toolStripMenuItemRecordDark.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItemRecordDark.Text = "背景光测量";
            this.toolStripMenuItemRecordDark.Click += new System.EventHandler(this.toolStripMenuItemRecordDark_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItemExit.Text = "退出";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem2.Text = "帮助";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxXAxis);
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxMeasureSetting);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxWorkMode);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxLaser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
            this.splitContainer1.Size = new System.Drawing.Size(912, 480);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "X轴：";
            // 
            // comboBoxXAxis
            // 
            this.comboBoxXAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxXAxis.FormattingEnabled = true;
            this.comboBoxXAxis.Items.AddRange(new object[] {
            "Pixel",
            "Wavelength",
            "RamanShift"});
            this.comboBoxXAxis.Location = new System.Drawing.Point(49, 38);
            this.comboBoxXAxis.Name = "comboBoxXAxis";
            this.comboBoxXAxis.Size = new System.Drawing.Size(205, 20);
            this.comboBoxXAxis.TabIndex = 7;
            this.comboBoxXAxis.SelectedIndexChanged += new System.EventHandler(this.comboBoxXAxis_SelectedIndexChanged);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(137, 9);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(6, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(117, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBoxMeasureSetting
            // 
            this.groupBoxMeasureSetting.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMeasureSetting.Controls.Add(this.groupBoxPreflash);
            this.groupBoxMeasureSetting.Controls.Add(this.numericUpDownBoxcarSmooth);
            this.groupBoxMeasureSetting.Controls.Add(this.numericUpDownCircles);
            this.groupBoxMeasureSetting.Controls.Add(this.groupBoxBackground);
            this.groupBoxMeasureSetting.Controls.Add(this.labelBoxcarSmooth);
            this.groupBoxMeasureSetting.Controls.Add(this.labelCircles);
            this.groupBoxMeasureSetting.Controls.Add(this.groupBoxMeasureMode);
            this.groupBoxMeasureSetting.Location = new System.Drawing.Point(6, 218);
            this.groupBoxMeasureSetting.Name = "groupBoxMeasureSetting";
            this.groupBoxMeasureSetting.Size = new System.Drawing.Size(248, 246);
            this.groupBoxMeasureSetting.TabIndex = 5;
            this.groupBoxMeasureSetting.TabStop = false;
            this.groupBoxMeasureSetting.Text = "测量设置";
            // 
            // groupBoxPreflash
            // 
            this.groupBoxPreflash.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxPreflash.Controls.Add(this.radioButtonPreflashOff);
            this.groupBoxPreflash.Controls.Add(this.numericUpDownPreflashTime);
            this.groupBoxPreflash.Controls.Add(this.radioButtonPreflashOn);
            this.groupBoxPreflash.Controls.Add(this.labelPreflash);
            this.groupBoxPreflash.Location = new System.Drawing.Point(8, 116);
            this.groupBoxPreflash.Name = "groupBoxPreflash";
            this.groupBoxPreflash.Size = new System.Drawing.Size(234, 70);
            this.groupBoxPreflash.TabIndex = 1;
            this.groupBoxPreflash.TabStop = false;
            this.groupBoxPreflash.Text = "预照模式";
            // 
            // radioButtonPreflashOff
            // 
            this.radioButtonPreflashOff.AutoSize = true;
            this.radioButtonPreflashOff.Location = new System.Drawing.Point(159, 20);
            this.radioButtonPreflashOff.Name = "radioButtonPreflashOff";
            this.radioButtonPreflashOff.Size = new System.Drawing.Size(35, 16);
            this.radioButtonPreflashOff.TabIndex = 1;
            this.radioButtonPreflashOff.TabStop = true;
            this.radioButtonPreflashOff.Text = "关";
            this.radioButtonPreflashOff.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPreflashTime
            // 
            this.numericUpDownPreflashTime.Location = new System.Drawing.Point(104, 43);
            this.numericUpDownPreflashTime.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownPreflashTime.Name = "numericUpDownPreflashTime";
            this.numericUpDownPreflashTime.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownPreflashTime.TabIndex = 1;
            this.numericUpDownPreflashTime.ValueChanged += new System.EventHandler(this.numericUpDownBoxcarSmooth_ValueChanged);
            // 
            // radioButtonPreflashOn
            // 
            this.radioButtonPreflashOn.AutoSize = true;
            this.radioButtonPreflashOn.Location = new System.Drawing.Point(11, 20);
            this.radioButtonPreflashOn.Name = "radioButtonPreflashOn";
            this.radioButtonPreflashOn.Size = new System.Drawing.Size(35, 16);
            this.radioButtonPreflashOn.TabIndex = 1;
            this.radioButtonPreflashOn.TabStop = true;
            this.radioButtonPreflashOn.Text = "开";
            this.radioButtonPreflashOn.UseVisualStyleBackColor = true;
            this.radioButtonPreflashOn.CheckedChanged += new System.EventHandler(this.radioButtonPreflashOn_CheckedChanged);
            // 
            // labelPreflash
            // 
            this.labelPreflash.AutoSize = true;
            this.labelPreflash.Location = new System.Drawing.Point(9, 45);
            this.labelPreflash.Name = "labelPreflash";
            this.labelPreflash.Size = new System.Drawing.Size(83, 12);
            this.labelPreflash.TabIndex = 0;
            this.labelPreflash.Text = "预照时间(S)：";
            // 
            // numericUpDownBoxcarSmooth
            // 
            this.numericUpDownBoxcarSmooth.Location = new System.Drawing.Point(112, 218);
            this.numericUpDownBoxcarSmooth.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownBoxcarSmooth.Name = "numericUpDownBoxcarSmooth";
            this.numericUpDownBoxcarSmooth.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownBoxcarSmooth.TabIndex = 1;
            this.numericUpDownBoxcarSmooth.ValueChanged += new System.EventHandler(this.numericUpDownBoxcarSmooth_ValueChanged);
            // 
            // numericUpDownCircles
            // 
            this.numericUpDownCircles.Location = new System.Drawing.Point(112, 192);
            this.numericUpDownCircles.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCircles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCircles.Name = "numericUpDownCircles";
            this.numericUpDownCircles.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownCircles.TabIndex = 1;
            this.numericUpDownCircles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBoxBackground
            // 
            this.groupBoxBackground.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxBackground.Controls.Add(this.radioButtonInSitu);
            this.groupBoxBackground.Controls.Add(this.radioButtonSubtract);
            this.groupBoxBackground.Location = new System.Drawing.Point(8, 68);
            this.groupBoxBackground.Name = "groupBoxBackground";
            this.groupBoxBackground.Size = new System.Drawing.Size(234, 42);
            this.groupBoxBackground.TabIndex = 1;
            this.groupBoxBackground.TabStop = false;
            this.groupBoxBackground.Text = "背景测量";
            // 
            // radioButtonInSitu
            // 
            this.radioButtonInSitu.AutoSize = true;
            this.radioButtonInSitu.Location = new System.Drawing.Point(159, 20);
            this.radioButtonInSitu.Name = "radioButtonInSitu";
            this.radioButtonInSitu.Size = new System.Drawing.Size(71, 16);
            this.radioButtonInSitu.TabIndex = 1;
            this.radioButtonInSitu.TabStop = true;
            this.radioButtonInSitu.Text = "原味测量";
            this.radioButtonInSitu.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtract
            // 
            this.radioButtonSubtract.AutoSize = true;
            this.radioButtonSubtract.Location = new System.Drawing.Point(11, 20);
            this.radioButtonSubtract.Name = "radioButtonSubtract";
            this.radioButtonSubtract.Size = new System.Drawing.Size(71, 16);
            this.radioButtonSubtract.TabIndex = 1;
            this.radioButtonSubtract.TabStop = true;
            this.radioButtonSubtract.Text = "扣除背景";
            this.radioButtonSubtract.UseVisualStyleBackColor = true;
            // 
            // labelBoxcarSmooth
            // 
            this.labelBoxcarSmooth.AutoSize = true;
            this.labelBoxcarSmooth.Location = new System.Drawing.Point(23, 220);
            this.labelBoxcarSmooth.Name = "labelBoxcarSmooth";
            this.labelBoxcarSmooth.Size = new System.Drawing.Size(77, 12);
            this.labelBoxcarSmooth.TabIndex = 0;
            this.labelBoxcarSmooth.Text = "Boxcar平滑：";
            // 
            // labelCircles
            // 
            this.labelCircles.AutoSize = true;
            this.labelCircles.Location = new System.Drawing.Point(35, 194);
            this.labelCircles.Name = "labelCircles";
            this.labelCircles.Size = new System.Drawing.Size(65, 12);
            this.labelCircles.TabIndex = 0;
            this.labelCircles.Text = "循环次数：";
            // 
            // groupBoxMeasureMode
            // 
            this.groupBoxMeasureMode.BackColor = System.Drawing.SystemColors.Control;
            this.groupBoxMeasureMode.Controls.Add(this.radioButtonAverage);
            this.groupBoxMeasureMode.Controls.Add(this.radioButtonSum);
            this.groupBoxMeasureMode.Location = new System.Drawing.Point(8, 20);
            this.groupBoxMeasureMode.Name = "groupBoxMeasureMode";
            this.groupBoxMeasureMode.Size = new System.Drawing.Size(234, 42);
            this.groupBoxMeasureMode.TabIndex = 1;
            this.groupBoxMeasureMode.TabStop = false;
            this.groupBoxMeasureMode.Text = "测量模式";
            // 
            // radioButtonAverage
            // 
            this.radioButtonAverage.AutoSize = true;
            this.radioButtonAverage.Location = new System.Drawing.Point(159, 20);
            this.radioButtonAverage.Name = "radioButtonAverage";
            this.radioButtonAverage.Size = new System.Drawing.Size(47, 16);
            this.radioButtonAverage.TabIndex = 1;
            this.radioButtonAverage.TabStop = true;
            this.radioButtonAverage.Text = "平均";
            this.radioButtonAverage.UseVisualStyleBackColor = true;
            // 
            // radioButtonSum
            // 
            this.radioButtonSum.AutoSize = true;
            this.radioButtonSum.Location = new System.Drawing.Point(11, 20);
            this.radioButtonSum.Name = "radioButtonSum";
            this.radioButtonSum.Size = new System.Drawing.Size(47, 16);
            this.radioButtonSum.TabIndex = 1;
            this.radioButtonSum.TabStop = true;
            this.radioButtonSum.Text = "累计";
            this.radioButtonSum.UseVisualStyleBackColor = true;
            // 
            // groupBoxWorkMode
            // 
            this.groupBoxWorkMode.Controls.Add(this.comboBoxWorkMode);
            this.groupBoxWorkMode.Controls.Add(this.numericUpDownIntegrationTime);
            this.groupBoxWorkMode.Controls.Add(this.labelIntegrationTime);
            this.groupBoxWorkMode.Controls.Add(this.labelWorkMode);
            this.groupBoxWorkMode.Location = new System.Drawing.Point(6, 134);
            this.groupBoxWorkMode.Name = "groupBoxWorkMode";
            this.groupBoxWorkMode.Size = new System.Drawing.Size(248, 74);
            this.groupBoxWorkMode.TabIndex = 5;
            this.groupBoxWorkMode.TabStop = false;
            this.groupBoxWorkMode.Text = "工作模式";
            // 
            // comboBoxWorkMode
            // 
            this.comboBoxWorkMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkMode.FormattingEnabled = true;
            this.comboBoxWorkMode.Items.AddRange(new object[] {
            "连续监测",
            "单次测量"});
            this.comboBoxWorkMode.Location = new System.Drawing.Point(112, 18);
            this.comboBoxWorkMode.Name = "comboBoxWorkMode";
            this.comboBoxWorkMode.Size = new System.Drawing.Size(120, 20);
            this.comboBoxWorkMode.TabIndex = 1;
            this.comboBoxWorkMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkMode_SelectedIndexChanged);
            // 
            // numericUpDownIntegrationTime
            // 
            this.numericUpDownIntegrationTime.Location = new System.Drawing.Point(112, 48);
            this.numericUpDownIntegrationTime.Name = "numericUpDownIntegrationTime";
            this.numericUpDownIntegrationTime.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownIntegrationTime.TabIndex = 1;
            this.numericUpDownIntegrationTime.ValueChanged += new System.EventHandler(this.numericUpDownIntegrationTime_ValueChanged);
            // 
            // labelIntegrationTime
            // 
            this.labelIntegrationTime.AutoSize = true;
            this.labelIntegrationTime.Location = new System.Drawing.Point(6, 50);
            this.labelIntegrationTime.Name = "labelIntegrationTime";
            this.labelIntegrationTime.Size = new System.Drawing.Size(89, 12);
            this.labelIntegrationTime.TabIndex = 0;
            this.labelIntegrationTime.Text = "积分时间(MS)：";
            // 
            // labelWorkMode
            // 
            this.labelWorkMode.AutoSize = true;
            this.labelWorkMode.Location = new System.Drawing.Point(30, 21);
            this.labelWorkMode.Name = "labelWorkMode";
            this.labelWorkMode.Size = new System.Drawing.Size(65, 12);
            this.labelWorkMode.TabIndex = 0;
            this.labelWorkMode.Text = "工作模式：";
            // 
            // groupBoxLaser
            // 
            this.groupBoxLaser.Controls.Add(this.labelLaserPower);
            this.groupBoxLaser.Controls.Add(this.numericUpDownLaserPerc);
            this.groupBoxLaser.Controls.Add(this.pictureBoxLaserStatus);
            this.groupBoxLaser.Controls.Add(this.btnLaser);
            this.groupBoxLaser.Location = new System.Drawing.Point(6, 71);
            this.groupBoxLaser.Name = "groupBoxLaser";
            this.groupBoxLaser.Size = new System.Drawing.Size(248, 53);
            this.groupBoxLaser.TabIndex = 4;
            this.groupBoxLaser.TabStop = false;
            this.groupBoxLaser.Text = "激光";
            // 
            // labelLaserPower
            // 
            this.labelLaserPower.AutoSize = true;
            this.labelLaserPower.Location = new System.Drawing.Point(41, 26);
            this.labelLaserPower.Name = "labelLaserPower";
            this.labelLaserPower.Size = new System.Drawing.Size(53, 12);
            this.labelLaserPower.TabIndex = 7;
            this.labelLaserPower.Text = "功率(%):";
            // 
            // numericUpDownLaserPerc
            // 
            this.numericUpDownLaserPerc.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownLaserPerc.Location = new System.Drawing.Point(102, 21);
            this.numericUpDownLaserPerc.Name = "numericUpDownLaserPerc";
            this.numericUpDownLaserPerc.Size = new System.Drawing.Size(59, 23);
            this.numericUpDownLaserPerc.TabIndex = 6;
            this.numericUpDownLaserPerc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownLaserPerc.ValueChanged += new System.EventHandler(this.numericUpDownLaserPerc_ValueChanged);
            // 
            // pictureBoxLaserStatus
            // 
            this.pictureBoxLaserStatus.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxLaserStatus.Name = "pictureBoxLaserStatus";
            this.pictureBoxLaserStatus.Size = new System.Drawing.Size(29, 26);
            this.pictureBoxLaserStatus.TabIndex = 5;
            this.pictureBoxLaserStatus.TabStop = false;
            // 
            // btnLaser
            // 
            this.btnLaser.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLaser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaser.Location = new System.Drawing.Point(167, 21);
            this.btnLaser.Name = "btnLaser";
            this.btnLaser.Size = new System.Drawing.Size(75, 23);
            this.btnLaser.TabIndex = 1;
            this.btnLaser.Text = "打开";
            this.btnLaser.UseVisualStyleBackColor = false;
            this.btnLaser.Click += new System.EventHandler(this.btnLaser_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSpectrum);
            this.tabControl.Controls.Add(this.tabPageDark);
            this.tabControl.Controls.Add(this.tabPageTemp);
            this.tabControl.Controls.Add(this.tabPageEEPROM);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(643, 480);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSpectrum
            // 
            this.tabPageSpectrum.Controls.Add(this.chartRawSpec);
            this.tabPageSpectrum.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpectrum.Name = "tabPageSpectrum";
            this.tabPageSpectrum.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpectrum.Size = new System.Drawing.Size(635, 454);
            this.tabPageSpectrum.TabIndex = 0;
            this.tabPageSpectrum.Text = "光谱";
            this.tabPageSpectrum.UseVisualStyleBackColor = true;
            // 
            // chartRawSpec
            // 
            this.chartRawSpec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRawSpec.Location = new System.Drawing.Point(3, 3);
            this.chartRawSpec.Name = "chartRawSpec";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chartRawSpec.Series.Add(series1);
            this.chartRawSpec.Size = new System.Drawing.Size(629, 448);
            this.chartRawSpec.TabIndex = 0;
            this.chartRawSpec.Text = "chart1";
            // 
            // tabPageDark
            // 
            this.tabPageDark.Controls.Add(this.chartDark);
            this.tabPageDark.Location = new System.Drawing.Point(4, 22);
            this.tabPageDark.Name = "tabPageDark";
            this.tabPageDark.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDark.Size = new System.Drawing.Size(635, 454);
            this.tabPageDark.TabIndex = 1;
            this.tabPageDark.Text = "背景";
            this.tabPageDark.UseVisualStyleBackColor = true;
            // 
            // chartDark
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDark.ChartAreas.Add(chartArea1);
            this.chartDark.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDark.Legends.Add(legend1);
            this.chartDark.Location = new System.Drawing.Point(3, 3);
            this.chartDark.Name = "chartDark";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartDark.Series.Add(series2);
            this.chartDark.Size = new System.Drawing.Size(629, 448);
            this.chartDark.TabIndex = 0;
            this.chartDark.Text = "chart1";
            // 
            // tabPageTemp
            // 
            this.tabPageTemp.Controls.Add(this.chartTemperature);
            this.tabPageTemp.Location = new System.Drawing.Point(4, 22);
            this.tabPageTemp.Name = "tabPageTemp";
            this.tabPageTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemp.Size = new System.Drawing.Size(635, 454);
            this.tabPageTemp.TabIndex = 2;
            this.tabPageTemp.Text = "温度监测";
            this.tabPageTemp.UseVisualStyleBackColor = true;
            // 
            // chartTemperature
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTemperature.ChartAreas.Add(chartArea2);
            this.chartTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend2);
            this.chartTemperature.Location = new System.Drawing.Point(3, 3);
            this.chartTemperature.Name = "chartTemperature";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartTemperature.Series.Add(series3);
            this.chartTemperature.Size = new System.Drawing.Size(629, 448);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "chart2";
            // 
            // tabPageEEPROM
            // 
            this.tabPageEEPROM.Controls.Add(this.groupBoxBadPixel);
            this.tabPageEEPROM.Controls.Add(this.label1);
            this.tabPageEEPROM.Controls.Add(this.comboBoxSpec);
            this.tabPageEEPROM.Location = new System.Drawing.Point(4, 22);
            this.tabPageEEPROM.Name = "tabPageEEPROM";
            this.tabPageEEPROM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEEPROM.Size = new System.Drawing.Size(635, 454);
            this.tabPageEEPROM.TabIndex = 4;
            this.tabPageEEPROM.Text = "光谱仪EEPROM";
            this.tabPageEEPROM.UseVisualStyleBackColor = true;
            // 
            // groupBoxBadPixel
            // 
            this.groupBoxBadPixel.Controls.Add(this.dataGridViewBadPixel);
            this.groupBoxBadPixel.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBadPixel.Name = "groupBoxBadPixel";
            this.groupBoxBadPixel.Size = new System.Drawing.Size(233, 131);
            this.groupBoxBadPixel.TabIndex = 1;
            this.groupBoxBadPixel.TabStop = false;
            this.groupBoxBadPixel.Text = "像素坏点";
            // 
            // dataGridViewBadPixel
            // 
            this.dataGridViewBadPixel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBadPixel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnPixelPosition});
            this.dataGridViewBadPixel.Location = new System.Drawing.Point(6, 15);
            this.dataGridViewBadPixel.Name = "dataGridViewBadPixel";
            this.dataGridViewBadPixel.RowTemplate.Height = 23;
            this.dataGridViewBadPixel.Size = new System.Drawing.Size(221, 109);
            this.dataGridViewBadPixel.TabIndex = 0;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.HeaderText = "序号";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.Width = 40;
            // 
            // ColumnPixelPosition
            // 
            this.ColumnPixelPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnPixelPosition.HeaderText = "像素位置";
            this.ColumnPixelPosition.Name = "ColumnPixelPosition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "光谱仪型号：";
            // 
            // comboBoxSpec
            // 
            this.comboBoxSpec.FormattingEnabled = true;
            this.comboBoxSpec.Location = new System.Drawing.Point(89, 151);
            this.comboBoxSpec.Name = "comboBoxSpec";
            this.comboBoxSpec.Size = new System.Drawing.Size(144, 20);
            this.comboBoxSpec.TabIndex = 2;
            // 
            // backgroundWorkerIntegrate
            // 
            this.backgroundWorkerIntegrate.WorkerReportsProgress = true;
            this.backgroundWorkerIntegrate.WorkerSupportsCancellation = true;
            this.backgroundWorkerIntegrate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerIntegrate_DoWork);
            this.backgroundWorkerIntegrate.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerIntegrate_ProgressChanged);
            this.backgroundWorkerIntegrate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerIntegrate_RunWorkerCompleted);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 527);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "光谱仪-浙江澍源智能技术有限公司";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxMeasureSetting.ResumeLayout(false);
            this.groupBoxMeasureSetting.PerformLayout();
            this.groupBoxPreflash.ResumeLayout(false);
            this.groupBoxPreflash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPreflashTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBoxcarSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCircles)).EndInit();
            this.groupBoxBackground.ResumeLayout(false);
            this.groupBoxBackground.PerformLayout();
            this.groupBoxMeasureMode.ResumeLayout(false);
            this.groupBoxMeasureMode.PerformLayout();
            this.groupBoxWorkMode.ResumeLayout(false);
            this.groupBoxWorkMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntegrationTime)).EndInit();
            this.groupBoxLaser.ResumeLayout(false);
            this.groupBoxLaser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLaserPerc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLaserStatus)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPageSpectrum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRawSpec)).EndInit();
            this.tabPageDark.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDark)).EndInit();
            this.tabPageTemp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.tabPageEEPROM.ResumeLayout(false);
            this.tabPageEEPROM.PerformLayout();
            this.groupBoxBadPixel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBadPixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSpectrum;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRawSpec;
        private System.Windows.Forms.TabPage tabPageDark;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDark;
        private System.Windows.Forms.TabPage tabPageTemp;
        private System.Windows.Forms.GroupBox groupBoxLaser;
        private System.Windows.Forms.ComboBox comboBoxSpec;
        private System.Windows.Forms.Button btnLaser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.PictureBox pictureBoxLaserStatus;
        private System.Windows.Forms.Label labelLaserPower;
        private System.Windows.Forms.NumericUpDown numericUpDownLaserPerc;
        private System.Windows.Forms.GroupBox groupBoxMeasureSetting;
        private System.Windows.Forms.GroupBox groupBoxMeasureMode;
        private System.Windows.Forms.RadioButton radioButtonAverage;
        private System.Windows.Forms.RadioButton radioButtonSum;
        private System.Windows.Forms.GroupBox groupBoxWorkMode;
        private System.Windows.Forms.ComboBox comboBoxWorkMode;
        private System.Windows.Forms.NumericUpDown numericUpDownIntegrationTime;
        private System.Windows.Forms.Label labelIntegrationTime;
        private System.Windows.Forms.Label labelWorkMode;
        private System.Windows.Forms.TabPage tabPageEEPROM;
        private System.Windows.Forms.GroupBox groupBoxBadPixel;
        private System.Windows.Forms.DataGridView dataGridViewBadPixel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPixelPosition;
        private System.ComponentModel.BackgroundWorker backgroundWorkerIntegrate;
        private System.Windows.Forms.GroupBox groupBoxPreflash;
        private System.Windows.Forms.RadioButton radioButtonPreflashOff;
        private System.Windows.Forms.RadioButton radioButtonPreflashOn;
        private System.Windows.Forms.NumericUpDown numericUpDownBoxcarSmooth;
        private System.Windows.Forms.NumericUpDown numericUpDownCircles;
        private System.Windows.Forms.GroupBox groupBoxBackground;
        private System.Windows.Forms.RadioButton radioButtonInSitu;
        private System.Windows.Forms.RadioButton radioButtonSubtract;
        private System.Windows.Forms.Label labelBoxcarSmooth;
        private System.Windows.Forms.Label labelCircles;
        private System.Windows.Forms.NumericUpDown numericUpDownPreflashTime;
        private System.Windows.Forms.Label labelPreflash;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRecordDark;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxXAxis;
    }
}

