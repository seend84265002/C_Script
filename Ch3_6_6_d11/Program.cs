//#define OUT_P
#define REF_P
using System;

namespace Ch3_6_6_d11
{
    class Program
    {
#if OUT_P
        static void Main(string[] args)
        {
            int frist, second;
            InputMethod(out frist, out second);
            Console.WriteLine("frist is {0} and second is {1} ",frist,second);
            Console.Read();

        }

        static void InputMethod(out int one ,out int two)
        {
            Console.WriteLine("please input frist integer: ");
            String s1, s2;
            s1 = Console.ReadLine();
            Console.WriteLine("Please input second integer: ");
            s2 = Console.ReadLine();

            one = Convert.ToInt32(s1);
            two = Convert.ToInt32(s2);
        }
#endif
#if REF_P
        static void Main(string[] args)
        {
            int frist=0, second=0;
            InputMethod(ref frist, ref second);
            Console.WriteLine("After InputMethod frist is {0}", frist );
            Console.WriteLine("and second is {0} ", second);
            Console.Read();

        }

        static void InputMethod(ref int one, ref int two)
        {
            Console.WriteLine("please input frist integer: ");
            String s1, s2;
            s1 = Console.ReadLine();
            Console.WriteLine("Please input second integer: ");
            s2 = Console.ReadLine();

            one = Convert.ToInt32(s1);
            two = Convert.ToInt32(s2);
        }
#endif

    }
}
