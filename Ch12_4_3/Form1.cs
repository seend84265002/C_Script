using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch12_4_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student myClass = new Student();
            myClass[1] = "Andy";
            myClass[2] = "Carol";
            myClass[3] = "David";

            foreach (var ee in myClass.Name)
            {
                lab_out.Text += ee + "\r\n";
            }

            /*for (int i=0;i < myClass.Name.Count; i++)
            {
                lab_out.Text += myClass[i] + "\r\n";
            }*/
        }
    }
    class Student
    {
        public List<string> Name =new List<string>();
        public Student()
        {
            Name.Add("無名氏1");
            Name.Add("無名氏2");
            Name.Add("無名氏3");
            Name.Add("無名氏4");
            Name.Add("無名氏5");
        }
        public string this[int pos]
        {
            get { return Name[pos]; }
            set { Name[pos] = value; }
        }
    }
}
