using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;                 // declaration
            x = 123;               // inititalization

            int y = 321;           // declaration + initialization

            int z = x + y;

            int age = 18;          // whole integer
            double height = 167.5; // decimal number
            bool alive = true;     // true or false
            char symbol = '@';
            string name = "みつは"
    
        Console.WriteLine("Hello " + name);
            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you alive? " + alive);
            Console.WriteLine("Your symbol is: " + symbol);

            String userName = symbol + name;

            Console.WriteLine("Your username is: " + userName);

            Console.ReadKey();
        }
    }
}