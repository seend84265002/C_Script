using System;
using System.Collections;

namespace Ch3_7_2_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Queue");
            var queue = new Queue();

            queue.Enqueue("Andy");
            queue.Enqueue("Bill");
            queue.Enqueue("Carol");
            queue.Enqueue("David");
            queue.Enqueue("Eddy");
            ReadingQueue(queue);
            Console.WriteLine($"Count is : {queue.Count} , IsSyn is : {queue.IsSynchronized}, 引用的位置 is : {queue.SyncRoot}");

            queue.Enqueue("Frank");
            queue.Enqueue("Grace");
            ReadingQueue(queue);
            Console.WriteLine($"Count is : {queue.Count}");
            var obj = queue.Dequeue();
            Console.WriteLine(obj);
            ReadingQueue(queue);
            Console.WriteLine($"Count is : {queue.Count}");

            queue.Clear();
            ReadingQueue(queue);
            Console.WriteLine($"Count is : {queue.Count}");


        }

        static void ReadingQueue(Queue queue)
        {
            foreach(var e in queue)
            {
                Console.Write($"{ e , 8}");
            } Console.WriteLine();
        }

    }
}
