using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch5_1_4
{   
    struct Person_Info
    {
        public string name;
        public int gender;      //0 : Female  1: Male
        public int job;         //0: Commerce  1:officical  2:others
    }
    public partial class form1 : Form
    {
        ArrayList aList;
        int cnt =0 ;
        public form1()
        {
            InitializeComponent();
            aList = new ArrayList();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person_Info p = new Person_Info();
            p.name = tb_name.Text;
            p.gender = (rb_Female.Checked) ? 0 : 1;
            if (rb_Commerce.Checked) p.job = 0;
            if (rb_officical.Checked) p.job = 1;
            if (rb_other.Checked) p.job = 2;

            aList.Add(p);
            cnt++;
            tb_number.Text = cnt.ToString();
        }

       
        private void bt_output_Click_1(object sender, EventArgs e)
        {
            string outMSG = "";

            foreach (var p in aList)
            {
                outMSG += ((Person_Info)p).name + " ";
                outMSG += (((Person_Info)p).gender == 1) ? "Male " : "Female ";
                if (((Person_Info)p).job == 0)
                {
                    outMSG += "Commerce ";
                }
                else if (((Person_Info)p).job == 1)
                {
                    outMSG += "officical ";
                }
                else
                {
                    outMSG += "others ";
                }
                outMSG += "\r\n";
                tb_message.Text = outMSG;
            }
        }
    }
}
