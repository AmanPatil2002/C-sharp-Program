
using System;

namespace _24th
{
   class Program
    {
        static void Main(string[] args)
        {
            // method = performs a section of code, wheneve it's called "invoked".
            //                   BENEFIT : Let's us reuse code without writing it multiple times

            String name = "Aman";
            int age = 20;

            singHappyBirthday(name, age);
                        
            Console.ReadKey();
        }
        static void singHappyBirthday(String name, int age)
        {
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy birthday dear " + name);
            Console.WriteLine("You are " + age + " year old");
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine();
        }
    }
}