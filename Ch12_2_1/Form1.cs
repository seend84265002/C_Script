using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(tb_1.Text);
            int y = Convert.ToInt32(tb_2.Text);
            int res = 0;
            string[] names = { "Andy", "Bill", "Candy" };
            string name = "";
            try                       //try Block
            {
                res = x / y;
                name = names[Convert.ToInt32(tb_index.Text)];
            }catch(ArithmeticException ex)      //catch Block
            {
                tb_MSG.Text += "ArithmeticException Error Occursl! " + ex.ToString() + "\r\n";
            }catch(IndexOutOfRangeException ex)
            {
                tb_MSG.Text += "IndexOutOfRangeException Error Occursl! " + ex.ToString() + "\r\n";
            }
            finally                  //finall Block
            {
                tb_MSG.Text += "res= " + res + "\r\n";
                tb_MSG.Text += "x= " + x + "\r\n";
                tb_MSG.Text += "y= " + y + "\r\n";
                tb_MSG.Text += "name= "+name + "\r\n";
            }
        }
    }
}
