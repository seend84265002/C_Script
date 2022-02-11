using System;

namespace Ch11_P24
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(1, 2, 5, 10);
            Shape r2 = new Rectangle(2, 3, 6, 11);
            IPerimter r3 = new Rectangle(3, 4, 7, 12);

            Console.WriteLine("X: " + r1.X + " " + "Y: " + r1.Y + " " + "Area: " + r1.Area() + " "
                + "Height: " + r1.Height + " " + "Width: " + r1.Width + " " + "Perimter: " + r1.Perimter());

            Console.WriteLine("X: " + r2.X + " " + "Y: " + r2.Y + " " + "Area: " + r2.Area() + " "
                + "Height: " + ((Rectangle)r2).Height + " " + "Width: " + ((Rectangle)r2).Width 
                + " " + "Perimter: " + ((Rectangle)r2).Perimter());

            Console.WriteLine("X: " + ((Rectangle)r3).X + " " + "Y: " + ((Rectangle)r3).Y + " " + "Area: " 
                + ((Rectangle)r3).Area() + " "+ "Height: " + ((Rectangle)r3).Height 
                + " " + "Width: " + ((Rectangle)r3).Width + " " + "Perimter: " + r3.Perimter());
        }
    }
    interface IPerimter
    {
        double Perimter();
    }
    abstract class Shape
    {
        public double X;
        public double Y;
        public abstract double Area();
    }
    class Rectangle : Shape, IPerimter
    {
        public double Height;
        public double Width;
        public double Perimter()
        {
            return 2 * (Height + Width);
        }
        public override double Area()
        {
            return Height*Width;
        }
        public Rectangle(double x,double y ,double w,double h)
        {
            X = x;Y = y;Height = h;Width = w;
        }
    }
}
