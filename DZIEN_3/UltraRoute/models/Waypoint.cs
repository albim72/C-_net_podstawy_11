using System;
using System.Collections.Generic;
using System.Text;

namespace ultraRt.Models
{
    public class Waypoint
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Elevation { get; set; } //wysokość w metrach
    }
}
