using System;

namespace GarysWholesaleGarage

{
    public class Ram : Vehicle, IGas // Gas powered truck
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
            Console.WriteLine($"The {MainColor} Ram drives past. Grunt.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"Do something, but then turn {direction}");
        }
    }
}

