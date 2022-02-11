using System;

namespace Ch3_7_2_2
{
    class Program
    {
        class Employee
        {
            public int Idnum { get; set; }
            protected double salary;
            public double Salary
            {
                get { return salary; }
                set { salary = (value < 25000) ? 25000 : value; }
            }
            public string GetGreeting()
            {return "Hello. I am Employee # " + Idnum;}
        }
        class CommissionEmployee : Employee   //繼承
        {
            private double commissionRate;
            public double CommissionRate
            {
                get { return commissionRate; }
                set { commissionRate = value;salary = (salary < 30000) ? 30000 : salary ; }
            }
        }

        static void Main(string[] args)
        {
            Employee accountant = new Employee();
            CommissionEmployee sales = new CommissionEmployee();
            accountant.Idnum = 123;
            accountant.Salary = 30000.00;
            sales.Idnum = 456;
            sales.Salary = 24000.00;
            sales.CommissionRate = 0.07;
            

            Console.WriteLine("\n" + accountant.GetGreeting());
            Console.WriteLine("accountant ID : " + accountant.Idnum + " accountant Salary " + accountant.Salary);

            Console.WriteLine("\n" + sales.GetGreeting());
            Console.WriteLine("sales ID : " + sales.Idnum + " sales Salary = " + sales.Salary + " sales CommissionRate = " + sales.CommissionRate);
            Console.Read();

        }
    }
}
