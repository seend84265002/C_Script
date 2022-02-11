using System;

namespace Ch3_7_2_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Maximun(3,8,6));
            Console.WriteLine(Maximun(4.4,6.6,9.9));
            Console.WriteLine(Maximun("ppl","zxc","aple"));

            Console.WriteLine(Max<string>("ppl", "appppp", "zxy"));
        }

        //static U Max <T,U,V>(T x, U y ,V z) where T:IComparable<T> where U: IComparable<U> where V : IComparable<V>
        //{
        //    return y;
        //}

        static string Max<ST>(string x, string y,string z) where ST : IComparable 
        {
            var max = x.Length;
            var name= x;
            if (y.Length.CompareTo(max) > 0)
            {
                max = y.Length;
                name = y;
            }
            if (z.Length.CompareTo(max) > 0)
            {
                max = z.Length;
                name = z;
            }
            return name;
        } 

        private static T Maximun<T>(T a,T b,T c) where T: IComparable
        {
            var max = a;
            if (b.CompareTo(max) > 0)
            {
                max = b;
            }
            if (c.CompareTo(max) > 0)
            {
                max = c;
            }
            
            return max;
        } 

    }
}
