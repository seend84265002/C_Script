using System;
using System.Threading;

namespace Ch12__P35_
{
    class ThreadTest
    {
        bool done = false;
        static void Main(string[] args)
        {
            ThreadTest tt = new ThreadTest();
            ThreadTest ss = new ThreadTest();
            new Thread(tt.Go).Start();
            new Thread(ss.Go).Start();
            tt.Go();
        }

        void Go()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Job is finished");
            }
        }
    }
}
