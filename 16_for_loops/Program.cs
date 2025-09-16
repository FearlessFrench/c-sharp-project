using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop = repeats some code a FINITE amount of times

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 10; i+=3)
            {
                Console.WriteLine(i);
            }
            */

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("STAY WITH ME! Mayonaka no Door o tataki!")

            Console.ReadKey();
        }
    }
}