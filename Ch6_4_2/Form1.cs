using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_9x9_Click(object sender, EventArgs e)
        {
            string str = "";
            for(int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    str += j + "*" + i +"="+ (j * i) + "\t" ;
                    if (j == 9) break;
                }str += "\r\n"; 
            }tb_output.Text = str;

        }
    }
}
