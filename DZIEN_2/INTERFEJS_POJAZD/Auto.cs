using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejs_pojazd
{
    internal class Auto:IPojazd,ISilnik
    {
        string rodzaj_pojazdu;
        double dl;
        string kolorn;
        string rodzaj_silnika;
        double spalna100;
        double poj;

        public Auto(string rodzaj_pojazdu, double dl, string kolorn, string rodzaj_silnika, double spalna100, double poj)
        {
            this.rodzaj_pojazdu = rodzaj_pojazdu;
            this.dl = dl;
            this.kolorn = kolorn;
            this.rodzaj_silnika = rodzaj_silnika;
            this.spalna100 = spalna100;
            this.poj = poj;
        }

        public void dlugosc_pojazdu()
        {
            Console.WriteLine($"długość pojazdu wynosi: {dl}");
        }

        public string kolor_pojazdu()
        {
            return kolorn;
        }

        public double koszty(double cena)
        {
            return cena * spalna100;
        }

        public int liczbadrzwi(int ldrzwi)
        {
            return ldrzwi;
        }

        public void pojemnosc()
        {
            Console.WriteLine($"Pojemność silnika wynosi: {poj}");
        }

        public string rodzajsilnika()
        {
            return $"rodzaj silnika: {rodzaj_silnika}";
        }

        public double spalanie()
        {
            return spalna100;
        }
    }
}
