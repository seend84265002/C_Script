using System;

namespace Ch10__P39
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1.0, 2.0, 3.0);
            Console.WriteLine("Area: " + c.Area());
            Console.WriteLine("Perimter: " + c.Perimter());
            Console.WriteLine("Data: " + c.GetData());

        }
    }

    class Circle: Idata
    {
        public double X, Y, R;
        public Circle(double x,double y,double r)
        {
            X = x;Y = y;R = r;
        }
        public double Area()
        {
            return Math.PI * R * R;
        }
        public double Perimter()
        {
            return 2 * Math.PI * R;
        }
        public string GetData()
        {
            return "x: " + X + "Y: " + Y + " " + "R: " + R + " ";
        }
    }

    interface IArea
    {
        double Area();
    }
    interface IPerimter
    {
        double Perimter();
    }
    interface Idata : IArea, IPerimter
    {
        string GetData();
    }
}
