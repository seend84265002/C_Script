using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_jud_Click(object sender, EventArgs e)
        {
            double temp = Convert.ToDouble(tb_temp.Text);
            tb_message.Text = temp < 20 ? "今天溫度 :" + tb_temp.Text + "\r\n天氣冷，要多穿一件外套喔" :
                             "今天溫度 :" + tb_temp.Text  ;

            //if (temp < 20)
            //{
            //    tb_message.Text = "今天溫度 :" + tb_temp.Text  
            //                       + "\r\n天氣冷，要多穿一件外套喔";          //   /r 回車鍵
            //}
            //else
            //{
            //    tb_message.Text = "今天溫度 :" + tb_temp.Text;
            //}
        }
    }
}
