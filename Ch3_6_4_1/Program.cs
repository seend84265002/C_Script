using System;

namespace Ch3_6_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x;
            x = new int[3];
            x[0] = 0;
            x[1] = 1;
            x[2] = 2;

            int[] y = new int[] { 3, 4, 5 };
            int[] z = { 6, 7, 8 };

            Console.WriteLine("x is " + x[0] +" "+ x[1] +" "+ x[2]);
            Console.WriteLine("y is " + y[0] +" "+ y[1] +" "+ y[2]);
            Console.WriteLine("z is " + z[0] +" "+ z[1] +" "+ z[2]);
            Console.ReadLine();
        }
    }
}
