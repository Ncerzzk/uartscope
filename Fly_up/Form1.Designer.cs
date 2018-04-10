namespace Fly_up
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 21D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 32D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 45D);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CheckBox_AddCRLF = new System.Windows.Forms.CheckBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Label_Send = new System.Windows.Forms.Label();
            this.TextBox_Message = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Open_Com = new System.Windows.Forms.Button();
            this.Button_Refresh_Com = new System.Windows.Forms.Button();
            this.ComboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.Label_BaudRate = new System.Windows.Forms.Label();
            this.ComboBox_Com = new System.Windows.Forms.ComboBox();
            this.Lable_SerialPort = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RichText_Receive = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(275, 656);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RichText_Receive);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Button_Clear);
            this.panel3.Location = new System.Drawing.Point(46, 699);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1218, 118);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(16, 16);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(75, 31);
            this.Button_Clear.TabIndex = 0;
            this.Button_Clear.Text = "清空";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CheckBox_AddCRLF);
            this.panel2.Controls.Add(this.Button_Send);
            this.panel2.Controls.Add(this.Label_Send);
            this.panel2.Controls.Add(this.TextBox_Message);
            this.panel2.Location = new System.Drawing.Point(22, 178);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 118);
            this.panel2.TabIndex = 2;
            // 
            // CheckBox_AddCRLF
            // 
            this.CheckBox_AddCRLF.AutoSize = true;
            this.CheckBox_AddCRLF.Location = new System.Drawing.Point(98, 83);
            this.CheckBox_AddCRLF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBox_AddCRLF.Name = "CheckBox_AddCRLF";
            this.CheckBox_AddCRLF.Size = new System.Drawing.Size(106, 22);
            this.CheckBox_AddCRLF.TabIndex = 7;
            this.CheckBox_AddCRLF.Text = "增加\\r\\n";
            this.CheckBox_AddCRLF.UseVisualStyleBackColor = true;
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(7, 73);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(84, 38);
            this.Button_Send.TabIndex = 6;
            this.Button_Send.Text = "发送";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Label_Send
            // 
            this.Label_Send.AutoSize = true;
            this.Label_Send.Location = new System.Drawing.Point(7, 14);
            this.Label_Send.Name = "Label_Send";
            this.Label_Send.Size = new System.Drawing.Size(62, 18);
            this.Label_Send.TabIndex = 3;
            this.Label_Send.Text = "发送：";
            // 
            // TextBox_Message
            // 
            this.TextBox_Message.Location = new System.Drawing.Point(10, 36);
            this.TextBox_Message.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBox_Message.Name = "TextBox_Message";
            this.TextBox_Message.Size = new System.Drawing.Size(198, 28);
            this.TextBox_Message.TabIndex = 0;
            this.TextBox_Message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_Open_Com);
            this.panel1.Controls.Add(this.Button_Refresh_Com);
            this.panel1.Controls.Add(this.ComboBox_BaudRate);
            this.panel1.Controls.Add(this.Label_BaudRate);
            this.panel1.Controls.Add(this.ComboBox_Com);
            this.panel1.Controls.Add(this.Lable_SerialPort);
            this.panel1.Location = new System.Drawing.Point(22, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 146);
            this.panel1.TabIndex = 1;
            // 
            // Button_Open_Com
            // 
            this.Button_Open_Com.Location = new System.Drawing.Point(108, 94);
            this.Button_Open_Com.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Open_Com.Name = "Button_Open_Com";
            this.Button_Open_Com.Size = new System.Drawing.Size(100, 38);
            this.Button_Open_Com.TabIndex = 5;
            this.Button_Open_Com.Text = "打开串口";
            this.Button_Open_Com.UseVisualStyleBackColor = true;
            this.Button_Open_Com.Click += new System.EventHandler(this.Button_Open_Com_Click);
            // 
            // Button_Refresh_Com
            // 
            this.Button_Refresh_Com.Location = new System.Drawing.Point(7, 94);
            this.Button_Refresh_Com.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Refresh_Com.Name = "Button_Refresh_Com";
            this.Button_Refresh_Com.Size = new System.Drawing.Size(84, 38);
            this.Button_Refresh_Com.TabIndex = 4;
            this.Button_Refresh_Com.Text = "刷新";
            this.Button_Refresh_Com.UseVisualStyleBackColor = true;
            this.Button_Refresh_Com.Click += new System.EventHandler(this.Button_Refresh_Com_Click);
            // 
            // ComboBox_BaudRate
            // 
            this.ComboBox_BaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_BaudRate.FormattingEnabled = true;
            this.ComboBox_BaudRate.Items.AddRange(new object[] {
            "115200",
            "38400",
            "57600",
            "9600"});
            this.ComboBox_BaudRate.Location = new System.Drawing.Point(72, 47);
            this.ComboBox_BaudRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_BaudRate.Name = "ComboBox_BaudRate";
            this.ComboBox_BaudRate.Size = new System.Drawing.Size(136, 26);
            this.ComboBox_BaudRate.TabIndex = 3;
            // 
            // Label_BaudRate
            // 
            this.Label_BaudRate.AutoSize = true;
            this.Label_BaudRate.Location = new System.Drawing.Point(3, 50);
            this.Label_BaudRate.Name = "Label_BaudRate";
            this.Label_BaudRate.Size = new System.Drawing.Size(80, 18);
            this.Label_BaudRate.TabIndex = 2;
            this.Label_BaudRate.Text = "波特率：";
            // 
            // ComboBox_Com
            // 
            this.ComboBox_Com.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_Com.FormattingEnabled = true;
            this.ComboBox_Com.Location = new System.Drawing.Point(72, 12);
            this.ComboBox_Com.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBox_Com.Name = "ComboBox_Com";
            this.ComboBox_Com.Size = new System.Drawing.Size(136, 26);
            this.ComboBox_Com.TabIndex = 1;
            // 
            // Lable_SerialPort
            // 
            this.Lable_SerialPort.AutoSize = true;
            this.Lable_SerialPort.Location = new System.Drawing.Point(7, 16);
            this.Lable_SerialPort.Name = "Lable_SerialPort";
            this.Lable_SerialPort.Size = new System.Drawing.Size(80, 18);
            this.Lable_SerialPort.TabIndex = 0;
            this.Lable_SerialPort.Text = "串口号：";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chart1
            // 
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.None;
            chartArea1.AxisX.ScaleView.MinSizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(309, 28);
            this.chart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(955, 664);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(256, 88);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(255, 28);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(255, 28);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(255, 28);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RichText_Receive
            // 
            this.RichText_Receive.Location = new System.Drawing.Point(16, 53);
            this.RichText_Receive.Name = "RichText_Receive";
            this.RichText_Receive.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RichText_Receive.Size = new System.Drawing.Size(1136, 60);
            this.RichText_Receive.TabIndex = 1;
            this.RichText_Receive.Text = "";
            this.RichText_Receive.TextChanged += new System.EventHandler(this.RichText_Receive_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 829);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBox_BaudRate;
        private System.Windows.Forms.Label Label_BaudRate;
        private System.Windows.Forms.ComboBox ComboBox_Com;
        private System.Windows.Forms.Label Lable_SerialPort;
        private System.Windows.Forms.Button Button_Open_Com;
        private System.Windows.Forms.Button Button_Refresh_Com;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBox_Message;
        private System.Windows.Forms.CheckBox CheckBox_AddCRLF;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.Label Label_Send;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox RichText_Receive;
    }
}

