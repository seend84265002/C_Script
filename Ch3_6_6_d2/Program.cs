using System;


namespace Ch3_6_6_d2
{
    class Program
    {
        static void Main(string[] args)
        {
            Myprint();  //靜態方法 所以可以直接使用 不用宣告變數
            Console.Read();
        }
        static void Myprint()
        {
            Console.WriteLine("This is your Static Method");
        }
    }
}
