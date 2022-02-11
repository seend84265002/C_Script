using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_4_2
{
    public partial class Form1 : Form
    {
        Int64 n=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt64(tb_input.Text);
            lb_MSG.Text= factorial(n).ToString();

        }

        Int64 factorial(Int64 n)
        {
            if (n == 1) return 1;
            else return n * factorial(n-1);
        }
    }
}
