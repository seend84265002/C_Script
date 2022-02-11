using System;

namespace Ch10__P11
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student(101, "Andy", 89); 
        }
    }

    class Person
    {
        public int ID;
        public string Name;
        public Person(int id ,string name)                                     //先呼叫
        {
            ID = id;
            Name = name;
            Console.WriteLine("Person SCTOR is called");        
        }
        public Person()
        {
            Console.WriteLine("Person DCTOR is called");
        }
        
    }
    class Student : Person
    {
        public int Score;
        public Student(int id,string name ,int score)  :base (id,name)          //後呼叫
        {
            ID = id;
            Name= name;
            
            Score = score;
            Console.WriteLine("Student SCTOR is Called");      
        }
    }
}
