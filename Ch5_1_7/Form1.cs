using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_select_Click(object sender, EventArgs e)
        {
            tb_message.ForeColor = Color.Black;

            if (rb_three.Checked)
            {
                tb_message.Text = rb_three.Text;
                tb_message.BackColor = Color.LightBlue;
            }else if (rb_five.Checked)
            {
                tb_message.Text = rb_five.Text;
                tb_message.BackColor = Color.LightYellow;
            }else if (rb_seven.Checked)
            {
                tb_message.Text = rb_seven.Text;
                tb_message.BackColor = Color.LightCoral;
            }
            else
            {
                tb_message.Text = rb_all.Text;
                tb_message.BackColor = Color.OrangeRed;
                tb_message.ForeColor = Color.White;
            }

        }
    }
}
