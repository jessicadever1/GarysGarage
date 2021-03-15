using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public interface IElectric
    {
        int CurrentChargePercentage { get; set; }
        void ChargeBattery();

    }
}