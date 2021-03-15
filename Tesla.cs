using System;

namespace GarysWholesaleGarage
{
    public class Tesla : Vehicle // Electric car
    {
        public void ChargeBattery()
        {
            // method definition omitted
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
