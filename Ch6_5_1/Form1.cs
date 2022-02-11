using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_5_1
{
    public partial class Form1 : Form
    {
        int amount = 0;
        int cnt_50 = 0, cnt_20 = 0, cnt_10 = 0, cnt_5 = 0,cnt_1=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_intput_Click(object sender, EventArgs e)
        {
            cnt_50 = 0; cnt_20 = 0; cnt_10 = 0; cnt_5 = 0; cnt_1 = 0;
            amount = Convert.ToInt32(tb_money.Text);
            if(cb_50.Checked)
            {
                while (amount >= 50)
                {
                    amount -= 50;
                    cnt_50++;
                }
            }
            if (cb_20.Checked )
            {
                while (amount >= 20)
                {
                    amount -= 20;
                    cnt_20++;
                }
            }
            if (cb_10.Checked )
            {
                while (amount >= 10)
                {
                    amount -= 10;
                    cnt_10++;
                }
            }
            if (cb_5.Checked ==true)
            {
                while (amount >= 5)
                {
                    amount -= 5;
                    cnt_5++;
                }
            }
            cnt_1 = amount;
            tb_50.Text = cnt_50.ToString();
            tb_20.Text = cnt_20.ToString();
            tb_10.Text = cnt_10.ToString();
            tb_5.Text = cnt_5.ToString();
            tb_1.Text = cnt_1.ToString();
        }
    }
}
