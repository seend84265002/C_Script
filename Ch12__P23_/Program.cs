using System;

namespace Ch12__P23_
{
    class Program
    {
        delegate void Mydelegate(string s);//委派
        static void Main(string[] args)
        {
            Mydelegate an = delegate (string str)
             {
                 Console.WriteLine("Todey is Firday" + " " + str + " " + "using Anonymous Traget Function");
             };

            an("Hello");

            an = delegate (string str)
            {
                Console.WriteLine("Todey is Firday" + " " + str + " Hello 2 " + "using Anonymous Traget Function");
            };
            an("Good Things");

        }
    }
}
