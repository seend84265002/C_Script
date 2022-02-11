using System;

namespace Ch8_1_1
{
    class Program
    {
        static void Main(string[] args)
        {/*
            string str = "Hello World!";
            Console.WriteLine(str);
            Console.WriteLine(str.Length);

            str = "ASP.Net";
            Console.WriteLine(str);
            Console.WriteLine(str.Length);
            */
            string str = "    TEST    ";
            //str.ToLower();          //字串不會改變
            //Console.WriteLine(str);

            string str2="";
            //str2 = str.ToLower();
            //Console.WriteLine(str2);
            str = str.ToLower();//變小寫
            Console.WriteLine(str);
            Console.WriteLine("------------------------------");
            str = str.ToUpper();
            Console.WriteLine(str);
            Console.WriteLine("------------------------------");
            str = str.TrimEnd();
            Console.WriteLine(str);
            Console.WriteLine("------------------------------");
            str = str.Trim();
            Console.WriteLine(str);


        }
    }
}
