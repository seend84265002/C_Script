using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_3_1
{
    public partial class Form1 : Form
    {
        int start_temp = 0;
        int end_temp = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c=0;
            double f=0;
            start_temp = Convert.ToInt32(tb_temp_start.Text);
            end_temp = Convert.ToInt32(tb_temp_end.Text);
            c = start_temp;
            tb_out_MSG.Text = "攝氏\t" + "華氏\r\n";
            do
            {
                f = c * 9.0 / 5.0 +32.0;
                tb_out_MSG.Text += c + "\t" + f + "\r\n";
                c += 10;
            } while (c <=end_temp);
        }
    }
}
