using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch6_3_1
{
    public partial class Form1 : Form
    {
        int Good_price;
        int Month_money;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Good_price = Convert.ToInt32(tb_Good_Price.Text);
            Month_money = Convert.ToInt32(tb_Month_money.Text);
            int sum = 0;
            int cnt = 0;
            do
            {
                sum += Month_money;
                cnt++;
            } while (sum < Good_price);
            tb_out_MSG.Text = "需存月數 :" + cnt + "\r\n" + "存款金額 :" + sum;
        }
    }
}
