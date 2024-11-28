using System;
using System.Collections.Generic;
using System.Text;
using ultraRt.Models;

namespace ultraRt.Services
{
    public static class RouteAnalisys
    {
        public static IEnumerable<Waypoint> FindSteepSections(Route route,double elevationThreshold)
        {
            for (int i=1;i<route.Waypoints.Count;i++)
            {
                double elevationDiff = route.Waypoints[i].Elevation - route.Waypoints[i-1].Elevation;
                if (elevationDiff > elevationThreshold)
                {
                    yield return route.Waypoints[i];
                }
            }
        }

        public static Route OptimizeRoute(Route route,Func<Route,bool> criteria) {
            return criteria(route) ? route : null;
        }
    }
}
