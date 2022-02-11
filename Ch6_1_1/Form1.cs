using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_1_1
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int start = 0, end = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum = 0;
            start = Convert.ToInt16(tb_start.Text);
            end = Convert.ToInt16(tb_end.Text);
            for(int i = start; i <= end; i++)
            {
                sum += i;
            }
            tb_MSG.Text = "從" + start + "加到" + end + "= " + sum;
        }
    }
}
