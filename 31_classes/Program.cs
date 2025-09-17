using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // class = A bundle of related code.
            //         Can be used as a blueprint to create objects (OOP)

            Math.Round(3.14);
            Math.Abs(-3.14);
            Math.Pow(2, 3);

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }
}