using System;

namespace GarysWholesaleGarage
{
    public class Tesla : Vehicle, IElectric // Electric car
    {
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
            CurrentChargePercentage = 100;
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. Weeeee!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"Stop and turn {direction}");
        }
    }

}
