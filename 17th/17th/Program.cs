
using System;

namespace _17th
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop = repeats some code a FINITE amount of times

            /*
            for ( int i = 1; i<= 10; i++)       
            {
                Console.WriteLine( i );
            }
            */
            //  OR
            /*
             for ( int i = 1; i<= 10; i+=2)      
            */

            for(int i = 10; i > 0; i--)       
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}