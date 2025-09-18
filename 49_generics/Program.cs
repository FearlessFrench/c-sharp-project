using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic = "not specific to a particular data type"
            //           add <T> or <Thing> to: classes, methods, fields, etc.
            //           allows for code reusability for different data types

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            String[] stringArray = { "1", "2", "3" };

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();
        }
        /*
        public static void displayElements(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void displayElements(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void displayElements(String[] array)
        {
            foreach (String item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        */
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}