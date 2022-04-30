using CongestionTaxCalculator_NetCore.DataLayer;
using CongestionTaxCalculator_NetCore.Interfaces;
using System;

namespace CongestionTaxCalculator_NetCore.BusinessLayer
{
    public class CongestionTaxCalculatorBL
    {
        iCongestionTaxCalculatorDL iCongestionTaxCalculatorDL = new CongestionTaxCalculatorDL();
        public int GetTax(iVehicle vehicle, DateTime[] dates)
        {
            try
            {
                int taxFee = 0;
                taxFee = iCongestionTaxCalculatorDL.GetTax(vehicle, dates);
                return taxFee;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
