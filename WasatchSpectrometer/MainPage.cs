using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WasatchNET;
using LibUsbDotNet;
using LibUsbDotNet.Main;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
//待解决问题
//1.自动刷新光谱过程有点卡顿，需要更改
namespace WasatchSpectrometer
{
    public partial class MainPage : Form
    {
        bool laserStatus = false;
        bool tecStatus = false;
        uint integrationTimeMS;
        uint maxIntegrationTimeMS;
        uint minIntegrationTimeMS;
        float excitationWavelengthNM;//光谱仪内置激光器的激发波长
        float centralWavelength;//序列号中的中心波长，此波长不代表光谱仪携带光源
        double[] wavelength;
        double[] pixels;
        double[] wavenum;
        double[] ramanShift;
        string serialNumber;
        List<double[]> data ;
        double[] rawSpecData;
        uint pixelHoriNum;
        uint pixelVertNum;
        private readonly object Hoster="";
        int highestPercentageReached;
        Spectrometer s;
        DriverClass driverClass = new DriverClass();
        EEPROM eEPROM;
        delegate void DeleFunc();//无参委托，用于updateGraph
        public MainPage()
        {
            InitializeComponent();
            InitSpectrometer();
            comboBoxXAxis.SelectedIndex = 2;
            pixels = new double[pixelHoriNum];
            for (int i = 0; i < pixelHoriNum; i++)
            {
                pixels[i] = i;
            }
            InitializeSpec(chartRawSpec);
            InitializeSpec(chartDark);
            InitializeSpec(chartTemperature);
            comboBoxWorkMode.SelectedItem = "单次测量";
        }

        /// <summary>
        /// 初始化图表
        /// </summary>
        /// <param name="chart"></param>
        private void InitializeSpec(Chart chart)
        {
            if (chart.Name != "chartTemperature")
            {
                chart.ChartAreas.Clear();
                ChartArea chartArea = new ChartArea();
                Series series = new Series();
                series.IsVisibleInLegend = false;
                series.ChartType = SeriesChartType.Line;
                chart.ChartAreas.Add(chartArea);
                
                chart.ChartAreas[0].AxisY.IntervalAutoMode = IntervalAutoMode.FixedCount;
                chart.ChartAreas[0].AxisX.Minimum = (int)ramanShift.Min();
                chart.ChartAreas[0].AxisX.Maximum = (int)ramanShift.Max();
                this.chartRawSpec.ChartAreas[0].AxisY.TitleFont = this.chartRawSpec.ChartAreas[0].AxisX.TitleFont = new Font("Arial Black", 10, FontStyle.Regular);
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.Maximum = 65535;
                chart.ChartAreas[0].AxisX.Title = "RamanShift(cm-1)";
                chart.ChartAreas[0].AxisY.Title = "Intensity(a.u)";
            }
            else//初始化温度监测图
            {
                chart.ChartAreas.Clear();
                ChartArea chartArea = new ChartArea();
                chart.ChartAreas.Add(chartArea);
                chart.ChartAreas[0].AxisX.Title = "point";
                chart.ChartAreas[0].AxisY.Title = "CCD Temperature";
                chart.ChartAreas[0].AxisY2.Title = "Laser Temperature";
                chart.ChartAreas[0].AxisX.Minimum = 0;
                chart.ChartAreas[0].AxisX.Maximum = 0;
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.Maximum = 100;
                chart.ChartAreas[0].AxisY2.Minimum = 0;
                chart.ChartAreas[0].AxisY.Maximum = 100;

            }
            chart.ChartAreas[0].RecalculateAxesScale();
            //chart.Show();

            //chart.Invalidate();
            //chart.Update();
        }

        /// <summary>
        /// 初始化光谱仪参数
        /// </summary>
        private void InitSpectrometer()
        {
            s=driverClass.SelectSpectrometer(Driver.getInstance());//最后一个spectrometer
            this.comboBoxSpec.Text = s.model+" "+s.serialNumber;
            SpectrometerClassRead(s);
            EEPROMClassRead(eEPROM);
        }

