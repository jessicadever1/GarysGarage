using System;

namespace GarysWholesaleGarage

{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public Zero(string paint)
        {
            MainColor = paint;
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

