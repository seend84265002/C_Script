using System;

namespace Ch3_C_2
{
    class Program
    {
        static void Main(string[] args)
        {
        int i=0 ;
        while( i < 5){
                int j = 0;
                while (j < 5)
                {
                    if (j < (5-i))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    j++;
                }Console.WriteLine();
                i++;
            }Console.Read();
        }
    }
}
