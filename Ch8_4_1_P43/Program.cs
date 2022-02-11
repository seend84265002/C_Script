using System;

namespace Ch8_4_1_P43
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] class_members = new string[3][];
            class_members[0] = new string[] { "1Andy", "Bill" };
            class_members[1] = new string[] { "3Carol", "Daniel","Eric" };
            class_members[2] = new string[] { "5Farady", "Grace" };

            string[][] class_members2 = new string[][]
            {
                new string[] { "2Andy", "Bill" },new string[] { "Carol", "Daniel","Eric" },new string[] { "Farady", "Grace" }
            };
            foreach (var e in class_members)
            {
                foreach(var ee in e)
                {
                    Console.WriteLine(ee);
                }
            }

            string[][][] class_number3D =
            {

            };
        }
    }
}
