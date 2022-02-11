using System;
using System.Collections.Generic;

namespace Ch3_7_2_16_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new List<double> { 0.2,0.5,0.6,0.7}; showElements();
            number.RemoveRange(1, 2); showElements();
            Console.Read();

            void showElements()
            {
                foreach (var e in number)
                {
                    Console.Write(e + " ");
                }Console.WriteLine();
            }

        }
    }
}
