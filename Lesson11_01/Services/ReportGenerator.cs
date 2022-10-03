using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.Models;
using Lesson11_01.Repositories;

namespace Lesson11_01.Services
{
    internal class ReportGenerator
    {
        AircraftRepository _aircraftRepository;
        AircraftModelRepository _aircraftModelRepository;
        CompanyRepository _companyRepository;
        CountryRepository _countryRepository;
        private List<ReportItem> ReportList { get; set; }

        public ReportGenerator(AircraftRepository aircraftRepository, AircraftModelRepository aircraftModelRepository, CompanyRepository companyRepository, CountryRepository countryRepository)
        {
            _aircraftRepository = aircraftRepository;
            _aircraftModelRepository = aircraftModelRepository;
            _companyRepository = companyRepository;
            _countryRepository = countryRepository;
        }

        public List<ReportItem> GenerateReportAircraftInEurope(bool checkEU)
        {
            List<Aircraft> listOfEuropeanAircrafts = new List<Aircraft>();

            foreach (var aircraft in _aircraftRepository.Retrive())
            {
                if (_countryRepository.RetriveCountry(_companyRepository.RetriveCompany(aircraft.AircraftID).CompanyCountryCode).CountryEU == checkEU)
                {
                    listOfEuropeanAircrafts.Add(aircraft);
                }
            }

            ReportList = new List<ReportItem>();

            foreach (var europeanAircraft in listOfEuropeanAircrafts)
            {
                ReportList.Add(new ReportItem($"{europeanAircraft.AircraftTailNumber}",
                                              $"{_aircraftModelRepository.RetriveAircraftModel(europeanAircraft.AircraftModelID).ModelDescription}",
                                              $"{_companyRepository.RetriveCompany(europeanAircraft.AircraftID).OwnerCompanyName}",
                                              $"{_companyRepository.RetriveCompany(europeanAircraft.AircraftID).CompanyCountryCode}",
                                              $"{_countryRepository.RetriveCountry(_companyRepository.RetriveCompany(europeanAircraft.AircraftID).CompanyCountryCode).CountryName}"));
            }
            return ReportList;
        }
        public List<ReportItem> GenerateReportOfAircrafts()
        {
            List<Aircraft> listOfAircrafts = new List<Aircraft>();

            foreach (var aircraft in _aircraftRepository.Retrive())
            {
                    listOfAircrafts.Add(aircraft);
            }

            ReportList = new List<ReportItem>();

            foreach (var anyAircraft in listOfAircrafts)
            {
                ReportList.Add(new ReportItem($"{anyAircraft.AircraftTailNumber}",
                                              $"{_aircraftModelRepository.RetriveAircraftModel(anyAircraft.AircraftModelID).ModelDescription}",
                                              $"{_companyRepository.RetriveCompany(anyAircraft.AircraftID).OwnerCompanyName}",
                                              $"{_companyRepository.RetriveCompany(anyAircraft.AircraftID).CompanyCountryCode}",
                                              $"{_countryRepository.RetriveCountry(_companyRepository.RetriveCompany(anyAircraft.AircraftID).CompanyCountryCode).CountryName}"));
            }
            return ReportList;
        }
    }
}