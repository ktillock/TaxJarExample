using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxService.Controllers.Providers;
using TaxService.Interfaces;
using TaxService.Models;

namespace TaxService.Controllers
{
    public class TaxService 
    {        
        public RateModel CalculateTaxForOrder(OrderTaxRequest request, Providers.Parameters.Provider provider)
        {
            
            throw new NotImplementedException();
        }

        public  RateModel GetTaxRatesForLocation(TaxRateRequest request, Providers.Parameters.Provider taxServiceProvider)
        {
            Creator factory = new ProviderFactory();
            ITaxService service = factory.GetTaxService(taxServiceProvider);
            RateModel rate = service.GetTaxRatesForLocation(request).Result;
            return rate;
        }
    }
}
