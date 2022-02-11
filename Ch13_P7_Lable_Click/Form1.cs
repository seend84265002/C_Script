using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch13_P7_Lable_Click
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "Double lable Click";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Label Click";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int[] card = new int[2];
            card[0] = rd.Next(1, 13 + 1);
            card[1] = rd.Next(1, 13 + 1);
            Button btn = (Button)sender;
            if(btn.Name == button1.Name)
            {
                button1.Text = "*" + card[0].ToString()+"點";
                button2.Text = card[1].ToString()+"點";
                label1.Text = "button1_Click";
            }
            else
            {
                button1.Text = card[0].ToString() + "點";
                button2.Text = "*" + card[1].ToString() + "點";
                label1.Text = "button2_Click";
            }
        }
    }
}
