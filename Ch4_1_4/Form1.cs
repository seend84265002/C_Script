using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Bu_cal_Click(object sender, EventArgs e)
        {
            double bmi =0;
            double height =0;

            height = Convert.ToDouble(Tx_height.Text) / 100.0 ;
    
            bmi = Convert.ToDouble(Tx_weight.Text) / (height* height);
            Tx_bmi.Text = bmi.ToString("0.00");
        }

        private void Bu_color_Click(object sender, EventArgs e)
        {
            // 按按鈕 控制 Form 的背景顏色

            DialogResult dr = colorDialog.ShowDialog();  //設定一個調色盤呼叫參數;
            if(dr == DialogResult.OK)                   //調色盤選色OK 就更換背景顏色

            {
                this.BackColor = colorDialog.Color;
            }
        }
    }
}
