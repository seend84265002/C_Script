using System;

namespace Ch3_7_2_10
{
    class Program
    {
        abstract class Animal
        {
            public Animal (String name) { Name = name; }
            public string Name { get; }
            public abstract void Speak();
        }

        class Dog : Animal
        {
            public Dog (String name) : base(name) { }
            public override void Speak()
            {
                Console.WriteLine("Dog speak as : Woof");
            }
        }

        class Cat : Animal
        {
            public Cat(String name) : base(name) { }
            public override void Speak()
            {
                Console.WriteLine("Dog speak as : Meow");
            }
        }

        static void Main(string[] args)
        {
            Animal dog = new Dog("Spot");
            Animal cat = new Cat("Puff");
            //Animal pp = new Dog("PP");
            dog.Speak();
            cat.Speak();
            Animal_speak(dog);
            Animal_speak(cat);
            //Animal_speak(pp);
        }
        static void Animal_speak(Animal ani)
        {
            ani.Speak();
        }
    }
}
