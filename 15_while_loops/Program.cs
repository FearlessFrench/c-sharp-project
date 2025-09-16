using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop = repeats some code while some condition remains true

            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            /*
            while (1 == 1)
            {
                Console.WriteLine("HELP! I'M STUCK IN AN INFINITE LOOP!");
            }
            */

            //string name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}