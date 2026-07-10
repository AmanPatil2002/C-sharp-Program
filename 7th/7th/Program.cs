
using System;

namespace _7th
{
    class Program
    {
        static void Main(string[] args)
        {
            int friend = 10;

            //       Increment
            //friend = friend + 2;
            //friend += 2;
            //friend++;

            //       Decrement
            //friend = friend - 1;
            //friend -= 1;
            //friend--;

            //       Multiple
            //friend = friend * 2;
            //friend *= 2;

            //        Division
            //friend = friend / 2;
            //friend /= 2;

            //         Modulus(remainder)
            int remainder = friend % 3;

            Console.WriteLine(friend);
            Console.WriteLine(remainder);
            
            Console.ReadKey();
        }
    }
}