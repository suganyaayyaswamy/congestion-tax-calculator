using CongestionTaxCalculator_NetCore.Interfaces;
using System;

namespace CongestionTaxCalculator_NetCore.Models
{
    public class Car : iVehicle
    {
        public String GetVehicleType()
        {
            return "Car";
        }
    }
}
