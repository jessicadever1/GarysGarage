using System;

namespace GarysWholesaleGarage
{
    public class Cessna : Vehicle, IGas
    {
        public double FuelCapacity { get; set; }
        public int CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 100;
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

