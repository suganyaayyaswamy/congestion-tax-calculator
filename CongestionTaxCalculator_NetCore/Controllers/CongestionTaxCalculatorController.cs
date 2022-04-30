using CongestionTaxCalculator_NetCore.BusinessLayer;
using CongestionTaxCalculator_NetCore.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace CongestionTaxCalculator_NetCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CongestionTaxCalculatorController : ControllerBase
    {
        private readonly ILogger<CongestionTaxCalculatorController> _logger;
        private readonly iVehicle _vehicle;

        public CongestionTaxCalculatorController(ILogger<CongestionTaxCalculatorController> logger,
            iVehicle vehicle)
        {
            _logger = logger;
            _vehicle = vehicle;
        }

        [HttpGet]
        public int Get()
        {
            return 1;
        }

        [HttpGet("GetTax")]
        public int GetTax([FromQuery] DateTime[] dates)
        {
            CongestionTaxCalculatorBL congTaxCalcBL = new CongestionTaxCalculatorBL();
            int taxFee = 0;
            taxFee = congTaxCalcBL.GetTax(_vehicle, dates);
            return taxFee;
        }
    }
}