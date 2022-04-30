using CongestionTaxCalculator_NetCore.Interfaces;

namespace CongestionTaxCalculator_NetCore.Models
{
    public class Motorbike : iVehicle
    {
        public string GetVehicleType()
        {
            return "Motorbike";
        }
    }
}
