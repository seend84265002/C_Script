using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_9
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bt_input_Click(object sender, EventArgs e)
        {
            tb_A_max.Text = tb_height.Text;
            tb_B_min.Text = tb_weight.Text;

        }

        private void bt_if_Click(object sender, EventArgs e)
        {
           if (Convert.ToDouble(tb_A_max.Text) > Convert.ToDouble(tb_A_min.Text) && 
                Convert.ToDouble(tb_B_max.Text)  >= Convert.ToDouble(tb_B_min.Text))
            {
                rb_ok.Checked = true;
            }
            else
            {
                rb_ng.Checked = true;
            }
        }

        private void bt_enter_Click(object sender, EventArgs e)
        {
            if (rb_ok.Checked)
            {
                double BMI;
                double height = Convert.ToDouble(tb_height.Text);
                height /= 100;
                double wight = Convert.ToDouble(tb_weight.Text);
                BMI = wight / (height * height);
                tb_BMI.Text = BMI.ToString("0.00");
            }
            else
            {
                tb_BMI.Text = "參數不合格，無法計算BMI";
            }

        }

        private void tb_height_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
