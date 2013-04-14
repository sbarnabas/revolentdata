using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RevolentData.Models
{
    public class LocationQueryFilter
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Location { get; set; }
        public string SearchValue { get; set; }
        public int Distance { get; set; }
    }
}
