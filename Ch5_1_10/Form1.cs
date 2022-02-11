using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_10
{
    public partial class Form1 : Form
    {
        double number1 = 0, number2 = 0,res=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(tb_Num1.Text);
            number2 = Convert.ToDouble(tb_Num2.Text);

            if (rb_Add.Checked)
            {
                res = number1 + number2;
            }else if (rb_sub.Checked)
            {
                res = number1 - number2; 
            }else if (rb_mul.Checked)
            {
                res = number1 * number2;
            }
            else
            {
                res = number1 / number2;
            }
            lb_answer.Text = res.ToString();




        }
    }
}
