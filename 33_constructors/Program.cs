using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object

            // "If it has all four tires and gets you from point A to point B then it's a car"
            // - 藤原拓海 (Takumi Fujiwara ― Initial D)

            /*
            Human human1 = new Human("フレンチ", 21);
            Human human2 = new Human("マリヤ", 19);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey()
            */

            Car car1 = new Car("Ford", "Mustang", 2022, "red");
            Car car2 = new Car("Chevy", "Corvette", 2021, "blue");

            car1.Drive();
            car2.Drive();

            Console.ReadKey();
        }
    }
    /*
    class Human
    {
        public String name;
        public int age;

        public Human(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
    */
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
        public void Drive()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}