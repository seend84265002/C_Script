using System;
using System.Collections;

namespace Ch3_7_2_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10;
            var aList = new ArrayList();
            var rand = new Random();

            for (var index = 0; index < count; index++) aList.Add(rand.Next(100));   //產生1000以內10個亂數
            
            Console.WriteLine("aList Capacity : " + aList.Capacity);
            Console.WriteLine("aList Count : " + aList.Count);
            Console.WriteLine("aList IsFixedSize : " + aList.IsFixedSize);
            PrintArrayListContents(aList);
            aList.Sort();
            PrintArrayListContents(aList);

            aList.Reverse();
            PrintArrayListContents(aList);
            
            Console.WriteLine($"aList 第九個數 : {aList[9]}");
            
            object element = aList[9];
            aList.Remove(element);
            PrintArrayListContents(aList);
            
            aList.Clear();
            PrintArrayListContents(aList);


            Console.Read();
        }
        static void PrintArrayListContents(ArrayList aList)
        {
            foreach (var e in aList)
            {
                Console.Write($"{e,6}");
            }Console.WriteLine();
        }
    }
}
