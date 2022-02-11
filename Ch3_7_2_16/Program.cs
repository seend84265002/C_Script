using System;
using System.Collections.Generic;

namespace Ch3_7_2_16
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var numbers = new List<double> { 1.1, 13.3, 17.7, 19.9, 2.2, 3.3, 5.5, 7.7, 1.8, 1.5, 11.5 };showElements();
            numbers.Remove(19.9);showElements();                //把19.9 這個數字刪除
            numbers.RemoveRange(1, 2);showElements();           //第1個位置的數 往後刪除2個數 刪掉
            numbers.RemoveAt(1); showElements();                //把第一個數 刪掉
            numbers.RemoveAll(e => e < 10);showElements();      //數 符合條件的刪除
            numbers.Clear();showElements();                     //全部數 刪掉
            

            void showElements()
            {
                
                foreach (var e in numbers)
                {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
        }

        
    }
}
