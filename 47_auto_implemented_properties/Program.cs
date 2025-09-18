using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Auto-Implemented properties = shortcut when no additional logic is required in the property
            //                               you do not have to define a field for a property,
            //                               you only have to write get; and/or set; inside the property

            Car car = new Car("Zenvo TSR-S")

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }
    class Car
    {
        /*
        String model;

        public String model
        {
            get { return model; }
            set { model = value; }
        }
        */
        
        public String Model { get; set; }

        public Car(String model)
        {
            this.Model = model
        }
    }
}