
using System;

namespace _2nd
{
    class Program
    {
         static void Main(string[] args)
         {
            Console.Write("Hey!");
            Console.WriteLine("Hello !");

            // This is a comment

            /*
             * This
             * is
             * a
             * Multi-line
             * comment
             */

            Console.WriteLine("\tTab");                    // add tab
            Console.WriteLine("Back-Slash\b");      // add back-slash
            Console.WriteLine("New\nline");           // add new line

            Console.ReadKey();                  // Deletes extra text in prompt
         }
    }
}