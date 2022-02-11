using System;

namespace Ch8_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World! Hello!";
            //str = str.Insert(0,"Hello World!");
            //Console.WriteLine(str);
            ////str = str.Remove(2, 2);
            ////Console.WriteLine(str);
            //Console.WriteLine("------------------------------");
            //str = str.Substring(2,6);
            //Console.WriteLine(str);
            int pos;
            pos = str.IndexOf("Hello");
            Console.WriteLine(pos);

            pos = str.LastIndexOf("Hello");
            Console.WriteLine(pos);

            string str1;
            str1 = str.Replace("Hello", "Welcome");
            Console.WriteLine(str);
            Console.WriteLine(str1);
        }
    }
}
