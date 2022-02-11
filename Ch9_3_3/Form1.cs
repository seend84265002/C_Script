using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch9_3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test std = new Test();
            std.MyMid = 92;
            std.MyFin = 78;
            tb_mid.Text = std.MyMid.ToString();
            tb_fin.Text = std.MyFin.ToString();

        }
    }
    class Test
    {
        private int mid;
        private int fin;

        public int MyMid
        {
            get { return mid; }
            set
            {
                if (value < 0 || value > 100)
                {
                    mid = 0;
                }
                else mid = value;
            }
        }

        public int MyFin
        {
            get { return fin; }
            set
            {
                if (value < 0 || value > 100)
                {
                    fin = 0;
                }
                else fin = value;

            }
        }
    }
}
