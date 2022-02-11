using System;

namespace Ch3_6_6_d5
{
    class Program
    {
        int x = 0;          
        int y = 0;
        static void Main(string[] args)             //Method ,static Method
        {
            PrintMG("Hello","C# Programing");
            Console.Read();
        }

        static void PrintMG(string s1,string s2)        //Method Sigature   //overload 多載
        {
            Console.WriteLine(s1 + " " + s2);
            
        }
    }
}
