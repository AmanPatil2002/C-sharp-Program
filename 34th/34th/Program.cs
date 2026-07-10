
using System;

namespace _34th
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor = A special method in a class
            //                         Same name as the class name 
            //                         Can be used to assign arguments to fields when creating an object 

            Human human1 = new Human("Aman", 20);
            Human human2 = new Human("Ram", 19);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating ");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping ");
        }
    }
}