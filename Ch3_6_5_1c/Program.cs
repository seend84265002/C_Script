using System;

namespace Ch3_6_5_1c
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, blank = 0, str = 0;
            #region for 迴圈

            for (  i = 0; i < 5; i++)
            {
                for(blank = 1; blank < 5-i; blank++)
                {
                    Console.Write(" ");
                }
                for(str =0; str < 2 * i + 1;str++)
                {
                    Console.Write("#");
                }Console.WriteLine();
            }    
            for( i = 4; i > 0; i--)
            {
                for(blank = 4; blank >= i; blank--)
                {
                    Console.Write(" ");
                }
                for(str = 0; str < 2 * i - 1; str++)
                {
                    Console.Write("$");
                }Console.WriteLine();
            }
            Console.ReadLine();
            
            #endregion
            #region while
            
            while (i < 5) {
                while (blank < 4 - i)
                {
                    Console.Write(" ");
                    blank++;
                } blank = 0;
                while (str < 2 * i + 1)
                {
                    Console.Write("@");
                    str++;
                } str = 0;
                i++;
                Console.WriteLine();
            }
            i = 0;
            while (i < 4)
            {
                while (blank <= i)
                {
                    Console.Write(" ");
                    blank++;
                }
                blank = 0;
                while (str < 7 - 2 * i)
                {
                    Console.Write("#");
                    str++;
                }
                str = 0;
                i++;
                Console.WriteLine();
            }
            Console.Read();
            #endregion
        }
    }

}