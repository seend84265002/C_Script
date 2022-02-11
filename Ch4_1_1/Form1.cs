using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double x = 0;
            //x=Convert.ToDouble(Tb_x.Text);
            //double y = 0;
            //y = Convert.ToDouble(Tb_y.Text);
            //double sum = x + y;
            //Tb_xy.Text = sum.ToString();
            //Tb_xy.Text = Convert.ToString(sum);

            Tb_xy.Text =Convert.ToString(Convert.ToDouble(Tb_x.Text) + Convert.ToDouble(Tb_y.Text));
            Tb_x.Focus();

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
            this.Text = "第2次修改標題";
        }
    }
}
