using System;

namespace Ch3_7_2_7
{
    public abstract class Employee
    {
        public String Firstname { get; }
        public String Lastname { get; }
        public String SSN{ get; }
        public Employee(string firstname,string lastname,string ssn)
        {
            Firstname = firstname;
            Lastname = lastname;
            SSN = ssn;
        }
        public abstract decimal Earings();
    }

    public class SalariedEmloyee : Employee
    {
        private decimal WeeklySalary { get; set; }
        public SalariedEmloyee(string firstname,string lastname,string ssn, decimal WeelySalary): base (firstname,lastname,ssn)
        {
            WeeklySalary = WeeklySalary;
        }
        public override decimal Earings() { return WeeklySalary; }
   
    }
    public class HourlyEmlopyee : Employee
    {
        private decimal Wage { get; set; }
        private decimal Hours { get; set; }
        public HourlyEmlopyee(string firstname, string lastname, string ssn, decimal Wage, decimal Hours) : base (firstname,lastname,ssn)
        {
            Wage = Wage;
            Hours = Hours;
        }
        public override decimal Earings() { return Wage * Hours; }         
        
    }

    public class ComissionEmployee : Employee
    {
        private decimal GrossSale { get; set; }
        private decimal CommissionRota { get; set; }
        public ComissionEmployee(string firstname ,string lastname,string ssn ,decimal GrossSale,decimal CommissionRota) : base (firstname,lastname,ssn)
        {
            GrossSale = GrossSale;
            CommissionRota = CommissionRota;
        }
        public override decimal Earings() { return GrossSale * CommissionRota; }
    }


    class program
    {
        static void Main(string[] args)
        {
            Employee sEmp = new SalariedEmloyee("sala", "blama", "111-111-111", 800.50M);
            Employee hEmp = new HourlyEmlopyee("Henrry", "Lu", "222-222-222", 16.75M, 40.0M);
            Employee cEmp = new ComissionEmployee("carol", "Wang", "333-333-333", 10000.75M, 0.07M);

            Console.WriteLine($"{sEmp} + @@ + {sEmp.Earings()}");

            /*SalariedEmloyee sEmp = new SalariedEmloyee("sala", "blama", "111-111-111", 800.50M);
            HourlyEmlopyee hEmp = new HourlyEmlopyee("Henrry", "Lu", "222-222-222", 16.75M, 40.0M);
            ComissionEmployee cEmp = new ComissionEmployee("carol", "Wang", "333-333-333", 10000.75M, 0.07M);*/
           
        }
    }
    
}
