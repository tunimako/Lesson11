using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class Aircraft
    {
        public string AircraftTailNumber { get; set; }
        public int AircraftNumber { get; set; }
        public int AircraftID { get; set; }
        public int AircraftModelID { get; set; }

        public Aircraft(string aircraftTailNumber, int aircraftNumber, int aircraftID, int aircraftModelID)
        {
            AircraftTailNumber = aircraftTailNumber;
            AircraftNumber = aircraftNumber;
            AircraftID = aircraftID;
            AircraftModelID = aircraftModelID;
        }
    }
}