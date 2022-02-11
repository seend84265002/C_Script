using System;

namespace Ch3_C_4
{
    class Program
    {   
        static void Main(string[] args)
        {
            Answer_(2, 20);     
        }


        public static void Answer_(int a,int b)
        {
            int answer = 0;
             
            for (; a <= b; a++)
            {
                answer += a * (a - 1);
            }
            Console.WriteLine(answer);
        }

    }
}
