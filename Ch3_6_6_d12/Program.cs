using System;

namespace Ch3_6_6_d12
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMSG("Welcome to YMTC C# Programming");
            PrintMSG(100);
            PrintMSG("It is Good", 100);
            Console.Read();
        }

        static void PrintMSG(string s)
        {
            Console.WriteLine(s);
        }
        static void PrintMSG(int i)
        {
            Console.WriteLine(i);
        }
        static void PrintMSG(string s,int i)
        {
            Console.WriteLine(s + " " + i);
        }

    }
}
