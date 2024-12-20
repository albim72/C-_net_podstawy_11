using System;
using System.Collections.Generic;
using System.Text;
using ultraRt.Models;

namespace ultraRt.Utils
{
    public class GeoUtils
    {
        private const double EarthRadiusKm = 6371;

        public static double CalculateTotalDistance(List<Waypoint> waypoints)
        {
            double totalDistance = 0;
            for(int i=1; i<waypoints.Count;i++)
            {
                totalDistance += Haversine(
                        waypoints[i - 1].Latitude, waypoints[i - 1].Longitude,
                        waypoints[i].Latitude, waypoints[i].Longitude);
            }
            return totalDistance;
        }


        public static double CalculateTotalEalevationGain(List<Waypoint> waypoints)
        {
            double totalElevation = 0;
            for (int i = 1; i < waypoints.Count; i++)
            {
                double elevationDiff = waypoints[i].Elevation - waypoints[i-1].Elevation;
                if(elevationDiff > 0)
                {
                    totalElevation += elevationDiff;
                }
            }
            return totalElevation;
        }


        private static double Haversine(double lat1, double lon1, double lat2, double lon2)
        {
            double dLat = DegreesToRadians(lat2 - lat1);
            double dLon = DegreesToRadians(lon2 - lon1);

            double a = Math.Sin(dLat/2)*Math.Sin(dLat/2) +
                Math.Cos(DegreesToRadians(lat1))* Math.Cos(DegreesToRadians(lat2))*
                Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return EarthRadiusKm* c;
        }

        private static double DegreesToRadians(double degrees) => degrees * Math.PI / 180;
    }
}
