
using System;

namespace _3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;                          //declaration
            x = 123;                     //initialization
                        //OR
            int y = 321;                 //declaration + initialization

            int z = x + y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            int age = 20;                //whole integer
            Console.WriteLine("Your age is " + age);

            double height = 300.5;       //decimal number
            Console.WriteLine("Your height is " + height + " cm");

            bool alive = true;           //true or false
            Console.WriteLine("Are you alive ? " + alive);

            char symbol = '@';           //character
            Console.WriteLine("your symbole is : " + symbol);

            String name = "Aman";        //string
            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}