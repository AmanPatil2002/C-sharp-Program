
using System;

namespace _10th
{
    class Program
    {
        static void Main(string[] args)
        {
            // To find Hypotenuse of triangle

            Console.Write("Enter side A : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side B : ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is " +c);

            Console.ReadKey();
        }
    }
}