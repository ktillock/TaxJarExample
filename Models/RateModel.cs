using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaxService.Models
{
    public class RateModel
    {
        public string Zip { get; set; }
        public string Country { get; set; }
        [JsonProperty("country_rate")]
        public float CountryRate { get; set; }
        public string State { get; set; }
        [JsonProperty("state_rate")]
        public decimal StateRate { get; set; }
        public string County { get; set; }
        [JsonProperty("county_rate")]
        public decimal CountyRate { get; set; }
        public string City { get; set; }
        [JsonProperty("city_rate")]
        public decimal CityRate { get; set; }
        [JsonProperty("combined_distrinct_rate")]
        public decimal CombinedDistrictRate  { get; set; }
        [JsonProperty("combined_rate")]
        public decimal CombinedRate { get; set; }
        [JsonProperty("freight_taxable")]
        public bool FreightTaxable { get; set; }
    }
}
