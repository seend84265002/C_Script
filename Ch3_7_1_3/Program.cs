using System;

namespace Ch3_7_1_3
{
    class Employee
    {
        private int idNum;
        public void WelcomeNs()
        {
            Console.WriteLine("Welcome form Employee #{0}", idNum);
            Console.WriteLine("How cam I help You?");
        }
        Employee(int id)
        {
            idNum = id;
        }
        static void Main(string[] args)
        {
            Employee aWork = new Employee(10);
            Employee another = new Employee(20);
            DisplayEmployessDate("Frist", aWork);
            DisplayEmployessDate("secound", another);
            Console.Read();


        }

        static void DisplayEmployessDate(string order, Employee emp)
        {
            Console.WriteLine("\n{0} employee's message :  " , order);
            emp.WelcomeNs();
        }

    }
}
