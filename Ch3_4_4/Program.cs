using System;

namespace Ch3_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0b0011_1100;
            int b = 0b0000_1111;
            int c = 0b0000_0011;
            int d = 0b0111_1000;
            
            int f = 0b0000_0011;
            int g = 0b0111_1000;

            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
            Console.WriteLine("d=" + d);
            Console.WriteLine("-----------------------" );

            int r;
            r = a & b;
            Console.WriteLine("a & b = " + r);
            r = a | c;
            Console.WriteLine("a | c = " + r);
            r = a ^ d;
            Console.WriteLine("a ^ d = " + r);
            Console.WriteLine("-----------------------");

            Console.WriteLine("f = "+f);
            Console.WriteLine("f <<1 = " + (f<<1));
            Console.WriteLine("f <<2 = " + (f<<2));
            Console.WriteLine("-----------------------" );

            Console.WriteLine("g = " + g);
            Console.WriteLine("g >>1 = " + (g>>1));
            Console.WriteLine("g >>2 = " + (g>>2));


            Console.WriteLine("Hello World!");
        }
    }
}
