using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_4_2
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
            //Array.Sort(arrValue);
            //Array.Reverse(arrValue);
            findMaxElement(arrValue);
            tb_0.Text = arrValue[0].ToString();
            tb_1.Text = arrValue[1].ToString();
            tb_2.Text = arrValue[2].ToString();
            tb_3.Text = arrValue[3].ToString();

        }
        private void findMaxElement(int[] a)
        {
            int i = 0, id_max = 0;
            for (i = 0; i < a.Length; i++)
            {
                if (a[i] > a[id_max]) id_max = i;
            }
            i = a[0];
            a[0] = a[id_max];
            a[id_max] = i;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str = tb_input.Text;
            
            tb_MSG.Text = tb_input.Text.Replace(tb_search.Text, tb_replace.Text);
            //ReplaceStr(ref str, tb_search.Text, tb_replace.Text);
            //tb_MSG.Text = str;
        }
        private void ReplaceStr(ref string str ,string search ,string replace)
        {
            str = str.Replace(search, replace);
        }
    }
}
