using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch7_2_3
{
    public partial class Form1 : Form
    {
        string msg = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void CallByValue(int c)
        {
            c = c + 1;
            msg += "變數c的值在函數CallByValue為:" + c + "\r\n";        //2
        }
        private void CallByReff( ref int c)
        {
            c = c + 1;
            msg += "變數c的值在函數CallByReff為:" + c + "\r\n";        //2
        }

        private void CallByout(out int d)
        {
            d = 20;
            msg += "變數d的值在函數CallByReff為:" + d + "\r\n";        //20
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int c = 1;
            int d = 0;
            msg += "變數c的初始值為:" + c+"\r\n";      //1
            CallByValue(c);  
            msg += "變數c的值 CallByValue back to click :" + c + "\r\n";        //1

            msg += "變數c的值 Before CallByReff:" + c + "\r\n";      //1
            CallByReff( ref c);  
            msg += "變數c的值 CallByReff back to click :" + c + "\r\n";        //2

            msg += "-----------------------------------------------\r\n";
            msg += "變數d的初始值為 :" + d + "\r\n";                           //0
            CallByout(out d);                       //out 的值不用初始化
            msg += "變數d的值 CallByReff back to click :" + d + "\r\n";        //20
            tb_MSG.Text = msg.ToString();
        }
    }
}
