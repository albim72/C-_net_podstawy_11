using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrukcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 8;
            int c = 4;

            if((a+b+c > 10) && (a==b))
            {
                Console.WriteLine("wartość > 10");
                Console.WriteLine("wartość a=b");
            }
            else
            {
                Console.WriteLine("wartość <= 10");
                Console.WriteLine("wartość a != b");
            }

            //przpadek wielokrotny
            string danew;
            int liczbaw;

            mojstart:

            Console.WriteLine("Podaj dane pomiędzy 1 a 3: ");
            danew= Console.ReadLine();
            liczbaw = Int32.Parse(danew);

            switch(liczbaw)
            {
                case 1:
                    Console.WriteLine($"Twój wybór to liczba: {liczbaw}");
                    break;
                case 2:
                    Console.WriteLine($"Twój wybór to liczba: {liczbaw}");
                    break;
                case 3:
                    Console.WriteLine($"Twój wybór to liczba: {liczbaw}");
                    break;
                default:
                    Console.WriteLine($"Twój wybór to liczba: {liczbaw}, liczba jest niepoprawna!");
                    break;

            }

            decyzja:

            Console.WriteLine("Wypisz -> jeśli chcesz kontynumować: \"K\", jeśli chcesz zakończyć" +
                " to wpisz: \"W\"");
            danew= Console.ReadLine();

            switch (danew)
            {
                case "K":
                    goto mojstart;
                case "W":
                    Console.WriteLine("Koniec sprawdzania!");
                    break;
                default:
                    Console.WriteLine("dane niewłaściwe, wybierz jeszcze raz...");
                    goto decyzja;
            }
            Console.ReadKey();
        }
    }
}
