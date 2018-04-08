using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fly_up
{
    public partial class Form_Edit_Command : Form
    {
        private static Form_Edit_Command form;
        private Form_Edit_Command()
        {
            InitializeComponent();
        }
        public static Form_Edit_Command Create()
        {
            if (form == null || form.IsDisposed)  //单例窗口
            {
                form=new Form_Edit_Command();
                
            }else{
                MessageBox.Show("error!");
            }
            return form;
        }
        private void Button_Add_Row_Click(object sender, EventArgs e)
        {
            this.Table_Command.Rows.Add();
        }

        private void Button_Del_Row_Click(object sender, EventArgs e)
        {
            /*
            foreach (DataGridViewRow i in Table_Command.SelectedRows)
            {
                this.Table_Command.Rows.Remove(i);
            }*/

            foreach (DataGridViewCell i in Table_Command.SelectedCells)
            {
                try
                {
                    this.Table_Command.Rows.RemoveAt(i.RowIndex);
                }
                catch
                {
                }
            }
        }


    }
}
