using System;

namespace Ch3_7_1_12
{
    class Employee
    {
        private readonly int idNumber;
        public Employee(int id)
        {
            idNumber = id;
        }
        public int IdNumber { get{ return idNumber; } }
        static void Main(string[] args)
        {
            Employee myAssistant = new Employee(3456);
            Employee myDrives = new Employee(5432);
            Console.WriteLine("myAssistant ID is : " +myAssistant.idNumber);
            Console.WriteLine("myDrives ID is : "+ myDrives.idNumber);
            Console.ReadLine();
        }
    }
}
