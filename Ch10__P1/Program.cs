using System;

namespace Ch10__P1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new RRectangle();
            Console.WriteLine("長方形面積: "+rect.getArea());
            Console.WriteLine("The CalculateArea is :" + rect.CalculateArea());
        }

    }
    abstract class Gemory       //抽象類別
    {
        abstract public double getArea();
    }

    interface CalculateArea     //介面方法
    {
        public abstract double CalculateArea();
    }

    abstract class Rectangle : Gemory , CalculateArea
    {
        double width = 10.1;
        double length = 20.0;
        public double CalculateArea() => width*length*0.1;     // 介面 繼承 虛擬   複寫(實作)都要公開
        public override double getArea() => width * length;  //return 可以寫成 =>         
    }
    class RRectangle : Rectangle
    {

    }
}
