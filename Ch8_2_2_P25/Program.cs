using System;

namespace Ch8_2_2_P25
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] ints = { 1, 2, 3, 4,5 };
            Console.WriteLine(ints.GetLength(0));       //5 
            Console.WriteLine(ints.Length);             //5 
            Console.WriteLine(ints.Rank);               //1
            Console.WriteLine(ints.GetLowerBound(0));   //0
            Console.WriteLine(ints.GetUpperBound(0));   //4    
            Console.WriteLine(ints.GetType());   //int32

            /*foreach (var e in ints)
            {
                Console.WriteLine(e);
            }*/
            string[] strs = { "Andy", "Bill", "Croal" ,"Davil","Eric"};
            Console.WriteLine(strs.GetLength(0));       //5 
            Console.WriteLine(strs.Length);             //5 
            Console.WriteLine(strs.Rank);               //1
            Console.WriteLine(strs.GetLowerBound(0));   //0
            Console.WriteLine(strs.GetUpperBound(0));   //4    
            Console.WriteLine(strs.GetType());   //string

            /*foreach (var e in str)
            {
                Console.WriteLine(e);
            }*/

        }
    }
}
