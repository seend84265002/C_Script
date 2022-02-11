using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cb_04_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bt_output_Click(object sender, EventArgs e)
        {
            double price;
            int quanity;
            double pay;

            pay = 0;
            price = Convert.ToDouble(tb_price.Text);
            quanity = Convert.ToInt32(tb_quantity.Text);
            
            if (cb_sweeten.Checked) pay += 5* quanity;
            if (cb_addpearl.Checked) pay += 10* quanity;
            if (cb_addAiyu.Checked) pay += 15 * quanity;
            pay += price * quanity; 
            tb_message.Text = "$ "+pay.ToString();
        }
    }
}
