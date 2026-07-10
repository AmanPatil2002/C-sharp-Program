
using System;

namespace _47th
{
    class Program
    {
        private static void Main(string[] args)
        {
            // getters & setters = add security to fields by encapsulation
            //                                   They're accessors found within properties

            // properties = combine aspects of both fields and methods (share name with a field)
            // get accessor = used to return the property value
            // set accessor = used to assign a new value
            // value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            car.Speed = 1000000;
            
            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }
    class Car
    {
        public int speed;

        public Car(int speed)
        {
            speed = speed;
        }
        public int Speed
        {
            get {  return speed; }   //read
            set                                 // writable
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}