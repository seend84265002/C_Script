using System;
using System.Collections.Generic;

namespace Ch3_7_2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //var numbers2 = new List<double>{ 1.1, 2.2, 3.3, };
            var numbers = new  List<int>{ 1, 2, 3 } ; showElements();
            numbers.Add(5);showElements();                                  // 最後一個數後面 增加一個數5
            numbers.AddRange(new int[] { 7, 11 });showElements();           // 最後一個數後面 增加一個陣列 數
            numbers.Insert(5, 1);showElements();                            // 在陣列第5個位子 增加一個1的數
            numbers.Insert(4, 22);showElements();                           // 在陣列第4個位子 增加一個22的數 
            numbers.InsertRange(1, new int[] { 5, 7, 6 });showElements();   // 在陣列第1個位子 增加一個陣列 數 
            Console.Read();
            void showElements()
        {
                foreach (var e in numbers)
                {
                    Console.Write(e + " ");
                }Console.WriteLine();
        }
        
        }
    
    }
}
