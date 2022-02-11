using System;

namespace Ch3_7_2_9
{
    abstract class Employee
    {
        public abstract void work();        //abstract 抽象的  繼承父親 一定要實作
        public virtual void vwork() { } //virtual 虛擬的 繼承父親不一定要實作

    }

    class HourlyEmployee : Employee
    {
        public override void work()
        {
            Console.WriteLine ("I am HorlyEmployee!");
        }
    }

    class GeneralEmployee : Employee
    {
        public override void work()
        {
            Console.WriteLine("I am GeneralEmployee!");
        }
    }
    class ProgramEmployee : Employee
    {
        public override void work()
        {
            Console.WriteLine("I am ProgramEmployee!");
        }
    }
    class CS_ProgramEmployee : ProgramEmployee
    {
        public override void work()
        {
            Console.WriteLine("I am CS_ProgramEmployee!");
        }
        public override void vwork()
        {
            Console.WriteLine("I am CS_ProgramEmployee with vwork!");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee Hour = new HourlyEmployee();
            Hour.work();
            Employee Gener = new GeneralEmployee();
            Gener.work();
            Employee pEmp = new ProgramEmployee();
            pEmp.work();
            Employee CsEmp = new CS_ProgramEmployee();
            CsEmp.work();
            CsEmp.vwork();

            Console.Read();
        }
    }
}
