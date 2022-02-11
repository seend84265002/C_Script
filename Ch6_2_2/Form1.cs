using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_2_2
{
    public partial class Form1 : Form
    {
        int delta, sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_compute_Click(object sender, EventArgs e)
        {
            delta = Convert.ToInt16(tb_input.Text);
            sum = 0;
            string msg = "";
            if (delta > 0)
            {
                for(int i = 1; i <= 100; i += delta)
                {
                    sum += i; 
                    msg += i + "+";
                }
                msg += "=" + sum;
            }
            else if(delta<0)
            {
                for(int i =100; i >= 1; i += delta)
                {
                    sum += i;
                    msg += i + "+";
                }
                msg += "=" + sum;
            }
            else
            {
                msg = "無法計算";
            }
            tb_out_OMG.Text = msg;
        }
    }
}
