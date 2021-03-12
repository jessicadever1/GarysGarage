using System;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram ram1500 = new Ram();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            ram1500.Drive();
        }
    }
}
