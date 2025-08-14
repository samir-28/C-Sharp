using System;

namespace Struct
{
    public class Program
    {
        struct Car
        {

            public string Model;
            public int Year;
            public string Color;

            public void Test()
            {
                Console.WriteLine("Hello");
            }
        }


        public static void Main()
        {
            Car myCar = new Car();
            myCar.Model = "Toyota";
            myCar.Year = 2020;
            myCar.Color = "Black";


            Car Car = new Car();
            Car = myCar; // Copying the struct
            Car.Model = "Honda";
            Car.Year = 2021;
            Car.Color = "Red";

            Console.WriteLine($"Model: {myCar.Model}");
            Console.WriteLine($"Year: {myCar.Year}");
            Console.WriteLine($"Color: {myCar.Color}");

            Console.WriteLine("After copying and modifying the struct:");
            Console.WriteLine($"Model: {Car.Model}");
            Console.WriteLine($"Year: {Car.Year}");
            Console.WriteLine($"Color: {Car.Color}");
        }
    }
}
