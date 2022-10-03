using Lesson11_01.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Services
{
    internal class HTMLGenerator
    {
        public ReportGenerator ReportGenerator { get; set; }
        
        public HTMLGenerator(ReportGenerator reportGenerator)
        {
            ReportGenerator = reportGenerator;
        }
        public string GenerateHTMLWithColor(List<ReportItem> report)
        {
            string color;

            string aircraftList = "<html><style>\r\ntable, th, td{\r\n border-style: solid;\r\nborder-collapse: collapse;}\r\n</style><body><table style=\"width:50%\"><tr>" +
                                  "<th>Aircraft Tail Number</th>" +
                                  "<th>Model Description</th>"+
                                  "<th>Company Name</th>"+
                                  "<th>Country Code</th>"+
                                  "<th>Country Name</th></tr>";

            foreach (var aircraft in report)
            {
                if (aircraft.CompanyCountryCodeItem == "GER" ||
                    aircraft.CompanyCountryCodeItem == "LV" ||
                    aircraft.CompanyCountryCodeItem == "PL" ||
                    aircraft.CompanyCountryCodeItem == "HU" ||
                    aircraft.CompanyCountryCodeItem == "IT")
                {
                    color = "powderblue";
                }
                else if (aircraft.CompanyCountryCodeItem == "TR" ||
                         aircraft.CompanyCountryCodeItem == "CAN" ||
                         aircraft.CompanyCountryCodeItem == "IND" ||
                         aircraft.CompanyCountryCodeItem == "CN" ||
                         aircraft.CompanyCountryCodeItem == "CHE")
                {
                    color = "salmon";
                }
                else 
                {
                    color = "#FFFFFF";
                }
                    aircraftList = aircraftList + $"<tr style=\"background-color:{color};\">" +
                                                  $"<td>{aircraft.AircraftTailNumberItem}</td>" +
                                                  $"<td>{aircraft.ModelDescriptionItem}</td>" +
                                                  $"<td>{aircraft.OwnerCompanyNameItem}</td>" +
                                                  $"<td>{aircraft.CompanyCountryCodeItem}</td>" +
                                                  $"<td>{aircraft.CompanyCountryNameItem}</td></tr>";
            }

            aircraftList = aircraftList + "</table></body></html>";

            return aircraftList;
        }
    }
}