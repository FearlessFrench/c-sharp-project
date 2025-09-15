using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hey!");
            Console.WriteLine("Hello!");

            // This is a comment
            /*
             * This
             * is
             * a
             * multiline
             * comment
             */

            Console.WriteLine("\tFrench");  // tab >>>     French
            Console.WriteLine("French\b");  // backspace >>> Frenc
            
            Console.ReadKey();
        }
    }
}