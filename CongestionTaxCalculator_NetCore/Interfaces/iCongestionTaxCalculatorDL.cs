using System;

namespace CongestionTaxCalculator_NetCore.Interfaces
{
    public interface iCongestionTaxCalculatorDL
    {
        int GetTax(iVehicle vehicle, DateTime[] dates);
    }
}
