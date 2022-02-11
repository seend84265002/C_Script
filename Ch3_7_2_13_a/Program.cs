using System;

namespace Ch3_7_2_13_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7 };
            DisplayArray(intArray,doubleArray);

            Program AA = new Program();
            AA.DisplayArray(intArray);
            AA.DisplayArray<double>(doubleArray);
            Console.Read();

            
        }


        void DisplayArray<T>(T[] inputArray)
        {
            foreach( var a in inputArray)
            {
                Console.Write($"{a,8}");
            }
            Console.WriteLine();
        }
        static void DisplayArray<T,V>(T[] inputArray,V[] inputA)
        {
            foreach (var e in inputArray)
            {
                Console.Write($"{e,8}" );
                
            }
            Console.WriteLine();
            foreach (var v in inputA)
            {
                Console.Write ($"{v,8 }");
            }
            Console.WriteLine();
        } 
    }
}
