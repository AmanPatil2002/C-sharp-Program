
using System;

namespace _42th
{
    class Program
    {
        private static void Main(string[] args)
        {
            // ToString() = converts an object to its string repesentation so that it is suitable for display

            Car car = new Car("Chery", "Corvette", 2002, "blue");

            Console.WriteLine(car.ToString());
            
            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
            String messsage = "This is a " + make + " " + model +" built in "+year+" & is coloured in "+color;
            return messsage; 
        }
    }
}