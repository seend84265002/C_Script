using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_jud_Click(object sender, EventArgs e)
        {
            double Score = Convert.ToDouble(tb_score.Text);
            if(Score >=60 && Score<=100)
            {
                tb_message.ForeColor =Color.Blue ;
                tb_message.Text = "你的分數 : "+ tb_score.Text  +"\r\n分數合格";

            }
            else
            {
                tb_message.ForeColor = Color.Red;
                tb_message.Text = "你的分數 : " + tb_score.Text + "\r\n分數不合格";
            }
        }
    }
}
