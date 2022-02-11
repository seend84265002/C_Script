using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch10_2_1
{
    public partial class Form1 : Form
    {
        Student std = new Student(100, "Andy", 89, 89);
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Person_Info_Click(object sender, EventArgs e)
        {
            //tb_MSG.Text = "";
            tb_number.Text = std.ID.ToString();
            tb_name.Text = std.Name;
            tb_MSG.Text = std.PersonInfo()+"\r\n"+std.getnumber();

        }

        private void bt_Student_Info_Click(object sender, EventArgs e)
        {
            //tb_MSG.Text = "";
            tb_number.Text = std.ID.ToString();
            tb_name.Text = std.Name;
            tb_score.Text = std.Score.ToString();
            tb_MSG.Text = std.StudentInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_MSG.Text = "";
            tb_number.Text = "";
            tb_name.Text = "";
            tb_score.Text = "";
        }
    }
    class Person
    {
        public int ID;
        public string Name;
        public Person(int id, string name)                                     
        {
            ID = id;
            Name = name;
            Console.WriteLine("Person SCTOR is called");
        }
        public string PersonInfo()
        {
            return "編號: " + ID + "\r\n" + "姓名: " + Name;
        }

    }
    class Student : Person
    {
        public int Score;
        public int Grade;
        public Random nu = new Random();
        public Student(int id, string name, int score,int grade) : base(id, name)          
        {
            Score = score;
            Grade = grade;
            
        }
        public string getnumber()
        {
            int[] a = new int[6];
            string str = "";
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = nu.Next(1, 50);
               
            }
            Array.Sort(a);

            foreach (var e in a)
            {
                str += e + "，";
            }
            return str;
        }
        public string StudentInfo() 
        {
            return PersonInfo() + "\r\n" + "成績: " + Score+"\r\n"+"Grade屬性值: " +Grade;
        }

    }
}
