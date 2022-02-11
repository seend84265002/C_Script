using System;

namespace Ch3_7_2_8
{
    public abstract class Geometry
    {
        public abstract double Area();
    }

    public class Rectangle : Geometry
    {
        private double Length { get; set; }
        private double Wigth { get; set; }
        public Rectangle(double length,double wigth)
        {
            Length = length;
            Wigth = wigth;
        }
        public override double Area()
        {
            return Length * Wigth;
        }
    }
    public class Triangle : Geometry
    {
        private double Base { get; set; }
        private double Height { get; set; }
        public Triangle(double base_, double height)
        {
            Base = base_;
            Height = height;
        }
        public override double Area()
        {
            return Base * Height/2.0;
        }
    }
    public class Circle : Geometry
    {
        private double Radius { get; set; }
       
        public Circle(double radius)
        {
            Radius = radius;
            
        }
        public override double Area()
        {
            return Math.PI*Radius*Radius;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Geometry rec = new Rectangle(12.34, 56.78);
            Geometry tri = new Triangle(23.45, 67.89);
            Geometry cir = new Circle(34.569);
            Console.WriteLine("The Rec Area is : " + " " + rec.Area().ToString("0.000"));
            Console.WriteLine("The Tri Area is : " + " " + tri.Area().ToString("0.000"));
            Console.WriteLine("The Cir Area is : " + " " + cir.Area().ToString("0.000"));

        }
    }
}
