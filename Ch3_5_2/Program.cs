using System;

namespace Ch3_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17, b = 7;
            float r;
            Console.WriteLine("a={0},b={1}", a, b);

            r = a / b;
            Console.WriteLine("r=a/b=" + r);

            r = (float)a / (float)b;
            Console.WriteLine("r=(float)a/(float)b=" + r.ToString("#0.000"));

            Console.ReadLine();
        }
    }
}
