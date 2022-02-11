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
       
        public Form1()
        {
            InitializeComponent();
        }
        int NamePara_SumTest(int a,int b,int c)
        {
            int res = 0;
            res = a * 1 + b * 2 + c * 3;
            return res;
        }
        int OptionalPara_VolumeTest(int l,int w=2,int h=3)
        {
            
            return l*w*h;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_MSG.Text = "";
            int l = 10, w = 5, h = 15, reselt;
            string msg="";
            reselt= NamePara_SumTest(b: 2, c: 3, a: 1);
            msg += "After NamePara_SumTest (b: 2, c: 3, a: 1)為 :" + reselt+"\r\n";
            reselt= NamePara_SumTest(2, 3, 1);
            msg += "After NamePara_SumTest (2,3,1)為 :" + reselt + "\r\n";
            msg += "------------------------------------------------------\r\n";
            reselt = OptionalPara_VolumeTest(4);                            //(4,2,3)
            msg += "OptionalPara_VolumeTest(4) :" + reselt + "\r\n";
            reselt = OptionalPara_VolumeTest(4,5);                          //(4,5,3)
            msg += "OptionalPara_VolumeTest(4,5) :" + reselt + "\r\n";
            reselt = OptionalPara_VolumeTest(4,5,6);                        //(4,5,6)
            msg += "OptionalPara_VolumeTest(4,5,6) :" + reselt + "\r\n";
            msg += "------------------------------------------------------\r\n";
            int x = 10, y = 20;
            reselt = SUM(x, y);
            msg += "After Local Funtion SUM(a,b),this is (10,20):" + reselt + "\r\n";
            tb_MSG.Text = msg;

            int SUM(int a , int b)
            {
                int res = 0;
                res = a + b;
                return res;
            }
        }
    }
}
