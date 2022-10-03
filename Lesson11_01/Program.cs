using Lesson11_01.Models;
using Lesson11_01.Repositories;
using Lesson11_01.Services;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lesson11_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReportGenerator report = new ReportGenerator(new AircraftRepository(),
                                                         new AircraftModelRepository(), 
                                                         new CompanyRepository(), 
                                                         new CountryRepository());
            
            HTMLGenerator htmlFile = new HTMLGenerator(report);

            int i = 0;
            foreach (var air in report.GenerateReportOfAircrafts())
            {
                i++;
                Console.WriteLine($"{i}. {air.AircraftTailNumberItem}");
            }

            File.WriteAllText("All_aircrafts.html", htmlFile.GenerateHTMLWithColor(report.GenerateReportOfAircrafts()));                    // All aircrafts
            File.WriteAllText("EU_aircrafts.html", htmlFile.GenerateHTMLWithColor(report.GenerateReportAircraftInEurope(true)));            // Aircrafts from EU country
            File.WriteAllText("non-EU_aircrafts.html", htmlFile.GenerateHTMLWithColor(report.GenerateReportAircraftInEurope(false)));       // Aircrafts not from EU country
        }
    }
}