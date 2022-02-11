using System;

namespace Ch3_7_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Carpat carp = new Carpat();
            carp.Length = 25;
            
            carp.Width = 16;
            Console.Write("The {0} x {1} carpet ", carp.Width, carp.Length);
            Console.WriteLine("has an area of {0} ", carp.Area);
            Console.ReadLine();
             
        }
    }

    class Carpat
    {
        private int length;
        private int width;
        private int area;
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                CalculateArea();
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
                CalculateArea();
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
        } 
        private void CalculateArea()
        {
            area = length * width;
        }

    }
}
