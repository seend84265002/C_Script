using System;

namespace Ch_3_6_5_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i, sum=0;
            
            for(i = 1; i <= 10; i++)
            {
                sum += i * i;
                
            }
            Console.WriteLine("for loop_1*1+2*2+3*3+...+10*10= " + sum);

            i = 1; sum = 0;
            while (i <= 10)
            {
                
                sum += i * i;
                i++;
            }
            Console.WriteLine("while loop_1*1+2*2+3*3+...+10*10= " + sum);

            i = 1; sum = 0;
            do
            {
                sum += i * i;
                i++;
            } while (i <= 10);
            Console.WriteLine("do while loop_1*1+2*2+3*3+...+10*10= " + sum);
            Console.ReadLine();
            */
            int i = 0, sum = 0;
            for (; ++i < 11; sum += i * i) ;   
            Console.WriteLine("for =" + sum);
            //i = 0; sum = 0;
            while ( i-- > 1)
                sum += i * i; 
            Console.WriteLine("while =" + sum/2);
            Console.Read();
            
        }

    }
}
