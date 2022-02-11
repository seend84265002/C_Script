using System;

namespace Ch8_1_2_P8{        
            public struct Value_Object_2D
            {
            public double X { get; set; }
            public double Y { get; set; }
            public Value_Object_2D(double x ,double y){
                X = x;
                Y = y;
                }
            }
    class Program
    {
        static void Main(string[] args)
        {
            int[] a0 = { 1, 2, 3 };
            
            Console.WriteLine("-----1-----");
            foreach (var e in a0) Console.Write(e+"\t");
            Console.WriteLine();

            ref_Object_pass_para( a0);
            Console.WriteLine("-----3-----");
            foreach (var e in a0) Console.Write(e+"\t");
            Console.WriteLine();
            ref_Object_pass_para( ref a0);
            Console.WriteLine("-----5-----");
            foreach (var e in a0) Console.Write(e + "\t");
            Console.WriteLine();
            /*Value_Object_2D p0 = new Value_Object_2D(1.1, 2.2);
            Console.WriteLine("X: {0} and Y: {1}", p0.X, p0.Y);
            Console.WriteLine();
            Value_Object_Pass_By_Value(p0);
            Console.WriteLine("呼叫Value_Object_Pass_By_Value後 外部 X: {0} and Y: {1}", p0.X, p0.Y);*/
        }
        static void ref_Object_pass_para( int[] a)
        {
            a[0] = 11;              //成員可以變更    外部數值
            Console.WriteLine("-----2-----");
            foreach (var e in a) Console.Write(e+"\t");
            Console.WriteLine();

            int[] a1 = { 111, 222, 333 };
            a = a1;                 //變數不可以變更    外部數值
            Console.WriteLine("-----2.5-----");
            foreach (var e in a) Console.Write(e+"\t");
            Console.WriteLine();
        }

        static void ref_Object_pass_para( ref int[] a)
        {
            int[] a1 = { 111, 222, 333 };
            a = a1;                 //變數不可以變更    外部數值
            Console.WriteLine("-----4-----");
            foreach (var e in a) Console.Write(e + "\t");
            Console.WriteLine();
        }


        /*static void Value_Object_Pass_By_Value(Value_Object_2D p)       //傳值不會改變
        {
            p.X = 11.1;         //沒有回傳值 p.X 是函數內部參數 不會改變外部p0.X
            Console.WriteLine("Value_Object_Pass_By_Value 函數內部 X: {0} and Y: {1}", p.X, p.Y);
            Console.WriteLine();
            Value_Object_2D p1 = new Value_Object_2D ( 111.1, 222.2 );
            p = p1;
            Console.WriteLine("Within Call  函數內部 X: {0} and Y: {1}", p.X, p.Y);

        }*/
    }
}
