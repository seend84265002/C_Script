using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_11
{
    public partial class Form1 : Form
    {
        int selection;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_vote_Click(object sender, EventArgs e)
        {
            selection = Convert.ToInt16(tb_input.Text);
            lb_out_MSG.BackColor = Color.Black;
            lb_out_MSG.ForeColor = Color.Yellow;
            switch (selection)
            {
                case 1:
                    tb_CCC.Text =Convert.ToString(Convert.ToInt16(tb_CCC.Text) + 1);
                    lb_out_MSG.Text = "C# 一票";
                    
                    break;
                case 2:
                    tb_C.Text= Convert.ToString(Convert.ToInt16(tb_C.Text) + 1);
                    lb_out_MSG.Text = "C語言 一票";
                    
                    break;
                case 3:
                    tb_cbb.Text = Convert.ToString(Convert.ToInt16(tb_cbb.Text) + 1);
                    lb_out_MSG.Text = "C++ 一票";

                    break;
                case 4:
                    tb_other.Text = Convert.ToString(Convert.ToInt16(tb_other.Text) + 1);
                    lb_out_MSG.Text = "其他語言 一票";
                    
                    break;
            }

        }
    }
}
