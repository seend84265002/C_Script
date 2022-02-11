using System;
using System.Collections.Generic;

namespace Ch3_7_2_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 5, 7, 11, 9, 4, 6, 8, 11, 10 }; showElements(numbers);
            var a = numbers.FindAll(e => e < 10); showElements(a);               //找全部小於10的數    
            Console.WriteLine($"{numbers.Find(e => e < 10)}");                   //找第一個小於10的數     1
            Console.WriteLine($"{numbers.FindIndex(e => e < 10)}");              //找第一個小於10的數 位址  為第0位
            Console.WriteLine($"{numbers.FindLast(e => e < 10)}");               //找最後一個小於10的數     8
            Console.WriteLine($"{numbers.FindLastIndex(e => e < 10)}");          //找最後一個小於10的數 位址  為第9位
            Console.WriteLine($"{numbers.IndexOf(5)}");                         //找第一個5個數 位址   為3       
            Console.WriteLine($"{numbers.LastIndexOf(11)}");                    //找最後一個11的數 位址  為10    
            Console.WriteLine($"{numbers.BinarySearch(11)}");                   //找第一個11個數 位址   為 


            void showElements(List<int> num)
            {
                foreach( var e in num)
                {
                    Console.Write(e + " ");
                }Console.WriteLine();
            }
        }
    }
}
