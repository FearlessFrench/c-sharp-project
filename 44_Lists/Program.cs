using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // List = data structure that represent a list of objects that can be accessed by index.
            //        Similar to array, but can dynamically increase/decrease in size
            //        using System.Collections.Generic;

            List<String> food = new List<String>();

            food.Add("pizza");      // Console.WriteLine(food[0]);
            food.Add("lasagna");    // Console.WriteLine(food[1]);
            food.Add("hamburger");  // Console.WriteLine(food[2]);
            food.Add("fries ");     // Console.WriteLine(food[3]);

            /*
            food.Remove("fries");
            food.Insert(0, "ramen");
            Console.WriteLine(food.Count);
            Console.WriteLine(food.IndexOf("pizza"));
            Console.WriteLine(food.LastIndexOf("fries"));
            Console.WriteLine(food.Contains("pizza"));
            food.Sort();
            food.Reverse();
            food.Clear();
            String[] foodArray = food.ToArray();
            */

            foreach (String item in food)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}