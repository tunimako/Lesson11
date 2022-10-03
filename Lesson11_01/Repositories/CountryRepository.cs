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
            CountryList.Add(new Country(0, "Germany", "GER", true));
            CountryList.Add(new Country(1, "Latvia", "LV", true));
            CountryList.Add(new Country(2, "Turkey", "TR", false));
            CountryList.Add(new Country(3, "Canada", "CAN", false));
            CountryList.Add(new Country(4, "India", "IND", false));
            CountryList.Add(new Country(5, "China", "CN", false));
            CountryList.Add(new Country(6, "Poland", "PL", true));
            CountryList.Add(new Country(7, "Switzerland", "CHE", false));
            CountryList.Add(new Country(8, "Hungary", "HU", true));
            CountryList.Add(new Country(9, "Italy", "IT", true));
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