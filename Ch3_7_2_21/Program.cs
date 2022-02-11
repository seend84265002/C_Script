using System;
using System.Collections;

namespace Ch3_7_2_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Stack");
            var stackList = new Stack();
            stackList.Push("Andy");
            stackList.Push("Bill");
            stackList.Push("Carol");
            stackList.Push("David");
            stackList.Push("Eddy");
            ReadStack(stackList);
            stackList.Push("Frank");
            stackList.Push("Garrady");

            Console.WriteLine($"{stackList.Peek(),8}");
            ReadStack(stackList);

            stackList.Pop();
            ReadStack(stackList);

            stackList.Clear();
            ReadStack(stackList);
        }

        static void ReadStack(Stack stk)
        {
            foreach(var e in stk)
            {
                Console.Write( $"{ e , 8 }" );
            }Console.WriteLine();
        }

    }
}
