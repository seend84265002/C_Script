using System;

namespace Ch3_6_6_d3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program _pro = new Program();   //_pro.SayHello_();       //Program.Saytt();
            _SayHello.SayHello();
            SayHelloWorld();
            Console.Read();
        }

        private static void SayHelloWorld()     //私有的靜態 只有自己的class 可以使用
        {
            Console.WriteLine("Hello World!");
        }

        internal static void Saytt()    //靜態不用宣告  只要class名稱.方法名稱()就可以使用
        {
            Console.WriteLine("Hello World!  Saytt");
        }

        internal void SayHello_() {     //非靜態要宣告
            Console.WriteLine("Hello World! SayHello_");
        }

    }
    class _SayHello
    {
        internal static void SayHello()
        {
            Program _pro = new Program();
            Console.WriteLine("Hello World!  _SayHello");
            Program.Saytt();
            _pro.SayHello_();
        }
    }

}
