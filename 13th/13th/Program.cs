
using System;

namespace _13th
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name : ");
            String name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("Hello " + name);
            }
            else
            {
                Console.WriteLine("You did not enter your name ");
            }

            Console.ReadKey();
        }
    }
}