        #region 光谱仪参数读取
        private void SpectrometerClassRead(Spectrometer s)
        {
            tecStatus = s.detectorTECEnabled;
            double detectorTECSetpointDegC = s.detectorTECSetpointDegC;
            if (!s.hasLaser)
            {
                laserStatus = false;
            }     
            else
                excitationWavelengthNM = s.excitationWavelengthNM;
            integrationTimeMS = s.integrationTimeMS;
            eEPROM = s.eeprom;
        }
        private void EEPROMClassRead(EEPROM e)
        {
            pixelHoriNum = e.activePixelsHoriz;
            pixelVertNum = e.activePixelsVert;
            for (int i = 0; i < e.badPixels.Length; i++)
            {
                if (e.badPixels[i] >= 0)
                {
                    dataGridViewBadPixel.Rows[i].Cells[0].Value = i;
                    dataGridViewBadPixel.Rows[i].Cells[1].Value = e.badPixels[i];
                }                   
            }
            wavelength = wavenum=ramanShift=new double[pixelHoriNum];
            wavelength = s.wavelengths;
            String[] elements = (s.model).Split('-');
            foreach (string item in elements)
            {
                if (float.TryParse(item, out centralWavelength))
                    break;
            }
            wavenum = Util.wavelengthsToWavenumbers(centralWavelength,wavelength);
            for (int i = 0; i < wavelength.Length; i++)
            {
                ramanShift[i] = (1 / centralWavelength - 1 / wavelength[i]) * 10000000;
            }
            serialNumber = e.serialNumber;
            maxIntegrationTimeMS = e.maxIntegrationTimeMS;
            numericUpDownIntegrationTime.Maximum = maxIntegrationTimeMS;
            minIntegrationTimeMS = e.minIntegrationTimeMS;
            numericUpDownIntegrationTime.Minimum = minIntegrationTimeMS;
            numericUpDownIntegrationTime.Value = minIntegrationTimeMS;
            IfHasLaser(s.hasLaser);
        }
        #endregion
        
        #region 激光控制
        /// <summary>
        /// 判断是否有激光器，如果没有屏蔽激光器相关功能
        /// </summary>
        /// <param name="existLaser"></param>
        private void IfHasLaser(bool existLaser)
        {
            if(existLaser)//有激光器
            {
                groupBoxLaser.Enabled = true;
                groupBoxLaser.Visible = true;
            }
            else
            {
                groupBoxLaser.Enabled = false;
                groupBoxLaser.Visible = false;
            }
        }      
        private void btnLaser_Click(object sender, EventArgs e)
        {
            if(s.hasLaser)
            {
                if(laserStatus)//激光器已经开启，执行if完成关闭
                {
                    numericUpDownLaserPerc.Value = 0;
                }
                else//激光器已经关闭，执行else完成开启
                {
                    numericUpDownLaserPerc.Value = 2;
                }
            }
            else
                return;
        }
        private void numericUpDownLaserPerc_ValueChanged(object sender, EventArgs e)
        {
            if(s.hasLaser)
            {
                if (numericUpDownLaserPerc.Value != 0)//激光状态开
                {
                    s.laserEnabled = true;
                    if (numericUpDownLaserPerc.Value == 100)
                        s.laserModulationEnabled = false;
                    else
                        s.laserModulationEnabled = true;
                    laserStatus = s.setLaserPowerPercentage((float)(numericUpDownLaserPerc.Value / 100));
                    btnLaser.Text = "关闭";
                    btnLaser.BackColor = Color.DeepPink;
                    laserStatus = true;//激光器状态
                }
                else//激光状态关
                {
                    s.laserEnabled = false;
                    laserStatus = true;
                    btnLaser.Text = "打开";
                    btnLaser.BackColor = Color.CornflowerBlue;
                    laserStatus = false;//激光器状态
                }
            }
            else
                return;
        }
        #endregion

