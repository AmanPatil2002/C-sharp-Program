
using System;

namespace _30th
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variable into a string literal
            //                                       precede a string literal with $
            //                                       {} are placeholder

            String firstName = "Aman";
            String lastName = "Patil";
            int age = 20;

            //Console.Write("Hello " + firstName + " " + lastName + ".");
            //Console.WriteLine("You are " + age + "years old. ");

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age} years old. ");
            
            Console.ReadKey();
        }
    }
}