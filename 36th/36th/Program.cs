
using System;

namespace _36th
{
    class Program
    {
        static void Main(string[] args)
        {
            // overloaded constructors = technique to create multiple constructors,
            //                                               with a different set of parameters.
            //                                               name + parameters = signature

            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni");

            Console.ReadKey();
        }
    }
    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(string bread)
        {
            this.bread = bread;           
        }
        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;            
        }
        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;           
        }
        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }
    }
}