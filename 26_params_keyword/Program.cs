using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // params keyword = a method parameter that takes a variable number of arguments.
            //                  The parameter type must be a single - dimensional array

            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

            Console.WriteLine(total);
            Console.ReadKey();
        }
        /*
        static double CheckOut(double a)
        {
            return a;
        }
        static double CheckOut(double a, double b)
        {
            return a + b;
        }
        static double CheckOut(double a, double b, double c)
        {
            return a + b + c;
        }
        static double CheckOut(double a, double b, double c, double d)
        {
            return a + b + c + d;
        }
        static double CheckOut(double a, double b, double c, double d, double e)
        {
            return a + b + c + d + e;
        }
        static double CheckOut(double a, double b, double c, double d, double e, double f)
        {
            return a + b + c + d + e + f;
        }
        static double CheckOut(double a, double b, double c, double d, double e, double f, double g)
        {
            return a + b + c + d + e + f + g;
        }
        static double CheckOut(double a, double b, double c, double d, double e, double f, double h)
        {
            return a + b + c + d + e + f + g + h;
        }
        static double CheckOut(double a, double b, double c, double d, double e, double f, double h, double i)
        {
            return a + b + c + d + e + f + g + h + i;
        }
        */

        static double CheckOut(params double[] prices)
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total; 
        }
    }
}