using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a sting literal with $
            //                        {} are placeholders

            String firstName = "Mitsuha";
            String lastName = "Miyamizu";
            int age = 21;

            //Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            //Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age,-1}old.");

            Console.ReadKey();
        }
    }
}