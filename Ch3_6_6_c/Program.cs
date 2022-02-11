using System;

namespace Ch3_6_6_c
{
    class Program
    {
        static void Main(string[] args)
        {
            double buy = 13.78;
            CalculateTax(buy);
            Console.Read();
        }
        private static void CalculateTax( double money)
        {
            double tax;
            const double Rate = 0.05;
            tax = money*Rate;
            Console.WriteLine("The tax on {0} is {1} : ",money.ToString("#0.0000")),tax.ToString("#0.0000");
        }
    }
}
