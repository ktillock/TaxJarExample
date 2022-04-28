using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxService.Models;

namespace TaxService.Interfaces
{
    public interface ITaxService
    {
        public  Task<RateModel> GetTaxRatesForLocation(TaxRateRequest request);
        public  Task<RateModel> CalculateTaxForOrder(OrderTaxRequest request);
    }
}
