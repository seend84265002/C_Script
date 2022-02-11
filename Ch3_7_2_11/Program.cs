using System;

namespace Ch3_7_2_11
{
    abstract class Employee
    {
        public abstract string Name { get; }
    }

    class HoursEmployee : Employee
    {
        public override string Name { get; }



    }


    class Program
    {
        
        static void Main(string[] args)
        {
            Employee hemp = new HoursEmployee();
            String S1= "GOGO";
            hemp.Name = S1;
            Console.WriteLine("The Hourly Employee Name is : " + hemp.Name);
        }
    }
}
