using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public bool CountryEU { get; set; }


        public Country(int countryId, string countryName, string countryCode, bool countryEU)
        {
            CountryId = countryId;
            CountryName = countryName;
            CountryCode = countryCode;
            CountryEU = countryEU;
        }
    }
}