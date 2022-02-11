#define MultiCast    //呼叫#if MultiCast  呼叫#else MultiCast1 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ch12_4_2
{

    public partial class Form1 : Form
    {
        delegate void Mydelegate(int op1, int op2);
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        { }

        private void bt_cal_Click(object sender, EventArgs e)
        {
            int op1 = Convert.ToInt32(tb_01.Text);
            int op2 = Convert.ToInt32(tb_02.Text);
            MyMath math = new MyMath();
#if MultiCast
            Mydelegate del = new Mydelegate(math.Add);
            del += new Mydelegate(math.Sub);
            del += new Mydelegate(math.Mul);
            del += new Mydelegate(math.Div);
            del(op1, op2);
            lab_MSG.Text = math.str;

            del -= new Mydelegate(math.Mul);
            del -= new Mydelegate(math.Div);

            del(op1, op2);
            lab_MSG.Text = math.str;



#else 
            //List<Mydelegate> dels = new List<Mydelegate>();
            //dels.Add(math.Add);
            Mydelegate[] dels = { new Mydelegate(math.Add), new Mydelegate(math.Sub), new Mydelegate(math.Mul), new Mydelegate(math.Div) };
            foreach (Mydelegate d in dels)
            {
                d(op1, op2);
            }
            lab_MSG.Text = math.str;
#endif

        }
    }
    class MyMath
    {
        public string str;
        public MyMath()
        {
            str = " 四則運算結果: " + "\r\n";
        }
        public void Add(int op1,int op2)
        {
            str += "加法=" + (op1 + op2) + "\r\n";
        }
        public void Sub(int op1, int op2)
        {
            str += "減法=" + (op1 - op2) + "\r\n";
        }
        public void Mul(int op1, int op2)
        {
            str += "乘法=" + (op1 * op2) + "\r\n";
        }
        public void Div(int op1, int op2)
        {
            str += "除法=" + (op1 / op2) + "\r\n";
        }
    }
}
