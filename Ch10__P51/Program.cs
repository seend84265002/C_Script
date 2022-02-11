using System;

namespace Ch10__P51
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.SetName("Andy");
            u.SetAddress("台北市");
            Console.WriteLine("Name: " + u.GetName() + " " + "地址: " + u.Address);

            Customer c = new Customer("John", "美國加州", "台灣桃園");
            Console.WriteLine("Name: "+c.GetName());
            
        }
    }

    class Person
    {
        public string Name;
        public string Address;
        public virtual string GetName() { return ""; }
        public virtual string GetAddress() { return ""; }
        public virtual void SetName(string n) { }
        public virtual void SetAddress(string a) { }
    }
    class User : Person
    {
        public sealed override string GetName() => Name;        //sealed 密封  不可以再被(複寫)實作
        public sealed override string GetAddress() 
        {
            return Address;
        }
        public sealed override void SetName(string n)
        {
            Name=n;
        }
        public sealed override void SetAddress(string a)
        {
            Address=a;
        }

    }

    sealed class Customer : User
    {
        public string ShippingAddress;
        public Customer(string n,string a,string s)
        {
            SetName(n);
            SetAddress(a);
            ShippingAddress = s;
        }
    } 

}
