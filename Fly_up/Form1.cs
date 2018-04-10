using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

using System.IO.Ports;

namespace Fly_up
{
    public partial class Form1 : Form
    {
        Uart uart = new Uart(System.Text.Encoding.Default.GetString(new byte[2] { 0xFF, 0x00 }));
        System.Timers.Timer aTimer;
        public Form1()
        {
            InitializeComponent();

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            chart1.Series.Clear();
            if (chart1.Series.Count() == 0)
            {
                for (int j = 0; j < 4; ++j)
                {
                    chart1.Series.Add("CH" + j.ToString());
                    chart1.Series[j].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;

                }

            }
             aTimer = new System.Timers.Timer();

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // Set the Interval to 5 seconds.  

            aTimer.Interval = 10;



            //string a=System.Text.Encoding.Default.GetString (new byte[2]{0xFF,0x00});
           // MessageBox.Show(System.Text.Encoding.Default.GetString (new byte[2]{0xFF,0x00}));
            //MessageBox.Show(System.Text.Encoding.Default.GetString(new byte[6] { 97, 98, 0xFF, 0x00, 0x22, 0x33 }).Split(a.ToCharArray())[0]);
            //MessageBox.Show((System.Text.Encoding.Default.GetBytes("ab")[2].ToString()));
            
        }
        private  void OnTimedEvent(object source, ElapsedEventArgs e)
        {

            List<string> frames;
            frames = uart.get_frams();
            int lengh = frames.Count();
            for (int k = 0; k < lengh; ++k)
            {
 
                chart1.Series[0].Points.AddY(10 * k);
                /*
                for (int j = 0; j < 4; ++j)
                {
                    chart1.Series[0].Points.AddY(10 * j);
                }*/
            }


        }   

        

        private void Button_Refresh_Com_Click(object sender, EventArgs e)
        {
            string[] com_names;
            com_names=SerialPort.GetPortNames();
            foreach (string com in com_names)
            {
                this.ComboBox_Com.Items.Add(com);
            }
            this.ComboBox_Com.SelectedIndex = 0;
            this.ComboBox_BaudRate.SelectedIndex = 0;

        }
        private void send_Com_Message(String m)
        {
            if (this.CheckBox_AddCRLF.Checked == true)
            {
                m += "\r\n";
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                send_Com_Message(this.TextBox_Message.Text);
            }
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            send_Com_Message(this.TextBox_Message.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form_edit = Form_Edit_Command.Create();
            form_edit.Show();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s;

            if (serialPort1.BytesToRead > 200)
            {
                s=serialPort1.ReadExisting();
                RichText_Receive.Text = RichText_Receive.Text + s;
                uart.add_str_at_end(s);

                //下面这些要移到定时器中。
                if(aTimer.Enabled==false)
                    aTimer.Enabled = true;
                

            }
        }

        private void Button_Open_Com_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                serialPort1.BaudRate = int.Parse(ComboBox_BaudRate.Text);
                serialPort1.PortName = ComboBox_Com.Text;
                serialPort1.ReadBufferSize = 100000;
                try
                {
                    serialPort1.Open();
                    Button_Open_Com.Text = "关闭串口";
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.ToString());
                }
                
            }
            else
            {
                serialPort1.Close();
                Button_Open_Com.Text = "打开串口";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void Button_Clear_Click(object sender, EventArgs e)
        {
            RichText_Receive.Text = "";
        }

        private void RichText_Receive_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}
