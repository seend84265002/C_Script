using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_9
{
    public partial class Form1 : Form
    {
        int target = 0, guess = 0, cnt = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guess = Convert.ToInt16(tb_guess_Number.Text);
            cnt++;
            tb_cnt.Text = cnt.ToString();
            if(guess == target)
            {
                lb_outMSG.Text = "你猜對了!!";
                lb_answer.Visible = true;
                tb_target.Visible = true;
                lb_outMSG.BackColor = Color.Black;
                lb_outMSG.ForeColor = Color.Red;

            }
            else
            {
                if (guess > target)
                {
                    lb_outMSG.Text = "你猜的數字太大了";
                    lb_outMSG.BackColor = Color.LightBlue;
                }
                else
                {
                    lb_outMSG.Text = "你猜測的數字太小了";
                    lb_outMSG.BackColor = Color.LightGreen;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_targetanswer_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            target = random.Next(1, 51);        //產生1-50的數字
            tb_target.Text = target.ToString();
            tb_target.Visible = false;
            lb_answer.Visible = false;
            cnt = 0;

        }
    }
}
