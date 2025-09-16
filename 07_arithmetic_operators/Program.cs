using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int friends = 5;

            //friends = friends + 2;  // 7
            //friends = +2;           // 7
            //friends++;              // 6

            //friends = friends - 1;  // 4
            //friends -= 1;           // 4
            //friends--;              // 4

            //friends = friends * 2;  // 10
            //friends *= 2;           // 10

            //friends = friends / 2;  // 2 (int) or 2.5 (double)
            //friends /= 2;           // 2 (int) or 2.5 (double)

            //Console.WriteLine(friends);

            //Console.ReadKey();

            int remainder = friends % 2;
            int remainder = friends % 3;

            Console.WriteLine(remainder);

            Console.ReadKey();
        }
    }
}