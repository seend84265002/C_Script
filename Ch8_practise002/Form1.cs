using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_practise002
{
    public partial class form : Form
    {
        int[] data = new int[7];
        int[] data_sort = new int[7];
        int idx;
        public form()
        {
            InitializeComponent();
        }

        private void bt_produce_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = ran.Next(1, 51);
            }
            tb_0.Text = data[0].ToString();
            tb_1.Text = data[1].ToString();
            tb_2.Text = data[2].ToString();
            tb_3.Text = data[3].ToString();
            tb_4.Text = data[4].ToString();
            tb_5.Text = data[5].ToString();
            tb_6.Text = data[6].ToString();

        }

        private void bt_max_Click(object sender, EventArgs e)
        {
            /*for(int i = 0; i < data.Length; i++)
            {
               if (data_sort[6] == data[i])
                {
                    idx = i;
                    break;
                }
            }
            tb_max.Text = data[idx].ToString();
            tb_maxid.Text = idx.ToString(); */   
            tb_max.Text = data.Max().ToString();
            tb_maxid.Text = Array.IndexOf(data, data.Max()).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < data.Length; i++)
            {
                if (data_sort[0] == data[i])
                {
                    idx = i;
                    break;
                } 
            }
            tb_min.Text = data[idx].ToString();
            tb_minid.Text = idx.ToString();*/
            tb_min.Text = data.Min().ToString();
            tb_minid.Text = Array.IndexOf(data, data.Min()).ToString();

        }

        private void bt_sort_Click(object sender, EventArgs e)
        {
            Array.Copy(data,data_sort , data.Length);
            Array.Sort(data_sort);
            tb_s0.Text = data_sort[0].ToString();
            tb_s1.Text = data_sort[1].ToString();
            tb_s2.Text = data_sort[2].ToString();
            tb_s3.Text = data_sort[3].ToString();
            tb_s4.Text = data_sort[4].ToString();
            tb_s5.Text = data_sort[5].ToString();
            tb_s6.Text = data_sort[6].ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
