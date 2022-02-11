using System;

namespace Ch3_7_1_5
{
    class Employee
    {
        private int idNumber;
        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
        public void WelcomeMessage()
        {
            Console.WriteLine("welcome from Employess #{0} @{1}", IdNumber,idNumber);
            Console.WriteLine("How can I help you");
           
        }
        static void Main(string[] args)
        {
            Employee myChar = new Employee();
            myChar.IdNumber = 2345;
            Console.WriteLine("ID Number is {0} %{1}", myChar.IdNumber,myChar.idNumber);
            myChar.idNumber = 5566;
            myChar.WelcomeMessage();
            Console.Read();
        }
    }
}
