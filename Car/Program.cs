using System;

namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new Car();

            vehicle.Make = "Dodge";
            vehicle.Model = "Caliber";
            vehicle.Year = 2007;
            vehicle.Color = "Black";

            Console.WriteLine($"There are 4 {vehicle.Make} {vehicle.Model}s in the area.");

        }
    }
}
