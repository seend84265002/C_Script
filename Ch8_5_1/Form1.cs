using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt__Click(object sender, EventArgs e)
        {
            int[] arrValue = new int[4];
            arrValue[0] = Convert.ToInt32(tb_0.Text);
            arrValue[1] = Convert.ToInt32(tb_1.Text);
            arrValue[2] = Convert.ToInt32(tb_2.Text);
            arrValue[3] = Convert.ToInt32(tb_3.Text);
            Array.Sort(arrValue);
            //Array.Reverse(arrValue);
            
            tb_0.Text = arrValue[0].ToString();
            tb_1.Text = arrValue[1].ToString();
            tb_2.Text = arrValue[2].ToString();
            tb_3.Text = arrValue[3].ToString();
        }
    }
}
