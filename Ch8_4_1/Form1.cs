using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_4_1
{
    public partial class Form1 : Form
    {
        string[][] class_members = new string[][]
         {
         new string[] { "Andy", "Bill" },new string[] { "Carol", "Daniel","Eric" },new string[] { "Farady", "Grace" }
         };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_MSG.Text = "";
            foreach (var f in class_members)
            {
                foreach(var ee in f)
                    {
                    tb_MSG.Text += ee +"\t";
                    }tb_MSG.Text += "\r\n";
            }
        }
    }
}
