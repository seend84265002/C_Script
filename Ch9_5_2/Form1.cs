using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch9_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student.name = "姓名 : 陳小刀";
            string n1 = Student.name;
            Student.name = "姓名 : 陳大刀";
            string n2 = Student.name;
            Student.name = "姓名 : 陳一刀";
            string n3 = Student.name;
            tb_MSG.Text = n1 + "\r\n" + n2 + "\r\n" + n3 + "\r\n" + "學生數 : "+Student.Number();
        }

        public class Student
        {
            private string Name;
            private static int count = 3;
            public static string name { get; set; }
            public static int Number()
            {
                return count;
            }
        }
    }
}
