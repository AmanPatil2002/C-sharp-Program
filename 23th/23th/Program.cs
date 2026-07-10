
using System;

namespace _23th
{
    class Program
    {
        static void Main(string[] args)
        {
            // foreach loop = A simpler way to iterate over an array, but it's less flexible

            String[] cars = { "BMW", "Mustang", "Corvette" };

            foreach (String car in cars)
            {
                Console.WriteLine(car);
            }
            Console.ReadKey();
        }
    }
}