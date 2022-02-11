using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bt_jud_Click(object sender, EventArgs e)
        {
            
            if(Convert.ToDouble(tb_time.Text) % 1 == 0 && Convert.ToInt32(tb_time.Text) <=24 && Convert.ToInt32(tb_time.Text)>=0 && tb_time.Text !=null)
            {
                int time = Convert.ToInt32(tb_time.Text) ;
                tb_message.Text = time > 12 ? "PM:" : "AM:";
                time = time > 12 ? time - 12 : time;
                tb_message.Text += time.ToString(); 

            }
            else
            {
                tb_message.Text = "請輸入整數，並且數字請在0-24之間";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
