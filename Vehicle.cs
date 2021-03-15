using System;

namespace GarysWholesaleGarage

{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }
        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} vehicle goes Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"At the big rock turn {direction}.");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The vehicle comes to a stop.");
        }

    }
}

