using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class ReportItem
    {
        public string AircraftTailNumberItem { get; set; }
        public string ModelDescriptionItem { get; set; }
        public string OwnerCompanyNameItem { get; set; }
        public string CompanyCountryCodeItem { get; set; }
        public string CompanyCountryNameItem { get; set; }
        public ReportItem(string aircraftTailNumberItem, string modelDescriptionItem, string ownerCompanyNameItem, string companyCountryCodeItem, string companyCountryNameItem)
        {
            AircraftTailNumberItem = aircraftTailNumberItem;
            ModelDescriptionItem = modelDescriptionItem;
            OwnerCompanyNameItem = ownerCompanyNameItem;
            CompanyCountryCodeItem = companyCountryCodeItem;
            CompanyCountryNameItem = companyCountryNameItem;
        }
    }
}