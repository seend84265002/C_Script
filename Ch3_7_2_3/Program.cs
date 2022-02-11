using System;

namespace Ch3_7_2_12
{
    abstract class Employee
    {
        public abstract string Name { get; }
    }
    class HourlyEmployee : Employee
    {
        public override string Name { get; }
        public HourlyEmployee(string name)
        {
            Name = name;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hEmp = new HourlyEmployee("Henrry");
            Console.WriteLine("The hEmp's Name is : " + hEmp.Name);  //有單引號's 要在字串前面+@ 
        }
    }
}
