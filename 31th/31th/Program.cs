
using System;

namespace _31th
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };
            // OR
            String[,] parkinglot = {  { "Mustang", "F-150", "Explorer" },
                                                       { "Corvette", "Camaro", "Silverado" },
                                                       { "Corolla", "Camry", "Rav4" },
                                                 };
            parkinglot[0, 2] = "Fusion";
            parkinglot[2, 0] = "Tacoma";
            /*
            foreach(String car in parkinglot)
            {
                Console.WriteLine(car);
            }
            */

            for(int i = 0; i < parkinglot.GetLength(0); i++)
            {
                for (int j = 0; j < parkinglot.GetLength(1); j++)
                {
                    Console.Write(parkinglot[i, j] + "     ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
    }
}