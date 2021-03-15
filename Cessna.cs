using System;

namespace GarysWholesaleGarage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives past. Zoooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Make a big ole loop and turn {direction}");
        }
    }

}

