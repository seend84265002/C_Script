using System;

namespace Ch9_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(12, "成小安", 95, 75);
            Console.WriteLine(s.GetStudent());
        }
    }

    public  class  Student
    {
        private int ID;
        private string Name;
        private Test Scorce;
        public  Student(int i,string n,int m ,int f)
        {
            ID = i;
            Name = n;
            Scorce = new Test(m, f);
            
        }
        public string GetStudent() {
             return "學號: " + ID + "\n" + "姓名: " + Name + "\n" +"中成績: "+Scorce.Mid+"\n"+"末成績: "+Scorce.Final;
           
        }

        class Test
        {

            public int Mid { get; set; }
            public int Final { get; set; }
            public Test(int m, int f)
            {
                Mid = m;
                Final = f;
            }
        }


    }
}
