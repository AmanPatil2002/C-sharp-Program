
using System;

namespace _29th
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional opeator = used in conditional assignment if a condition is true/false

            // (condition) ? x : y

            double temperature = 20;
            string message;

            message = (temperature >= 15) ? "It's warm outside " : "It's cold outside";
            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}