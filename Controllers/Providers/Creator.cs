using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxService.Interfaces;
using static TaxService.Controllers.Providers.Parameters;

namespace TaxService.Controllers.Providers
{
    public abstract class Creator
    {
        public abstract ITaxService GetTaxService(Provider provider);
    }
}
