using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_01.Models
{
    internal class AircraftModel
    {
        public int ModelID { get; set; }
        public string ModelDescription { get; set; }
        public AircraftModel(int modelID, string modelDescription)
        {
            ModelID = modelID;
            ModelDescription = modelDescription;
        }
    }
}