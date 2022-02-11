using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bu_form_BC_Click(object sender, EventArgs e)
        {
            DialogResult color = Color_form_BC.ShowDialog();
            if(color == DialogResult.OK)
            {
                this.BackColor = Color_form_BC.Color;
                Tb_R.Text = Color_form_BC.Color.R.ToString("X");
                Tb_G.Text = Color_form_BC.Color.G.ToString("X");
                Tb_B.Text = Color_form_BC.Color.B.ToString("X");
            }
        }

        private void Group_Bt_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Group_Bt.BackColor = Color.LightBlue;
        }
    }
}
