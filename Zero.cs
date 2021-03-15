using System;

namespace GarysWholesaleGarage

{
    public class Zero : Vehicle, IElectric // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero drives past. Woosh!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"When you get to the barn, turn {direction}.");
        }
    }
}

