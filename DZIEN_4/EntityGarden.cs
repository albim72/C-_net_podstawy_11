using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenEntites
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GARDENEntities db = new GARDENEntities();
            DaneZTabel(db);
        }

        static void DaneZTabel(GARDENEntities dc)
        {
            var dane = from kl in dc.Klienci
                       from zam in dc.Zamówienia
                       where kl.IDKlienta == zam.IDKlienta && kl.Miasto == "Seattle"
                       select new
                       {
                           kl.Imię,
                           kl.Nazwisko,
                           kl.Miasto,
                           zam.IDZamówienia,
                           zam.KosztWysyłki
                       };
            foreach (var d in dane)
            {
                Console.WriteLine($"Dane klienta -> imię: {d.Imię}, nazwisko: {d.Nazwisko}, " +
                    $"miasto: {d.Miasto}");
                Console.WriteLine($"Dane Zamówienia -> ID Zamówienia:{d.IDZamówienia}. " +
                    $"koszt wysyłki: {d.KosztWysyłki} zł ");
            }

            Console.ReadKey();
        }
    }
}
