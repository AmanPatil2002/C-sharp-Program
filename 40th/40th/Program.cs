
using System;

namespace _40th
{
    class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "red");

            Car car2 = Copy(car1);
            
            Console.WriteLine(car1.color + "  " + car1.model);

            Console.ReadKey();
        }
       public static Car Copy(Car car)
       {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}