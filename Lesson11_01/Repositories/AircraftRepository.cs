using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.Models;

namespace Lesson11_01.Repositories
{
    internal class AircraftRepository
    {
        private List<Aircraft> AircraftList { get; set; }
        public AircraftRepository()
        {
            AircraftList = new List<Aircraft>();

            for (int i = 0; i < 5000; i++)
            {
                Random rnd = new Random();
                int ascii_index1 = rnd.Next(65, 91);
                int ascii_index2 = rnd.Next(65, 91);
                string randomUpperCase1 = Convert.ToString(Convert.ToChar(ascii_index1));
                string randomUpperCase2 = Convert.ToString(Convert.ToChar(ascii_index2));
                string randomNumebr1 = Convert.ToString(rnd.Next(0, 10));
                string randomNumebr2 = Convert.ToString(rnd.Next(0, 10));

                AircraftList.Add(new Aircraft($"{randomUpperCase1}{randomNumebr1}{randomNumebr2}{randomUpperCase2}", 
                                                 rnd.Next(1000, 10000),
                                                 Int32.Parse(randomNumebr2),
                                                 Int32.Parse(randomNumebr1)));
            }
        }
        public Aircraft RetriveAircraft(int aircraftID)
        {
            return AircraftList.Where(c => c.AircraftID == aircraftID).FirstOrDefault();
        }

        public List<Aircraft> Retrive()
        {
            return AircraftList;
        }
    }
}