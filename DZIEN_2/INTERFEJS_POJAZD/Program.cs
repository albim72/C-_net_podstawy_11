using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejs_pojazd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto opel = new Auto("osobowy", 5.8, "czarny", "diesel", 9.9, 3.3);
            opel.dlugosc_pojazdu();
            Console.WriteLine($"koszty podróży na 100km = {opel.koszty(6.23)} zł");
            opel.pojemnosc();
            Console.WriteLine($"liczba drzwi: {opel.liczbadrzwi(4)}");
            Console.WriteLine($"rodzaj silnika: {opel.rodzajsilnika()}");
            Console.WriteLine($"spalanie: {opel.spalanie()}");
            Console.WriteLine($"kolor: {opel.kolor_pojazdu()}");

            Console.ReadKey();
        }
    }
}
