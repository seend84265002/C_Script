using System;

namespace Ch9_1_P9
{

    
    class Animal
    {
        public void talk()
        {
            Console.WriteLine("Anamimal Talks! ****");
        }
        public virtual void talkv()
        {
            Console.WriteLine("Anamimal Talkv! ****");
        }
    }

    class Cat : Animal
    {
        public new void talk()
        {
            Console.WriteLine("Cat Talks! Meawn Meawn");
        }
        public override void talkv()
        {
            Console.WriteLine("Cat Talkv! Meawn Meawn");
        }
    }

    class Dog : Animal
    {
        public new void talk()
        {
            Console.WriteLine("Dog Talks! Houn Houn");
        }

        public override void talkv()
        {
            Console.WriteLine("Dog Talkv! Houn Houn");
        }
    }

    class Pig : Animal
    {
        public new void talk()
        {
            Console.WriteLine("Pig Talks! Gou Gou");
        }
        public override void talkv()
        {
            Console.WriteLine("Pig Talkv! Gou Gou");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal anm, pig, dog, cat;

            anm = new Animal();
            cat = new Cat();
            dog = new Dog();
            pig = new Pig();

            /*
            anm.talk();
            cat.talk();
            dog.talk();
            pig.talk();
            Console.WriteLine("---------------------");
            
            ((Animal)anm).talk(); 
            ((Animal)cat).talk();   //upcasting;
            ((Animal)dog).talk();   //upcasting;
            ((Animal)pig).talk();   //upcasting;
            Console.WriteLine("---------------------");
            
            
            ((Animal)anm).talk();
            ((Cat)cat).talk();      //downcasting;
            ((Dog)dog).talk();      //downcasting;
            ((Pig)pig).talk();      //downcasting;
            Console.WriteLine("---------------------");
            */

            anm.talkv();            //virtual base
            cat.talkv();            //override derived
            dog.talkv();            //override derived
            pig.talkv();            //override derived

        }
    }
}
