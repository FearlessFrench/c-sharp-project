using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // method = performs a section of code, whenever it's called "invoked".
            //          benefit = Let's us reuse code w/o writing it multiple times

            String name = "みつは";
            int age = 21;

            singHappyBirthday(name, age);

            Console.ReadKey();
        }
        static void singHappyBirthday(String birthdayPERSON, int yearsOLD)
        {
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine("Happy birthday dear " + name);
            Console.WriteLine("You are " + age + " years old!");
            Console.WriteLine("Happy birthday to you!");
            Console.WriteLine();
        }
    }
}