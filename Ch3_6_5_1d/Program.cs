using System;

namespace Ch3_6_5_1d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach( int n in a){
                
                if (n == 9) break;
                if (n == 5 || n == 6) continue;
                
                Console.Write( n );
                
            }
                       
            Console.ReadLine();

        }
    }
}
