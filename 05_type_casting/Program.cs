using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // type casting = Converting a value to a different data type
            //                Useful when we accept user input (string)
            //                Different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a);

            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);

            String g = "$";
            char h = Convert.ToChar(g);

            String i = "true";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());  // >>> System.Int32
            Console.WriteLine(d.GetType());  // >>> System.Double
            Console.WriteLine(f.GetType());  // >>> System.String
            Console.WriteLine(h.GetType());  // >>> System.Char
            Console.WriteLine(j.GetType());  // >>> System.Boolean
            
            Console.ReadKey()
        }
    }
}