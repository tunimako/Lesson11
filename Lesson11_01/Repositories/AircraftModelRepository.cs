using Lesson11_01.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Repositories
{
    internal class AircraftModelRepository
    {
        private List<AircraftModel> AircraftModelList { get; set; }

        public AircraftModelRepository()
        {
            AircraftModelList = new List<AircraftModel>();
            AircraftModelList.Add(new AircraftModel(0, "Airbus A220"));
            AircraftModelList.Add(new AircraftModel(1, "Airbus A340"));
            AircraftModelList.Add(new AircraftModel(2, "Boeing 757"));
            AircraftModelList.Add(new AircraftModel(3, "Boeing 777"));
            AircraftModelList.Add(new AircraftModel(4, "Saab 2000"));
            AircraftModelList.Add(new AircraftModel(5, "Embraer 195"));
            AircraftModelList.Add(new AircraftModel(6, "Antonov An-140"));
            AircraftModelList.Add(new AircraftModel(7, "ATR 72 "));
            AircraftModelList.Add(new AircraftModel(8, "Bombardier"));
            AircraftModelList.Add(new AircraftModel(9, "CRJ-800"));
        }

        public List<AircraftModel> Retrive()
        {
            return AircraftModelList; 
        }

        public AircraftModel RetriveAircraftModel(int aircraftModelID)
        {
            return AircraftModelList.Where(c =>c.ModelID == aircraftModelID).FirstOrDefault();
        }
    }
}