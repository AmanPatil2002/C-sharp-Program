
using system;

namespace _8th
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.99;
            double y = 5;

            //double a = Math.Pow(x, 3);                 //Power
            //double b = Math.Sqrt(x);                     //Square root
            //double c = Math.Abs(x);                      //Absolute
            //double d = Math.Round(x);                 //Round
            //double e = Math.Ceiling(x);                 //Ceiling
            //double f = Math.Floor(x);                    //Floor
            //double g = Math.Max(x, y);                 //Maximum
            double h = Math.Min(x, y);                   //Minimum

            Console.WriteLine(h);                    
            
            Console.ReadKey();
        }
    }
}