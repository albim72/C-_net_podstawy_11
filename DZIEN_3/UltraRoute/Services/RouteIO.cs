using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Text.Json;

namespace ultraRt.Services
{
    public static class RouteIO
    {
        public static void SaveToJson(Models.Route route, string filePath)
        {
            if(route == null)
            {
                throw new ArgumentNullException(nameof(route),"Nie można zapisać pustej trasy!");
            }
            if (string.IsNullOrEmpty(route.Name)) {
                throw new InvalidOperationException("Trasa musi mieć nazwę przed zapisaniem!");
            }

            try
            {
                var directory = Path.GetDirectoryName(filePath);
                if(!Directory.Exists(directory))
                {
                    Console.WriteLine($"Tworzenie brakującego katalogu: {directory}");
                    Directory.CreateDirectory(directory);
                }

                var jsonOptions = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                var json = JsonSerializer.Serialize(route,jsonOptions);

                File.WriteAllText(filePath,json);
                Console.WriteLine($"Trasa została zapisana do pliku: {filePath}");
            }catch (Exception ex)
            {
                Console.WriteLine($"coś poszło nie tak! {ex.Message}");
                throw;
            }
        }


        //Odczyt

        public static Models.Route LoadFromJson(string filePath)
        {
           
             var directory = Path.GetDirectoryName(filePath);
             if (!Directory.Exists(directory))
                {
                    Console.WriteLine($"Tworzenie brakującego katalogu: {directory}");
                    Directory.CreateDirectory(directory);
                }

              if(!File.Exists(filePath))
            {
                Console.WriteLine($"Plik {filePath} nie istnieje. Upewnij się że ten plik został skopiowany!");
                throw new FileNotFoundException($"Plik nie znaleziony!");
            }

            try
            {
                var json = File.ReadAllText(filePath);
                var route = JsonSerializer.Deserialize<Models.Route>(json);

                if (route == null || !route.IsValid)
                {
                    throw new Exception("Błędne dane trasy!");
                }
                return route;

            }
            catch (Exception ex)
            {
                Console.WriteLine("błąd ładowania pliku json!");
                throw;
            }
            
        }
    }
}
