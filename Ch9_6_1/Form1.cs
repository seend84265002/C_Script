using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch9_6_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_name_Click(object sender, EventArgs e)
        {
            Myname name = new Myname("小刀","陳");
            tb_MSG.Text = name.Getname() + "\r\n" + name.GetFirstname();
        }

        public partial class Myname
        {
            private string Firstname, Lastname;
            public Myname(string f, string l)
            {
                Firstname = f;
                Lastname = l;
            }
            public string Getname()
            {
                return "姓名: " + Lastname +" "+ Firstname;
            }

        }
        public partial class Myname
        {
            public string GetFirstname()
            {
                return "名: " + Firstname;
            }
        }
    }

    
}

   


