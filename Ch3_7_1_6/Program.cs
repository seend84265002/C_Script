using System;

namespace Ch3_7_1_6
{
    class CreatEmployee3
    {
        static void Main(string[] args)
        {
            Employee aWorker = new Employee();
            aWorker.IdNumber = 7788;
            aWorker.Selary = 100.55;
            Console.WriteLine("Employee is #{0} make @{1} ", aWorker.IdNumber, aWorker.Selary);
            Console.ReadLine();
        }

    }

    class Employee
    {
        public int IdNumber { get; set; }
        public double Selary { get; set; }
    }
}