        #region 执行积分
        private void btnStart_Click(object sender, EventArgs e)
        {
            ButtonStatus(this.btnStart.Text);
            btnStart.Text = "正在测量中...";
            highestPercentageReached = 0;
            this.toolStripProgressBar1.Value = 0;
            //working
            data = new List<double[]>(); 
            lock(s)
            {
                backgroundWorkerIntegrate.RunWorkerAsync((int)(numericUpDownCircles.Value));
            }
            //end            
        }
        
        /// <summary>
        /// 积分过程，积分会按照顺序经过三个选择方案，分别预照，背景测量和测量结果选择。
        /// </summary>
        /// <param name="circle">测量次数</param>
        /// <param name="worker">backgroundworker的句柄</param>
        /// <param name="e">backgroundworker事件</param>
        /// <returns>将不同次数测量的结果数组依次存入到List中</returns>
        private List<double[]> IntegrateSpectrum(int circle,BackgroundWorker worker,DoWorkEventArgs e)
        {
            for (int i = 0; i < circle; i++)
            {
                if (worker.CancellationPending)
                {
                    if(this.InvokeRequired)
                        this.Invoke(new MethodInvoker(() => { this.toolStripProgressBar1.Value = 0; }));
                    else
                        this.toolStripProgressBar1.Value = 0;
                    e.Cancel = true;
                    return null;
                }
                data.Add(IsBackgroundSubtracted(s, i));
                int percentComplete = (int)((double)(i+1) / (double)circle * 100);
                if (percentComplete > highestPercentageReached)
                {
                    highestPercentageReached = percentComplete;
                    worker.ReportProgress(percentComplete);
                }
            }
            return data;          
        }

        /// <summary>
        /// <see cref=" Spectrometer"/>
        /// 当扣除背景选项选中后，扣除背景。测量过程先测背景，后测原始光谱。
        /// </summary>
        /// <param name="spectrometer">Spectrometer handle</param>
        /// <param name="currentCircle">当前循环(Circles)次数</param>
        /// <returns>本次测量的数组，长度等于CCD横向(Horizontal)长度</returns>
        private double[] IsBackgroundSubtracted(Spectrometer spectrometer,int currentCircle)
        {
            double[] tempdark = new double[pixelHoriNum];
            double[] tempSpec = new double[pixelHoriNum];
            if (radioButtonSubtract.Checked&&radioButtonInSitu.Checked==false)//扣除背景
            {
                spectrometer.laserEnabled = false;
                System.Threading.Monitor.Enter(this);
                tempdark = spectrometer.getSpectrum();//背景光测量
                System.Threading.Monitor.Exit(this);
                spectrometer.laserEnabled = true;
                numericUpDownLaserPerc.Value = numericUpDownLaserPerc.Value;
                if(radioButtonPreflashOn.Checked&&radioButtonPreflashOff.Checked==false)
                    IsPreflash(currentCircle);
                System.Threading.Monitor.Enter(this);
                tempSpec = spectrometer.getSpectrum();
                System.Threading.Monitor.Exit(this);
                for (int i = 0; i < pixelHoriNum; i++)
                {
                    tempSpec[i] -= tempdark[i];
                }
            }
            else//不扣除背景
            {
                spectrometer.laserEnabled = true;
                numericUpDownLaserPerc.Value = numericUpDownLaserPerc.Value;
                if (radioButtonPreflashOn.Checked && radioButtonPreflashOff.Checked == false)
                    IsPreflash(currentCircle);
                tempSpec = spectrometer.getSpectrum();
            }
            return tempSpec;
        }

