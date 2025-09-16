using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //int num = random.Next(1, 7);
            //int num = random.Next(1, 7) + 100;
            //int num = random.Next(1, 21);
            //double num = random.NextDouble();

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            Console.ReadKey();
        }
    }
}