using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch9_3_1
{


    public partial class Form1 : Form
    {
        Test joe = new Test();
        Test mary = new Test();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        class Test
        {
            public int mid;
            public int fin;
            public double GetAVG()
            {
                double res = 0;
                res = (mid + fin) / 2;
                return res;
            }

            public void SetGrade(int m, int f)
            {
                mid = m;
                fin = f;
            }
        }
    }
}
