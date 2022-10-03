using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.Models;

namespace Lesson11_01.Repositories
{
    internal class CountryRepository
    { 
        private List<Country> CountryList { get; set; }
        public CountryRepository()
        {
            CountryList = new List<Country>();
            CountryList.Add(new Country("Germany", "GER", true));
            CountryList.Add(new Country("Latvia", "LV", true));
            CountryList.Add(new Country("Turkey", "TR", false));
            CountryList.Add(new Country("Canada", "CAN", false));
            CountryList.Add(new Country("India", "IND", false));
            CountryList.Add(new Country("China", "CN", false));
            CountryList.Add(new Country("Poland", "PL", true));
            CountryList.Add(new Country("Switzerland", "CHE", false));
            CountryList.Add(new Country("Hungary", "HU", true));
            CountryList.Add(new Country("Italy", "IT", true));
        }
        public List<Country> Retrive()
        {
            return CountryList;
        }
        public Country RetriveCountry(string countryCode)
        {
            return CountryList.Where(x => x.CountryCode == countryCode).FirstOrDefault();
        }
    }
}