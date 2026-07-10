
using system;

namespace _9th
{
     class Program
    {
        static void Main(string[] args)
        {
            // Display randm number 's
            Random random = new Random();

            int num1 = random.Next(1, 7);                 //  random.Next(Minimum, Maximum);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            //double num = random.NextDouble();

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
        }
    }
}