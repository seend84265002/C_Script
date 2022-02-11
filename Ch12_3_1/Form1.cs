using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tb_out.Text = "主動丟出例外處理\r\n";
                //int value = Convert.ToInt32(tb_in.Text);
                //if (value < 10)
                {
                    //throw new ArithmeticException("值小於10");     //throw an Exception Object
                    throw new MyException("自行定義例外物件\r\n");
                }
            }//catch(ArithmeticException ex)
            catch (MyException ex)
            {
                tb_out.Text += ex.ToString()+"\r\n";
            }
            finally
            {
                tb_out.Text += "例外處理完畢\r\n";
            }

        }
        class MyException : Exception
        {
            public MyException(string msg) : base(msg) { }
        }

    }
}
