using System;

namespace Ch9_P62
{
    class Program
    {
        static void Main(string[] args)
        {
            Student joe = new Student(1, "Andy Su");
            Student john = new Student(2, "陳小刀");
            Console.WriteLine(joe.GetStudent());
            Console.WriteLine(john.GetStudent());
            joe.nothing();
        }
    }

    interface Base      //抽象介面
    {
        public abstract void nothing();   //public abstract  可寫可不寫
                                          //因為介面是提供(協議)protocols. 是給別人用的。所以要公開。
    }

    struct Student : Base       //繼承 Base
    {
        public int StdID;
        public string Name;
        public void nothing()
        {
            Console.WriteLine("繼承 實作 抽象介面");
        }
        public Student(int id ,string name)
        {
            StdID = id;
            Name = name;
        }
        public string GetStudent()
        {
            string res = "";
            res += "學號: " + StdID + "\n";
            res += "姓名: " + Name + "\n";
            return res;
        }
    
    }

}
