using System;
using System.Windows.Forms;

namespace Ch6_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Triangle_Click(object sender, EventArgs e)
        {
            tx_MSG.Text = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    tx_MSG.Text += j.ToString();
                    if (j == i) break;
                }
                tx_MSG.Text += "\r\n";
            }
        }

        private void bt_Triangle_In_Click(object sender, EventArgs e)
        {

            tx_MSG.Text = "";
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    tx_MSG.Text += j.ToString();
                    if (j == 10 - i) break;
                }
                tx_MSG.Text += "\r\n";
            }
        }

        private void bt_Triangle_Eq_Click(object sender, EventArgs e)
        {
            tx_MSG.Text = "";
            /*
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 19; j++)
                {
                    if ((j >= (10 - (i - 1))) && (j <= (10 + (i - 1)))){
                        tx_MSG.Text += "$";
                    } else tx_MSG.Text += "~";
                }
                tx_MSG.Text += "\r\n";
            }*/
            int i = 1;
            while (i <= 9)
            {
                int j = 1;
                while (j <= 17)
                {
                    if ((j >= (9 - (i - 1))) && (j <= (9 + (i - 1))))
                    {
                        tx_MSG.Text += "$";
                    }
                    else tx_MSG.Text += "+";
                    j++;
                }
                tx_MSG.Text += "\r\n";
                i++;
            }
        }
       
    }
}
