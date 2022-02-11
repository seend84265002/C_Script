using System;

namespace Ch3_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("plase iput x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y=x++的y值為:" + (y = x++ ));
            Console.WriteLine("y=++x的y值為:" + (y = ++x ));
            Console.WriteLine("y=x--的y值為:" + (y = x-- ));
            Console.WriteLine("y=--x的y值為:" + (y = --x ));
        }
    }
}
