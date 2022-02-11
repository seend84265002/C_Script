using System;

namespace Ch3_7_2_1
{
    class Program
    {
        class Employee
        {
            public int Idnum { get; set; }
            public double Salary { get; set; }
            public string GetGreeting()
            {
                return "Hello. I am Employee # " + Idnum;
            }
        }
        class CommissionEmployee : Employee   //繼承
        {
            public double CommissionRate { get; set; }
        }

        static void Main(string[] args)
        {
            Employee accountant = new Employee();
            CommissionEmployee sales = new CommissionEmployee();
            accountant.Idnum = 123;
            accountant.Salary = 30000.00;
            sales.Idnum = 456;
            sales.Salary = 22000.00;
            sales.CommissionRate = 0.07;

            Console.WriteLine("\n" + accountant.GetGreeting());
            Console.WriteLine($"accountant ID : { accountant.Idnum } accountant Salary {accountant.Salary}");

            Console.WriteLine("\n" + sales.GetGreeting());
            Console.WriteLine($"sales ID : { sales.Idnum ,4}  sales Salary = {sales.Salary.ToString("0.0"),8} sales CommissionRate = {sales.CommissionRate}");
            Console.Read();

        }
    }
}
