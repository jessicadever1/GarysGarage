using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public interface IGas
    {
        int CurrentTankPercentage { get; set; }
        double FuelCapacity { get; set; }
        void RefuelTank();
    }
}