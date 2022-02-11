using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_4_1
{
    delegate int MyDelegate(int op1, int op2);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_cal_Click(object sender, EventArgs e)
        {
            int op1 = Convert.ToInt32(tb_01.Text);
            int op2 = Convert.ToInt32(tb_02.Text);

            if (rb_ad.Checked)
            {
                MyDelegate handler = new MyDelegate(MyMath.Add);
                lab_MSG.Text = "加法: " + handler(op1, op2);
            }
            if (rb_sub.Checked)
            {
                MyDelegate handler = new MyDelegate(MyMath.Sub);
                lab_MSG.Text = "減法: " + handler(op1, op2);
            }
            if (rb_mul.Checked)
            {
                MyDelegate handler = new MyDelegate(MyMath.Mul);
                lab_MSG.Text = "乘法: " + handler(op1, op2);
            }
            if (rb_div.Checked)
            {
                MyDelegate handler = new MyDelegate(MyMath.Div);
                lab_MSG.Text = "除法: " + handler(op1, op2);
            }

        }
    }

    class MyMath
    {
        public static int Add(int op1,int op2)
        {
            return op1 + op2;
        }
        public static int Sub(int op1, int op2)
        {
            return op1 - op2;
        }
        public static int Mul(int op1, int op2)
        {
            return op1 * op2;
        }
        public static int Div(int op1, int op2)
        {
            return op1 / op2;
        }
    }
}
