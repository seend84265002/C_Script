using System;

namespace Ch3_6_5_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    Console.Write("@");
                }Console.Write("\n");
            }

            for (i = 4; i > 0; i--)
            {
                for (j = 1; j <= i ; j++)
                {
                    Console.Write("@");
                }Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
