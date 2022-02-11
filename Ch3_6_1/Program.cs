using System;

namespace Ch3_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double half_d = Math.Pow(2, 30);   //2^30

            int half_i = (int)half_d;
            int half_i1 = half_i - 1;

            int myInt32 = half_i + half_i1;
            int myInt32_MAX = int.MaxValue;
            Console.WriteLine("myInt32 is " + myInt32 + " and myInt32_MAX is " + myInt32_MAX);

            myInt32 = myInt32 + 1;
            int myInt32_MIN = int.MinValue;
            Console.WriteLine("myInt32 is " + myInt32 + " and myInt32_MIN is " + myInt32_MIN);

            double half_dd = Math.Pow(2,62);    //2^62
            long half_ii = (long)half_dd;   
            long half_ii1 = half_ii - 1;    
            long myInt64 = half_ii + half_ii1;
            long myInt64_MAX = long.MaxValue;
            Console.WriteLine("myInt64 is " + myInt64 + " and myInt32_MAX is " + myInt64_MAX);

            myInt64 = myInt64 + 1;
            long myInt64_MIN = long.MinValue;
            Console.WriteLine("myInt64 is " + myInt64 + " and myInt64_MIN is " + myInt64_MIN);


            Console.ReadLine();
        }
    }
}
