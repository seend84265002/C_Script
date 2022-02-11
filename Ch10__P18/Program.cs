using System;

namespace Ch10__P18
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new SalesPerson(101, "Andy", 25000);
            //Console.WriteLine(p1.GetName());
            //Console.WriteLine(p1.Info());

            Console.WriteLine(((SalesPerson)p1).GetName());
            Console.WriteLine(p1.Info());
        }
    }

    class Person
    {
        public int ID;
        public string Name;
        public Person(int id,string name)
        {
            ID = id;
            Name = name;
        }
        public string GetName()
        {
            return "姓名:" + Name +" By Person General"; //一般方法
        }
        public virtual string Info()
        {
            return "身分證:" + ID + "\n" + "姓名:" + Name +"\t"+ " By Person Virtual";   //虛擬方法
        }

    }

    class SalesPerson : Person
    {
        private int Sales;
        public SalesPerson (int id,string n ,int s) : base(id, n)
        {
            Sales = s;
        }
        public new string GetName()
        {
            return base.GetName()+" "+"銷售額:" + Sales + " By SalesPerson General";   //一般新方法
        }
        public override string Info()
        {
            return "銷售額:" + Sales + " By SalesPerson override";    //複寫的方法
        }



    }
}
