using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch8_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] name = { "無","Andy", "Bill", "Carol", "Daniel", "Eric" };
            int[] score = { 0,100, 90, 70, 65, 88 };
            int id = -1;
            id = Convert.ToInt32(tb_ID.Text);
            if (id > 0 && id < name.Length)
            {
                tb_name.Text = name[id];
                tb_score.Text = score[id].ToString();

            }
            else
            {
                tb_name.Text = " Input Id Error ";
                tb_score.Text = "Plase Input Student ID Again!!!";
            }
        }
    }
}
