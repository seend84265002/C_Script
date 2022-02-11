using System;

namespace Ch3_6_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,sum=0;
            
            for ( i = 1; i<= 10; i++)
            {
                sum += i;
            }

            Console.WriteLine("The for loop sum is " + sum);

            i = 1;
            sum = 0;
            while(i<=10){
                sum += i;
                i++;

            }
            Console.WriteLine("The while sum is " + sum);

            i = 1;
            sum = 0;
            do
            {
                sum += i;
                i++;
            } while (i <= 10);

            Console.WriteLine("The do while sum is " + sum);
            Console.ReadLine();

        }
    }
}
