using Lesson11_01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Repositories
{
    internal class CompanyRepository
    {
        private List<Company> CompanyList { get; set; }

        public CompanyRepository()
        {
            CompanyList = new List<Company>();
            CompanyList.Add(new Company(0, "Lufthansa", "GER"));
            CompanyList.Add(new Company(1, "airBaltic", "LV"));
            CompanyList.Add(new Company(2, "Turkish Airlines", "TR"));
            CompanyList.Add(new Company(3, "WestJet", "CAN"));
            CompanyList.Add(new Company(4, "IndiGo", "IND"));
            CompanyList.Add(new Company(5, "China Airlines", "CN"));
            CompanyList.Add(new Company(6, "LOT", "PL"));
            CompanyList.Add(new Company(7, "EasyJet", "CHE"));
            CompanyList.Add(new Company(8, "WizzAir", "HU"));
            CompanyList.Add(new Company(9, "Neos", "IT"));
        }

        public List<Company> Retrive()
        {
            return CompanyList;
        }

        public Company RetriveCompany(int companyID)
        {
            return CompanyList.Where(c => c.CompanyID == companyID).FirstOrDefault();
        }
    }
}