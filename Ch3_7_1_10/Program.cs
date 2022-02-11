using System;

namespace Ch3_7_1_10
{
    class Employee
    {
        public int IdNumber { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            IdNumber = 999;
            Salary = 0;
        }
        public Employee(int empID)
        {
            IdNumber = empID;
            Salary = 0;
        }
        public Employee(int empID,int sal)
        {
            IdNumber = empID;
            Salary = sal;
        }
        public Employee(char code)
        {
            IdNumber = 1999;
            Salary = 100000;
        }
        static void Main(string[] args)
        {
            Employee aWorker = new Employee();
            Employee anotherWorker = new Employee(24, 99);
            Employee bossWorker = new Employee('8');
            Console.WriteLine("{0,5} {1,10}", aWorker.IdNumber, aWorker.Salary);
            Console.WriteLine("{0,5} {1,10}", anotherWorker.IdNumber,anotherWorker.Salary);
            Console.WriteLine("{0,5} {1,10}", bossWorker.IdNumber,bossWorker.Salary);
            Console.ReadLine();
        }
    }
}
