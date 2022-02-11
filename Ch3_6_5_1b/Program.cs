using System;

namespace Ch3_6_5_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (j < (4-i))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                           
                
                }Console.WriteLine();
            }

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (j >= i)
                    {
                        Console.Write("$");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }




            Console.ReadLine();

        }
    }
}
