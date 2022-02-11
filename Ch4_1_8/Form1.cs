using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_8
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

        private void tb_m2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_USD_Click(object sender, EventArgs e)
        {
            double target;
            target = Convert.ToDouble(tb_money.Text) * Convert.ToDouble(tb_USD.Text);
            DialogResult dr = MessageBox.Show("可換成台幣 = " + target.ToString(),"美金金額 :"+tb_money.Text, 
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK)
            {
                tb_output_TWD.Text = target.ToString();
            }
            else
            {
                tb_output_TWD.Text = "0.0";
            }
           
        }

        private void bt_JPY_Click(object sender, EventArgs e)
        {
            double target;
            target = Convert.ToDouble(tb_money.Text) * Convert.ToDouble(tb_JPY.Text);
            DialogResult dr = MessageBox.Show("可換成台幣 = " + target.ToString(), "日幣金額 :" + tb_money.Text,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.OK)
            {
                tb_output_TWD.Text = target.ToString();
            }
            else
            {
                tb_output_TWD.Text = "0.0";
            }
        }
    }
}
