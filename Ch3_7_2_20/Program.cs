using System;
using System.Collections;

namespace Ch3_7_2_20
{
    class Program
    {
        static void Main(string[] args)
        {
            var htable = new Hashtable
            {
                {1,"Anday" },
                {3,"Bill" },
                {2,"Carol" },
                {5,"David" },
                {4,"Eric" }
            };
            dump();
            htable.Remove(3);dump();            //刪除第3個地址的數值
            htable.Clear(); dump();             //全部刪除

            void dump() { 
            foreach (var key in htable.Keys)
            Console.WriteLine("key is : " + key + " Value is : " + htable[key]);
                Console.WriteLine();
            }
        }
    }
}
