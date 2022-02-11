using System;

namespace Ch3_C_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 5.0;
            int number=0;

            for (; i >= 0.2; number++)
            {
                i /= 2;              
            }
            Console.WriteLine("5公尺繩子要對折幾次會小於20公分 : "+ number +" 次 "+"\n" +"繩子長度為 : " + i*100 +"公分");
            Console.Read();

            //while (true)
            //{
            //    i /= 2;
            //    number++;
            //    if (i <= 0.2) break;
            //}
            //Console.WriteLine(number);
        }
    }
}
