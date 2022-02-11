using System;

namespace Ch3_6_3

{
    class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Hello");

            sb.Append(" World");
            Console.WriteLine("sb is " + sb);

            sb.Remove(0, 5);
            Console.WriteLine("sb is " + sb);

            sb.Insert(0, "Bye");
            Console.WriteLine("sb is " + sb);

            string s = sb.ToString();
            Console.WriteLine("s is " + s);

            Console.ReadLine();
        }
    }
}
