using System;

namespace Ch3_6_6_b
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello.SayHelloToWorld();
        }

    }

    class SayHello
    {
        internal static  void SayHelloToWorld()
        {
            Console.WriteLine("Say Hello");
        }
    }

}
