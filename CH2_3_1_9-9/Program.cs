using System;

namespace CH2_3_1_9_9
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 1; i < 10; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}x{i}={j * i}\t");
                }Console.WriteLine();
            }Console.Read();
        }
    }
}
