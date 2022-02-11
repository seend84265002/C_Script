using System;

namespace Ch12__P23
{
    delegate void Mydelegate(string str);   //委派
    class Program
    {
        static void Main(string[] args)
        {
            MyPrint myp = new MyPrint();
            Mydelegate mydel = new Mydelegate(Print);   //一般呼叫
            mydel("Today is Frist ");

            mydel = Program.Print2;             //簡寫呼叫
            mydel("Today is Frist ");

            mydel = Print3;                     //簡寫呼叫
            mydel("Today is Frist ");

            mydel = myp.Print4;
            mydel("Today is Frist ");

        }

        static void Print(string s)
        {
            Console.WriteLine(s);
        }

        static void Print2(string s)
        {
            Console.WriteLine(s + "Hello 2");
        }

        static void Print3(string s)
        {
            Console.WriteLine(s + "Hello 3");
        }
    }

    class MyPrint
    {
        public void Print4(string s)
        {
            Console.WriteLine(s + "Hello 4");
        }
    }
}
