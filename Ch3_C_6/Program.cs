using System;
namespace Ch3_C_6
{
    class Rectangle
    {
        internal double Length { get; set; }
        
        internal double Width { get; set; }

        internal Rectangle() { }
        internal Rectangle(double x,double y) { Length = x;Width = y; }
        internal double Area()
        {
            return Length * Width;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Length = 2.3;
            r.Width = 4.5;
            Rectangle r2 = new Rectangle(5.6, 7.8);
            Console.WriteLine("The Rectangle r area is " + r.Area());
            Console.WriteLine("The Rectangle r2 area is " + r2.Area());
        }
    }
}
