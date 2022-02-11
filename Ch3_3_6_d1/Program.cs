using System;

namespace Ch3_6_6_d1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program _Program = new Program();
            _Program.Myprint();
            Console.Read();
        }

        void Myprint()      //實體方法  要使用宣告方式來使用
        {
            Console.WriteLine("This is your Frist Instand Method");
        }
    }
}
