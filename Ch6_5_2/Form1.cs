using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_5_2
{
    public partial class Form1 : Form
    {
        int max = 0;
        int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_even_add_Click(object sender, EventArgs e)
        {
            tb_MSB.Text = "";
            max = Convert.ToInt32(tb_input.Text);
            sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 != 0) continue;
                    sum += i;
                    tb_MSB.Text += i + "+";

            }tb_MSB.Text += "=" + sum;
        }

        private void bt_odd_Add_Click(object sender, EventArgs e)
        {
            tb_MSB.Text = "";
            max = Convert.ToInt32(tb_input.Text);
            sum = 0;
            for (int i = 1; i <= max; i++)
            {
                if (i % 2 == 0) continue;
                sum += i;
                tb_MSB.Text += i + "+";

            }
            tb_MSB.Text += "=" + sum;
        }
    }
}
