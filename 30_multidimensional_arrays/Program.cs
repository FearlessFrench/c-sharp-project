using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Multidimensional Arrays is good if we want a grid or matrix data!  

            String[] ford = { "Mustang", "F-150", "Explorer" };
            String[] chevy = { "Corvette", "Camaro", "Silverado" };
            String[] toyota = { "Corolla", "Camry", "Rav4" };

            // Don't need these arrays at the top anymore
            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                     { "Corvette", "Camaro", "Silverado" },
                                     { "Corolla", "Camry", "Rav4" }
                                   };

            parkingLot[0, 2] = "Fusion";  // This will replace Explorer
            parkingLot[2, 0] = "Tacoma";  // This will replace Corolla

            /* This will print in each line
            foreach (string car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */

            // This will print in a matrix format
            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i, j] + " ")
                }
                Console.WriteLine()
            }
            
            Console.ReadKey();
        }
    }
}