using System;

namespace Ch10__P10
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar car = new SportCar();      //建構子呼叫順序 爺-> 父 ->子 越上層越先呼叫
        }
    }
    class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle Dector");
        }
    }

    class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car Dector");
        }
    }

    class SportCar : Car
    {
        public SportCar()
        {
            Console.WriteLine("SportCar Dector");
        }
    }

}
