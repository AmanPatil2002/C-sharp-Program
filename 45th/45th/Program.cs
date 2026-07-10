
using System;
using System.Collections.Generic;

namespace _45th
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represents a list of objects that can be accessed by index.
            //            Similar to array, but can dynamically increase/decrease in size
            //            using System.Collections.Generic;

            List<String> food = new List<String>();
                       
            food.Add("pizza");            
            food.Add("hamburger");
            food.Add("hotdog");
            food.Add("fries");                                                                     // To add

            //food.Remove("fries");                                                           // To remove
            //food.Insert(0, "sushi");                                                         // To insert
            //Console.WriteLine(food.Count);                                          // To count
            //Console.WriteLine(food.IndexOf("pizza"));                       // To find index
            //Console.WriteLine(food.LastIndexOf("fries"));                 // To find last index
            //Console.WriteLine(food.Contains("hamburger"));            // To check its contains
            //food.Sort();                                                                             // To sort
            //food.Reverse();                                                                       // To sort in reverse
            //food.Clear();                                                                            // To clear
            //String[] foodArray = food.ToArray();                                   // To convert into array

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}