using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxService.Interfaces;
using TaxService.Models;
using static TaxService.Controllers.Providers.Parameters;

namespace TaxService.Controllers.Providers
{
    public class ProviderFactory : Creator
    {
        public override ITaxService GetTaxService(Provider provider)
        {
            switch (provider)
            {
                case Provider.TaxJar:
                    return new TaxJarProvider();                    
                default:
                    throw new Exception("Unknown Tax Service Provider");
            }
        }
    }
}
