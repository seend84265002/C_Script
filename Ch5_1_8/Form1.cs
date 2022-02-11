using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_8
{
    public partial class Form1 : Form
    {
        double pay;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void bt_output_Click(object sender, EventArgs e)
        {
            gb_m.BackColor = Color.White;
            gb_fries.BackColor = Color.Yellow;
            gb_drinks.BackColor = Color.Pink;
            this.BackColor = Color.Gray;
            
            pay = 0;
            pay += cb_hamburger.Checked == true ? 35 : 0;
            pay += cb_sandwich.Checked == true ? 30 : 0;
            pay += cb_hamburgeradd.Checked == true ? 40 : 0;
            pay += cb_Quiche.Checked == true ? 25 : 0;
            if (cb_fries.Checked)
            {
                if (rb_fries_samll.Checked)
                {
                    pay += 25;
                }
                else { pay += 35; }
            }

            if (cb_drinks.Checked)
            {
                if (rb_drinks_milktea.Checked)
                {
                    pay += 5;
                }
                else if (rb_drinks_coffee.Checked) pay += 10;
            }
            tb_price.Text = "NT$ "+pay.ToString();
        }

        private void cb_fries_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cb_fries.Checked)
            {
                if(!rb_fries_samll.Checked && !rb_fries_big.Checked)
                {
                    rb_fries_samll.Checked = true;
                }
            }
            else
            {
                rb_fries_big.Checked = false;
                //rb_fries_big.Enabled = true;    可以打開選擇項目
                rb_fries_samll.Checked = false;
            }
        }

        private void cb_drinks_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_drinks.Checked)
            {
                if (!rb_drinks_milktea.Checked && !rb_drinks_coffee.Checked && !rb_drinks_blacktea.Checked)
                {
                    rb_drinks_blacktea.Checked = true;
                }
            } else
            {
                rb_drinks_milktea.Checked = false;
                rb_drinks_coffee.Checked = false;
                rb_drinks_blacktea.Checked = false;
            }
        }

        private void rb_fries_samll_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_fries.Checked)
            {
                rb_fries_samll.Checked = false;
            }
        }

        private void rb_fries_big_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_fries.Checked)
            {
                rb_fries_big.Checked = false;
            }
        }

        private void rb_drinks_milktea_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_drinks.Checked)
            {
                rb_drinks_milktea.Checked = false;
            }
        }

        private void rb_drinks_coffee_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_drinks.Checked)
            {
                rb_drinks_coffee.Checked = false;
            }
        }

        private void rb_drinks_blacktea_CheckedChanged(object sender, EventArgs e)
        {
            if (!cb_drinks.Checked)
            {
               rb_drinks_blacktea.Checked = false;
            }
        }
    }
}
