using System;

namespace Ch3_7_2_13
{
    class Program
    {
        public interface Iworkable
        {
            string Work();
        }

        class Employee : Iworkable
        {
            public string Name { get; set; }
            public string Work()
            {
                return "I do My Job";
            }
            public Employee (string name)
            {
                Name = name;
            }
        }
        abstract class Animal : Iworkable
        {
            public Animal (string name) { Name = name; }
            public string Name { get; set; }
            public abstract string Work();
        }
        
        class Dog : Animal
        {
            public Dog(string name) : base(name) { }
            public override string Work()
            {
                return "I Watch the House"; 
            }
        }

        class cat : Animal
        {
            public cat(string name) : base(name) { }
            public override string Work()
            {
                return "I catch the Mice";
            }
        }
        static void Main(string[] args)
        {
            Iworkable bob = new Employee("Eric");
            Iworkable spot = new Dog("Spot");
            Iworkable puff = new cat("puff");
            Console.WriteLine("Employee "+bob.Work());
            Console.WriteLine("Dog "+spot.Work());
            Console.WriteLine("Cat "+puff.Work());


        }
    }
}
