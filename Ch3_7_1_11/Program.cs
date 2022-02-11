using System;

namespace Ch3_7_1_11
{
    class Employee
    {
        public int IdNumber { get; set; }
        public double Salary { get; set; }
        public Employee() : this(999, 0) { }
       
        public Employee(int empID):this(empID, 0) { }
     
         public Employee(int empID, int sal)
        {
            IdNumber = empID;
            Salary = sal;
        }
        
      
        public Employee(char code) : this(1999, 100000) { }
 
        static void Main(string[] args)
        {
            Employee aWorker = new Employee();
            Employee anotherWorker = new Employee(14, 999);
            Employee bossWorker = new Employee('8');
            Console.WriteLine("{0,5} {1,12}", aWorker.IdNumber, aWorker.Salary);
            Console.WriteLine("{0,5} {1,12}", anotherWorker.IdNumber, anotherWorker.Salary);
            Console.WriteLine("{0,5} {1,12}", bossWorker.IdNumber, bossWorker.Salary);
            Console.ReadLine();
        }
    }
}
