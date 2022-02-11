using System;

namespace Ch3_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            Console.WriteLine("Please Input circie radius:");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Circle radius is " + r);
            Console.WriteLine("Circle Area is " + (r*r*PI));
            Console.WriteLine("Circle Area is " + (r * r * PI).ToString("#0.0000"));
            Console.ReadLine();
        }
    }
}