        /// <summary>
        /// 测量方式选择，当选择平均时，会在测量结束后根据积分次数求均值；当选择累加，会在测量结束后根据积分次数求和。
        /// </summary>
        /// <param name="times">测量次数</param>
        /// <returns>返回测量最终的平均值或求和值</returns>
        private double[] MearsureResultSelect(int times)
        {
            double[] temprawSpecData = new double[pixelHoriNum];
            if (data == null)
                return null;
            if (radioButtonAverage.Checked&&radioButtonSum.Checked==false)//选中平均
            {
                for (int i = 0; i < pixelHoriNum; i++)
                {
                    foreach (double[] item in data)
                    {
                        temprawSpecData[i] += item[i];
                    }
                    temprawSpecData[i] /= times;
                }
            }
            else//求和
            {
                for (int i = 0; i < pixelHoriNum; i++)
                {
                    foreach (double[] item in data)
                    {
                        temprawSpecData[i] += item[i];
                    }
                }
            }
            return temprawSpecData;
        }
       
        /// <summary>
        /// 是否进行预照，预照只进行一次，预照发生在循环次数(Circle)==0时候，有且只有首次积分过程之前可能出现预照，预照单位为S
        /// </summary>
        /// <param name="currentIndex">当前循环次数</param>
        private void IsPreflash(int currentIndex)
        {
            if (numericUpDownPreflashTime.Value != 0)
            {
                if (currentIndex == 0)
                    Thread.Sleep((int)(numericUpDownPreflashTime.Value) * 1000);
                else
                    return;
            }
            else
                return;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.backgroundWorkerIntegrate.CancelAsync();
            ButtonStatus(this.btnStart.Text);
            btnStart.Text = "开始";
        }
        private void backgroundWorkerIntegrate_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = IntegrateSpectrum((int)e.Argument, this.backgroundWorkerIntegrate, e);
        }
        private void backgroundWorkerIntegrate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
        }
        private void backgroundWorkerIntegrate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Error!=null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if(e.Cancelled)
            {
                ButtonStatus("");
            }
            else
            {
                rawSpecData=MearsureResultSelect((int)(this.numericUpDownCircles.Value));
                if(rawSpecData!=null)
                {
                    DeleFunc deleFunc = new DeleFunc(UpdateSpecGraph);
                    this.Invoke(deleFunc);
                    Thread thread = new Thread(new ThreadStart(SaveFile));
                    thread.Start();
                    //刷新Graph；
                }
                ButtonStatus(this.btnStart.Text);
                btnStart.Text = "开始";
            }
        }
        /// <summary>
        /// 文件只保存在固定磁盘中，且不保存在系统盘符中(避免文件写入权限不足)。
        /// </summary>
        private void SaveFile()
        {   
            try
            {
                DriveInfo[] allDrivers = DriveInfo.GetDrives();
                DirectoryInfo directoryInfo;
                
                foreach (DriveInfo item in allDrivers)
                {
                    if (item.DriveType == DriveType.Fixed && item.Name != Environment.GetEnvironmentVariable("systemdrive") + "\\")
                    {
                        directoryInfo = new DirectoryInfo(item.Name + "WasatchData");
                        if (directoryInfo.Exists)
                        {
                            //不创建文件夹
                            directoryInfo.Attributes = FileAttributes.Normal;
                        }
                        else
                        {
                            //创建文件夹
                            directoryInfo.Create();
                            directoryInfo.Attributes = FileAttributes.Normal;
                        }
                        string pathName = System.DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".csv";
                        string fullPath = directoryInfo.FullName + "\\" + pathName;
                        FileStream fs = new FileStream(fullPath, FileMode.OpenOrCreate, FileAccess.Write);
                        StreamWriter sw = new StreamWriter(fs);
                        for (int i = 0; i < pixelHoriNum; i++)
                        {
                            if (i == 0)
                            {
                                string title = string.Format("Pixel" + "\t" + "Wavelength" + "\t" + "RamanShift(cm-1)" + "\t" + "Intensity");
                                sw.WriteLine(title);
                            }
                            string dataRaw = string.Format(pixels[i] + "\t" + wavelength[i] + "\t" + ramanShift[i] + "\t" + rawSpecData[i]);
                            sw.WriteLine(dataRaw);
                        }
                        sw.Flush();
                        sw.Close();
                        fs.Close();
                        break;
                    }
                    
                } 
            }
            catch (FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }         
        }
        private void UpdateSpecGraph()
        {
            //输入参数：pixels;wavelength;ramanShift;
            ShowSpectrum(this.chartRawSpec,rawSpecData);
        }
        /// <summary>
        /// 刷新光谱chart，并重新根据X轴绘图
        /// </summary>
        /// <param name="chart">指定的chart控件</param>
        /// <see cref="Spectrometer.getSpectrum()"/>
        /// <param name="yArray">根据Spectrometer.getSpectrum()返回的光谱强度</param>
        private void ShowSpectrum(Chart chart,double[] yArray)
        { 
            if (chart == null) return;
            chart.ChartAreas.Clear();
            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);
            this.chartRawSpec.Series.Clear();
            Series series = new Series();
            double[] xArray = SelectXAxis(this.comboBoxXAxis);
            
            if(yArray==null)
            {
                yArray = new double[pixelHoriNum];
            }
            else
            {
                this.chartRawSpec.ChartAreas[0].AxisY.Maximum = (int)(yArray.Max());
                this.chartRawSpec.ChartAreas[0].AxisY.Minimum = (int)(yArray.Min());
            }
            this.chartRawSpec.ChartAreas[0].AxisY.Title = "Intensity(a.u)";
            this.chartRawSpec.ChartAreas[0].AxisY.TitleFont=this.chartRawSpec.ChartAreas[0].AxisX.TitleFont = new Font("Arial Black", 10, FontStyle.Regular);
            for (int i = 0; i < pixelHoriNum; i++)
            {
                series.Points.AddXY(xArray[i], yArray[i]);
            }
            series.IsVisibleInLegend = false;
            series.ChartType = SeriesChartType.Line;
            chartRawSpec.Series.Add(series);
            chart.ChartAreas[0].RecalculateAxesScale();
        }
        /// <summary>
        /// 根据X轴选择刷新X轴的标题和X轴的范围
        /// </summary>
        /// <param name="comboBox">选择X轴为Pixel或Wavelength或RamanShift</param>
        /// <returns>返回数组Pixel或Wavelength或RamanShift</returns>
        private double[] SelectXAxis(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == 0)//X轴选择pixel
            {
                this.chartRawSpec.ChartAreas[0].AxisX.Minimum = 0;
                this.chartRawSpec.ChartAreas[0].AxisX.Maximum = pixelHoriNum - 1;
                this.chartRawSpec.ChartAreas[0].AxisX.Title = "Pixel";
                return pixels;
            }
            else if (comboBox.SelectedIndex == 2)//X轴选择RamanShift
            {
                this.chartRawSpec.ChartAreas[0].AxisX.Minimum = (int)(ramanShift.Min());
                this.chartRawSpec.ChartAreas[0].AxisX.Maximum = (int)(ramanShift.Max());
                this.chartRawSpec.ChartAreas[0].AxisX.Title = "RamanShift(cm-1)";
                return ramanShift;
            }
            else
            {
                this.chartRawSpec.ChartAreas[0].AxisX.Minimum = (int)(wavelength.Min());
                this.chartRawSpec.ChartAreas[0].AxisX.Maximum = (int)(wavelength.Max());
                this.chartRawSpec.ChartAreas[0].AxisX.Title = "Wavelength";
                return wavelength;
            }
        }
        private void comboBoxXAxis_SelectedIndexChanged(object sender, EventArgs e)//需要修改graph刷新问题
        {
            ShowSpectrum(this.chartRawSpec, rawSpecData);
        }
        private void ButtonStatus(string status)
        {
            if(status=="开始")//积分过程未运行，准备运行
            {
                groupBoxLaser.Enabled=false;
                groupBoxWorkMode.Enabled = false;
                groupBoxMeasureSetting.Enabled = false;
                btnStart.Enabled = false;
                btnStop.Enabled = true;
            }
            else//积分过程正在运行中
            {
                groupBoxLaser.Enabled = true;
                groupBoxWorkMode.Enabled = true;
                groupBoxMeasureSetting.Enabled = true;
                btnStart.Enabled = true;
                btnStop.Enabled = false;
            }
        }
        #endregion

        #region 工作模式
        CancellationTokenSource cts;
        private void comboBoxWorkMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxWorkMode.SelectedItem.ToString() == "连续监测")
            {      
                groupBoxMeasureSetting.Enabled = false;
                this.toolStripMenuItemRecordDark.Enabled = true;
                 cts = new CancellationTokenSource();
                try
                {
                    Task executeTask = new Task(ContinousTask, cts.Token);
                    executeTask.Start();
                }
                catch (Exception ex)
                {
                    ;
                }
                
            }
            else//单次测量
            {
                if (cts == null) ;
                else
                    cts.Cancel();
                groupBoxMeasureSetting.Enabled = true;
                radioButtonSum.Checked = true;
                radioButtonInSitu.Checked = true;  
                numericUpDownCircles.Value = 1;
                this.toolStripMenuItemRecordDark.Enabled = false;
                if (!s.hasLaser)
                {
                    radioButtonSubtract.Enabled = false;
                    radioButtonPreflashOn.Enabled = false;
                    labelPreflash.Visible = numericUpDownPreflashTime.Visible = false;
                    radioButtonPreflashOff.Checked = true;
                }
                else
                    radioButtonPreflashOn.Checked = true;               
            }
        } 
        private void ContinousTask()
        {
            while (!cts.IsCancellationRequested)
            {
                Task task = new Task(new Action(() => { rawSpecData = s.getSpectrum(); }), cts.Token);
                task.ContinueWith(t =>
                {
                    if (cts.Token.IsCancellationRequested)//如果取消了，退出
                        return;
                    else
                    {
                        chartRawSpec.BeginInvoke(new MethodInvoker(delegate { UpdateSpecGraph(); }));
                    }
                },
                TaskContinuationOptions.OnlyOnRanToCompletion);
                task.Start();
                Thread.Sleep(10);
            }
            
        }
        private void numericUpDownBoxcarSmooth_ValueChanged(object sender, EventArgs e)
        {
            s.boxcarHalfWidth = (uint)numericUpDownBoxcarSmooth.Value;
        }
        private void numericUpDownIntegrationTime_ValueChanged(object sender, EventArgs e)
        {
            if(this.numericUpDownIntegrationTime.InvokeRequired)
            {
                this.numericUpDownIntegrationTime.Invoke(new Action(()=> 
                {
                    s.integrationTimeMS = (uint)numericUpDownIntegrationTime.Value;
                    uint actualIntegrationTimeUS = s.actualIntegrationTimeUS;
                }));
                
            }
            else
            {
                s.integrationTimeMS = (uint)numericUpDownIntegrationTime.Value;
                uint actualIntegrationTimeUS = s.actualIntegrationTimeUS;
            }
            

        }
        private void radioButtonPreflashOn_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonPreflashOn.Checked)
            {
                labelPreflash.Enabled = true;
                numericUpDownPreflashTime.Enabled = true;
                labelPreflash.Visible = true;
                numericUpDownPreflashTime.Visible = true;
            }
            else
            {
                labelPreflash.Enabled = false;
                numericUpDownPreflashTime.Enabled = false;
                labelPreflash.Visible = false;
                numericUpDownPreflashTime.Visible = false;
            }
        }

        #endregion

        #region 菜单操作
        private void toolStripMenuItemRecordDark_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            s.laserEnabled = false;
            s.close();
            Application.Exit();
        }

        #endregion

        
    }
}
