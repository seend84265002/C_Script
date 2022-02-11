using System;

namespace Ch3_C_5
{
    
        class Cubic
        {
            public double Length { get ; set; }
            public double Width { get ; set; }
            public double Height{ get ; set;}
            public Cubic() { }
            public double Volume { get { return Length * Width * Height; } } 
            
            public Cubic(double length, double width, double height)
            {
                Length = length;
                Width = width;
                Height = height;

            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            {
                Cubic cub = new Cubic() { Length = 1.2, Width = 3.4, Height = 5.6 }; //Object Init;
                Console.WriteLine("The Volume of Cubic is: " + cub.Volume);
                Cubic cub2 = new Cubic(1.2, 3.4, 5.6);                      //Constructor Init;
                
                Console.WriteLine("The Volume of Cubic 2 is: " + cub2.Volume);
                Console.ReadLine();
            }

        

       


        }
    }
}
