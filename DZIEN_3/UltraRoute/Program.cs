using System;
using ultraRt.Services;

namespace ultraRt
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ładowanie danych trasy...");
            var route = RouteIO.LoadFromJson("Data/SampleRoutes.json");
            Console.WriteLine($"Załadowana trasa: {route.Name}");
            Console.WriteLine($"Całkowity dystans: {route.TotalDistance:F2} km");
            Console.WriteLine($"Całkowite wzniesienie: {route.TotalElevationGain:F2} m");

            Console.WriteLine(route.ToString());

            var steepSections = RouteAnalisys.FindSteepSections(route, 100);
            Console.WriteLine("Warunek -> (>100m)");
            foreach (var wp in steepSections)
            {
                Console.WriteLine($" - {wp.Name} w {wp.Elevation:F2} m");
            }

            RouteIO.SaveToJson(route, "Output/OptimizedRoute.json");
            Console.WriteLine("Trasa zapisana!");
            
        }
    }
}
