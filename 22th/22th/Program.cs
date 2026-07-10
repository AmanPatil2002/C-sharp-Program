
using System;

namespace _22th
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = A variable that can store multiple values. fixed size

            String[] cars = { "BMW", "Mustang", "Corvette" };

            cars[0] = "Tesla";

            for (int i = 0; i< cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadKey();
        }
    }
}