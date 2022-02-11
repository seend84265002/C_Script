using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_1_2_P17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            int pos = -1;
            pos = tb_MSG.Text.IndexOf(tb_search.Text);
            if(pos != -1)
            {
                tb_MSG.SelectionStart = pos;
                tb_MSG.SelectionLength = tb_search.Text.Length;
                tb_MSG.Focus();
            }
        }

        private void bt_replace_Click(object sender, EventArgs e)
        {
            int pos = -1;
            pos = tb_MSG.Text.IndexOf(tb_search.Text);
            if (pos != -1)
            {
                tb_MSG.Text = tb_MSG.Text.Replace(tb_search.Text, tb_replace.Text);
                tb_MSG.SelectionStart = pos;
                tb_MSG.SelectionLength = tb_search.Text.Length;
                tb_MSG.Focus();
            }
        }
    }
}
