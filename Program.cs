using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.CurrentChargePercentage = 99;
            Zero fx = new Zero();
            fx.CurrentChargePercentage = 50;
            Tesla modelS = new Tesla();
            modelS.CurrentChargePercentage = 75;

            List<IElectric> electricVehicles = new List<IElectric>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage} %");
            }

            foreach (IElectric ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
                Console.WriteLine($"*C H A R G I N G*");
            }

            foreach (IElectric ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage} %");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List <???> gasVehicles = new List<???> () {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (??? gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            // foreach (??? gv in gasVehicles)
            // {
            //     // This should completely refuel the gas tank
            //     gv.RefuelTank();
            // }

            // foreach (??? gv in gasVehicles)
            // {
            //     Console.WriteLine($"{gv.CurrentTankPercentage}");
            // }
        }
    }
}














//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Zero fxs = new Zero("red")
//             {
//                 BatteryKWh = 150,
//                 MaximumOccupancy = "1"
//             };

//             Tesla modelS = new Tesla();

//             modelS.MainColor = "red";
//             modelS.MaximumOccupancy = "2";


//             Cessna mx410 = new Cessna();

//             mx410.FuelCapacity = 20;
//             mx410.MainColor = "yellow";
//             mx410.MaximumOccupancy = "2";

//             Ram ram1500 = new Ram();
//             {
//                 ram1500.FuelCapacity = 25;
//                 ram1500.MaximumOccupancy = "2";
//                 ram1500.MainColor = "black";
//             }

//             fxs.Drive();
//             modelS.Drive();
//             mx410.Drive();
//             ram1500.Drive();

//             fxs.Turn("right");
//             modelS.Turn("left");
//             mx410.Turn("around");
//             ram1500.Turn("left");

//             fxs.Stop();
//             modelS.Stop();
//             mx410.Stop();
//             ram1500.Stop();
//         }
//     }
// }
