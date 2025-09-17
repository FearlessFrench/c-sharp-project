using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)

            Human human1 = new Human();
            Human human2 = new Human();

            human1.name = "フレンチ";
            human1.age = 21;

            human2.name = "マリヤ"；
            human2.age = 19;

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

            Console.ReadKey()
        }
    }
    class Human
    {
        public String name;
        public int age;

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping");
        }
    }
}