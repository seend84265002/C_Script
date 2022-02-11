using System;

namespace Ch3_7_2_23
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var employee = new Employee("John Doe",25000);

            Console.WriteLine($"{employee.Name}  earns  {employee.Salary}");
            employee.GiveRaise(20);
            Console.WriteLine($"{employee.Name}  earns  {employee.Salary}");
        }
        
    }

    class Employee
    {
        private string name;
        private double salary;
        public string Name { get { return name; } set { name = value; } }
        public double Salary { get {return salary; } set {salary =value; } }

        public Employee(string name ,double salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public void GiveRaise( double percent)
        {
            salary *= (1+percent/100.0);
        }
    }

}
