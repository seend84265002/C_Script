using System;

namespace Ch3_7_1_4
{
    class Program
    {
        private static int Men3;
        class D
        {
            public int Mem1;                //需要宣告一個變數 才可以呼叫
            public static int Men2;         //靜態只能class 自己呼叫
        }
        static void Main(string[] args)
        {
            D d1 = new D();
            D d2 = new D();

            d1.Mem1 = 1;
            D.Men2 = 22;
            Console.WriteLine(@"d1's Mem1 is : " + d1.Mem1 + " " + @"d1's Mem2 is :" + D.Men2);
            d2.Mem1 = 2;
            Program.Men3 = D.Men2+11;
            Console.WriteLine(@"d2's Mem1 is : " + d2.Mem1 + " " + @"d2's Mem3 is :" + Program.Men3);
            Console.Read();
        }
    }
}
