using System.ComponentModel.DataAnnotations;

namespace _35th
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //               rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");

            Console.WriteLine(Car.numberOfCars);
            
            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }
    }
}