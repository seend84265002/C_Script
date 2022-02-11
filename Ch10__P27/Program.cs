using System;

namespace Ch10__P27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle r = new Rectangle(12, 15);
            //Console.WriteLine("Area: " + r.IArce() + " " + "Info: " + r.Info());
            IArce r = new Rectangle(12, 15);
            Console.WriteLine("Area: " + r.IArce() + " " + "Info: " + ((Rectangle)r).Info());

            IInfo r2 = new Rectangle(12, 15);
            Console.WriteLine("Area: " + ((Rectangle)r2).IArce() + " " + "Info: " + r2.Info());
        }
    }
    interface IInfo{
        string Info();
    }
    interface IArce
    {
        int IArce();
    }

    class Rectangle : IArce, IInfo
    {
        int width;
        int Heigth;
        public Rectangle(int w ,int h)
        {
            width = w;
            Heigth = h;
        }
        public string Info()
        {
            return "W: " + width +" "+ "H: " + Heigth;
        }
        public int IArce(){
            return width * Heigth;
        }

    }

}
