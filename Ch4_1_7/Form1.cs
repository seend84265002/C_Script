using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch4_1_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_sel_Click(object sender, EventArgs e)
        {
            tb_ML.SelectionStart = Convert.ToInt16(tb_start.Text);
            tb_ML.SelectionLength = 6;
            tb_ML.Focus();

        }

        private void bt_Dis_Click(object sender, EventArgs e)
        {
            tb_Ouyput.Text = tb_ML.SelectedText + "/" + tb_ML.SelectionStart + "/" + tb_ML.SelectionLength;
            tb_Ouyput.Focus();
            //tb_start.Text = tb_ML.SelectionStart.ToString();
        }
    }
}
