using System;

namespace Ch11__P17
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales q1 = new Sales(2345.6, 250);
            Sales q2 = new Sales(1234.5, 150);
            Sales total;
            total = q1 + q2;
            Console.WriteLine("Earnings: "+ total.Earnings +" "+ "SoldedItems: " + total.SoldedItems);
        }
    }

    class Sales
    {
        public double Earnings;
        public int SoldedItems;
        public static Sales operator+(Sales s1 ,Sales s2)
        {
            Sales s = new Sales(0.0, 0);
            s.Earnings = s1.Earnings + s2.Earnings;
            s.SoldedItems = s1.SoldedItems + s1.SoldedItems;
            return s;
        }

        public Sales(double e, int i)
        {
            Earnings = e;
            SoldedItems = i;
        }
    }
}
