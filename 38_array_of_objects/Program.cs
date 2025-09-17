using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args) {
            /*
            Car[] garage = new Car[3];

            Car car1 = new Car("Mustang");
            Car car2 = new Car("Corvette");
            Car car3 = new Car("Charger");

            garage[0] = car1;
            garage[1] = car2;
            garage[2] = car3;

            Console.WriteLine(garage[0].model);
            Console.WriteLine(garage[1].model);
            Console.WriteLine(garage[2].model);
            */

            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model; 
        }
    }
}