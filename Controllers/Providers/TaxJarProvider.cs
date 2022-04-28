using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TaxService.Controllers.Providers;
using TaxService.Interfaces;
using TaxService.Models;

namespace TaxService.Controllers 
{
    public class TaxJarProvider : ITaxService
    {
        //move these constants to a secrete place
        const string apiToken = "5da2f821eee4035db4771edab942a4cc";
        const string url = "https://api.sandbox.taxjar.com/v2/";
        //create once reuse for every call.  This should be moved to a helper class if expanded
        public static HttpClient httpClient { get; set; } = new HttpClient();
        public TaxJarProvider()
        {
            //initializing the HttpClient should be moved to the helper class when created
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.BaseAddress = new Uri(url);
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", apiToken);
            
        }
        public Task<RateModel> CalculateTaxForOrder(OrderTaxRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<RateModel> GetTaxRatesForLocation(TaxRateRequest request)
        {
            try
            {
                
                using (HttpResponseMessage response = await httpClient.GetAsync($"rates/{request.Zip}"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var resultstring = response.Content.ReadAsStringAsync().Result;
                        RateModel rate = await response.Content.ReadAsAsync<RateModel>();
                        return rate;
                    }
                    else
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
            catch (Exception ex)
            {
                string errMessage = ex.Message;
                throw;
            }
        }
    }
}
