using System;

namespace Ch3_6_6_a
{
    class Rectangle
    {
        double length;
        double width;
        static void Main(string[] args)
        {

            Rectangle rec = new Rectangle();
            rec.length = 5.345;
            rec.width = 6.789;
            Console.WriteLine("The Lenght Attribute rec is: " + rec.length);
            Console.WriteLine("The Width Attribute rec is: " + rec.width);
            Console.WriteLine("The Area of rec is: " + rec.getArea().ToString("0.0000"));
            Console.Read();

        }
        private double getArea()
            {
                return length * width;
            }

        /*
{
    myPrint();
    Console.Read();
}

static void myPrint()
{
    Console.WriteLine("This is your Frist Static");
}
*/
    }
}

