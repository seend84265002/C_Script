using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_Input_Click(object sender, EventArgs e)
        {
            Tx_Output.Text = Tx_Passend.Text + "/" + Tx_Mission.Text;
            Tx_Output.BackColor = Color.LightBlue;
        }

        private void Tx_Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
