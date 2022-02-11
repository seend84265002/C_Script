using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_3
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
            counter = 0;
            this.Text = "計數器";
        }

        private void Bu_Rest_Click(object sender, EventArgs e)
        {
            counter = 0;
            lb_Counter.Text = counter.ToString();
        }

        private void Bu_add_Click(object sender, EventArgs e)
        {
            counter++;
            lb_Counter.Text = counter.ToString();
        }

        private void Bu_Reduce_Click(object sender, EventArgs e)
        {
            counter--;
            lb_Counter.Text = counter.ToString();
        }

        private void Bu_end_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
