using System;
using System.Collections.Generic;

namespace Ch3_7_2_18
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1,5 ,3,11, 8, 1,2 };
            showElements(numbers);

            Console.WriteLine(numbers[4]);

            numbers.Sort();                     //排序 小到大
            showElements(numbers);

            numbers.Reverse();                  //排序 反轉  大到小
            showElements(numbers);

            void showElements( List<int> numbers)
            {
                foreach ( var e in numbers) Console.Write(e + " ");
                Console.WriteLine();
            }
        }
    }
}
