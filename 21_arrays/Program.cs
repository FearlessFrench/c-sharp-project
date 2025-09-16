// C# arrays

using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // array = a variable that can store multiple values. fixed size

            String[] cars = { "BMW", "Mustang", "Corvette" };

            /*
            Console.WriteLine(cars);     // BMW Mustang Corvette
            Console.WriteLine(cars[0]);  // BMW
            Console.WriteLine(cars[1]);  // Mustang
            Console.WriteLine(cars[2]);  // Corvett
            */

            cars[0] = "Tesla";

            string[] cars = new string[3]
            cars[0] = "Tesla";
            cars[1] = "Mustang";
            cars[2] = "Corvette";

            for (int i = 0; i < cars.length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Console.ReadKey();
        }
    }
}