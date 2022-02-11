using System;

namespace Ch3_7_1_13
{
    class Employee
    {
        public int Idnumber { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            Idnumber = 5566;
            Salary = 34567.8989;
            Console.WriteLine("Employee #{0,6} Created. Salary is {1,10}" ,Idnumber,Salary.ToString("#0.00"));
            
        }
        class objectInitializerDemo
        {
            static void Main(string[] args)
            {
                Employee aWorker = new Employee() { Idnumber = 123 ,Salary=7766.6677};   //先執行Employess呼叫 再把值帶進變數裏
                Console.WriteLine("Employee #{0,6} exists.  Salary is {1,10}", aWorker.Idnumber, aWorker.Salary.ToString("#0.00"));
                Console.ReadLine();
            }
        }
       
    }
}
