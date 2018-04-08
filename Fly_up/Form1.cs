using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;

namespace Fly_up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

    }
}
