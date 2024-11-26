using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daty
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string date = "2024-11-11";
            DateTime dt = Convert.ToDateTime(date);
            Console.WriteLine("Rok: {0}, Miesiąc: {1}, Dzień: {2}",dt.Year,dt.Month,dt.Day);

            IFormatProvider culture = new System.Globalization.CultureInfo("pl-PL",true);
            DateTime dt2 = DateTime.Parse(date,culture,System.Globalization.DateTimeStyles.AssumeLocal);
            Console.WriteLine(dt2);
            Console.WriteLine("Rok: {0}, Miesiąc: {1}, Dzień: {2}", dt2.Year, dt2.Month, dt2.Day);

            DateTime dzisiaj = DateTime.Today;
            TimeSpan odstepCzasu = dzisiaj - dt;
            string odstep = odstepCzasu.TotalDays.ToString();
            Console.WriteLine("upłynęło dni: " + odstep);


            string tekst = "to jest ważna informacja";
            Console.WriteLine(tekst);

            Console.WriteLine($"Ciąg znaków: {tekst}, ma długość {tekst.Length} znaków");
            string nadmiar = "           cena oleju napędowego rośnie...             ";
            Console.WriteLine(nadmiar);
            string trimOlej = nadmiar.TrimStart();
            Console.WriteLine(trimOlej + "bbbb");
            trimOlej = nadmiar.TrimEnd();
            Console.WriteLine(trimOlej + "bbbb");
            trimOlej = nadmiar.Trim();
            Console.WriteLine(trimOlej + "bbbb");


            Console.ReadKey();
        }
    }
}
