using System;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero("red")
            {
                BatteryKWh = 150,
                MaximumOccupancy = "1"
            };

            Tesla modelS = new Tesla();

            modelS.MainColor = "red";
            modelS.MaximumOccupancy = "2";


            Cessna mx410 = new Cessna();

            mx410.FuelCapacity = 20;
            mx410.MainColor = "yellow";
            mx410.MaximumOccupancy = "2";

            Ram ram1500 = new Ram();
            {
                ram1500.FuelCapacity = 25;
                ram1500.MaximumOccupancy = "2";
                ram1500.MainColor = "black";
            }

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            ram1500.Drive();

            fxs.Turn("right");
            modelS.Turn("left");
            mx410.Turn("around");
            ram1500.Turn("left");

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();
            ram1500.Stop();
        }
    }
}
