
using System;

namespace _41th
{
    class Program
    {
        private static void Main(string[] args)
        {
            // method overriding = provides a new version of a method inherited from a parent class
            //                                     inherited method must be : abstract,  virtual, or already overriden
            //                                     Used with ToString(), polymorphism
            
            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            //Console.WriteLine();

            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The Dog goes *woof*");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The Cat goes *meow*");
        }
    }
}