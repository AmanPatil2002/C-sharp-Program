
using System;

namespace _16th
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop = reports some code while some condition remains true

            Console.Write("Enter your name : ");
            String name = Console.ReadLine();

            while (name == "")
            {
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);
            
            Console.ReadKey();
        }
    }
}