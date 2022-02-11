using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch2_3_3_1_WinAppDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string login = text_box.Text;
            Ib_Welcome.Text = Ib_Welcome.Text + " " + login;
            Ib_Welcome.ForeColor = Color.Red;

        }
    }
}
