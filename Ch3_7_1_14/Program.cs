using System;

namespace Ch3_7_1_14
{
    class Employee
    {
        public int Idnumber { get; set; }
        public double Salary { get; set; }
        public double AA;
       /* public Employee()
        {
            Idnumber = 5566;
            Salary = 34567.8989;
            Console.WriteLine("Employee #{0,6} Created. Salary is {1,10}", Idnumber, Salary.ToString("#0.00"));

        }*/
        class objectInitializerDemo
        {
            static void Main(string[] args)
            {
                Employee aWorker = new Employee() { Idnumber = 456, Salary = 56789.1288 ,AA=50.55};//先執行Employess呼叫 再把值帶進變數裏
                //aWorker.AA = 55.55;
                Console.WriteLine("Employee #{0} exists.  Salary is {1,10}  AA is {2,6}", aWorker.Idnumber, aWorker.Salary.ToString("#0.00"),aWorker.AA);
                Console.ReadLine();
            }
        }

    }
}
