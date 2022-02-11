using System;

namespace Ch3_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahr, cals;
            Console.WriteLine("plase input fahr:");
            fahr = Convert.ToDouble(Console.ReadLine());
            cals = (5.0 / 9.0) * (fahr - 32);
            Console.WriteLine("華氏" + fahr + "度" + "=" + "攝氏" + cals + "度");

            Console.WriteLine("plase input cals:");
            cals = Convert.ToDouble(Console.ReadLine());
            fahr = ( 9.0 * cals ) / 5.0 + 32 ;

            Console.WriteLine("攝氏" + cals + "度" + "=" + "華氏" + fahr + "度");

            Console.Read();
        }
    }
}
