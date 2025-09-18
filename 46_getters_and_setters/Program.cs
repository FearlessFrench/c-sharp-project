using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // getters & setters = add security to fields by encapsulation
            //                     They're accessors found within properties

            //        properties = combine aspects of both fields and methods (share name with a field)
            //      get accessor = used to return the property value
            //      get accessor = used to assign a new value
            //     value keyword = defines the value being assigned by the set (parameter)

            Car car = new Car(400);

            car.Speed = 80;

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }
    class Car
    {
        private int speed;
        public Car(int speed)
        {
            Speed = speed;
        }

        public int Speed
        {
            get { return speed; }  // read
            set
            {
                if (value > 330)
                {
                    speed = 330
                }
                else
                {
                    speed = value;
                }
            }
        }
    }
}