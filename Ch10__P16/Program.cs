using System;

namespace Ch10__P16
{
    class Program
    {
        static void Main(string[] args)
        {
            Person std1 = new Student(101, "Andy", 90);
            Person std2 = new Student(201, "Bill", 82);
            Console.WriteLine(std1.getInfo());
            Console.WriteLine(std2.getInfo());

            Person s3 = new Student(303, "Carol",95);
            Person s4 = new Student(404, "David", 78);
            Console.WriteLine(s3.ggetInfo()); //呼叫父類別方法
            Console.WriteLine(s4.ggetInfo());

            Console.WriteLine(((Student)s3).ggetInfo()); //呼叫子類別法   
            Console.WriteLine(((Student)s4).ggetInfo());

        }
    }
    class Person
    {
        public int ID;
        public string Name;
        public Person(int id, string name)                                     //先呼叫
        {
            ID = id;
            Name = name;
            //Console.WriteLine("Person SCTOR is called");
        }
        public String ggetInfo() => ID.ToString() + " " + Name;         //一般方法
        public virtual string getInfo() => "學號: "+ID.ToString() +"\n"+ "姓名: " + Name+"\n";
        
           
        

    }
    class Student : Person
    {
        public int Score;
        public Student(int id, string name, int score) : base(id, name)          //後呼叫
        {
            Score = score;
            //Console.WriteLine("Student SCTOR is Called");
        }
        public new string ggetInfo() => Score.ToString();           //一般方法 改寫
        public override string getInfo() => "成績: "+ Score.ToString()+"\n"; 

    }
}
