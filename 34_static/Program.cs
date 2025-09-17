using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // static = modifier to declare a static member, which belongs to the class itself
            //          rather than to any specific object

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Charger")

            //Console.WriteLine(car1.numberOfCars);
            //Console.WriteLine(car2.numberOfCars);

            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            //Math math1 = new Math();
            //math1.Round(3.14);
            //math1.Round();

            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
        public static int numberOfCars;

        public Car(string model)
        {
            this.model = model;
            numberOfCars++;
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has begun!")
        }
    }
}