using System;
using System.Threading;

namespace Ch12__P35
{
    class Program
    {
        static void Main(string[] args)     //Main Thread
        {
            Thread t = new Thread(new ThreadStart(WriteY));   //new another thread
            //Thread t = new Thread(WriteY);
            t.Start();
            WriteX();
           
            
        }
        static void WriteY()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }

        }
        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }
    }
}
