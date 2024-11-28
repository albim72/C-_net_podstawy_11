using System;
using System.Collections.Generic;
using System.Text;
using ultraRt.Utils;

namespace ultraRt.Models
{
    public class Route
    {
        public string Name { get; set; } = string.Empty;
        public List<Waypoint> Waypoints { get; set; } = new List<Waypoint>();
        public double TotalDistance => GeoUtils.CalculateTotalDistance(Waypoints);
        public double TotalElevationGain => GeoUtils.CalculateTotalEalevationGain(Waypoints);

        //walidacja trasy - sprawdza czy trasa ma poprawne dane!

        public bool IsValid => Waypoints.Count >= 2 && !string.IsNullOrEmpty(Name);

        //podsumowanie trasy...
        public override string ToString() =>
            $"Trasa biegowa: {Name}\n"+
            $"Całkowity dystans: {TotalDistance:F2} km\n"+
            $"Całkowite wzniesienie: {TotalElevationGain:F2} m\n" +
            $"Punkty kontrolne: {Waypoints.Count}";


    }
}
