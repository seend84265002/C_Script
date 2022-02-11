using System;

namespace Ch8_practise001
{
    class Program
    {
        static void Main(string[] args)
        {
        //int[,] int1 = {  { 1, 2, 3 },  { 4, 5, 6 },  { 7, 8, 9 } };
        int[][] int2 = { new int[] { 1 }, 
                         new int[] { 2, 3 }, 
                         new int[] { 4, 5, 6 } };
        int[,,] array3D = new int[2,2,3] { { { 1, 2, 3 }, { 4, 5, 6 } },            //0 
                                 { { 7, 8 ,9}, { 10, 11, 12 } } };                  //1

            /*foreach (var e in int1)
                {
                    Console.Write(e+"\t");
                }Console.WriteLine();
            for(int i = 0; i < int1.GetLength(0); i++)
                {
                    for (int j = 0; j < int1.GetLength(1); j++)
                    {
                        Console.Write(int1[i,j] + "\t");
                    }Console.WriteLine();
                }
            */
      /*Console.WriteLine("------------第2題------------");
        foreach (var e in int2)
            {
                foreach(var ee in e)
                {
                    Console.Write(ee+"\t");
                }Console.WriteLine();
            }*/
        foreach (var e in array3D)
            {
                Console.Write(e);
            }
        }
    }
}
