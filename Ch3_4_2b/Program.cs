using System;

namespace Ch3_4_2b
{
    class Program
    {
        static void Main(string[] args)
        {
            double height, weigth, BMI;
            Console.WriteLine("plase input height:");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("plase input weigth:");
            weigth = Convert.ToDouble(Console.ReadLine());
            height /= 100;
            BMI = weigth / height / height;
            Console.WriteLine("BMI值為:" + BMI.ToString("#0.000"));

            Console.Read();
        }
    }
}
