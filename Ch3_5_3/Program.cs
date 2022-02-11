using System;

namespace Ch3_5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum = 1200;
            String str1 = "200";
            String str2 = "150";
            String str ;

            str = sum.ToString();

            Console.WriteLine("int sum 1200 Convert to String: \"" + str + "\"");

            a = Convert.ToInt32(str1);
            b = Convert.ToInt32(str2);

            sum = a + b;

            Console.WriteLine(str1 +" + " +str2 + " Convert to Int: " + sum);

            Console.ReadLine();
        }
    }
}
