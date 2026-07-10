namespace _33th
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // object = An instance of a class
            //                A class can be used as a blueprint to create objects (OOP)
            //                objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();

            human1.name = "Aman";
            human1.age = 20;

            human1.Eat();
            human1.Sleep();
            
            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating ");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping ");
        }
    }
}