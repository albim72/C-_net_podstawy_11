using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa_generyczna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABLICA GENERYCZNA (INT)");

            MojaGenerycznaTablica<int> intArray = new MojaGenerycznaTablica<int>(5);
            for (int i=0; i<5; i++) {
                intArray.setGenericValue(i, i * 3);
            }
            for (int i=0; i < 5; i++)
            {
                Console.WriteLine($"Liczba: {intArray.getGenericItem(i)}");
            }

            Console.WriteLine("ZWYKŁA TABLICA INT");

            MojaGenerycznaTablica<int> intArrayzW = new MojaGenerycznaTablica<int>(5);
            for (int i = 0; i < 5; i++)
            {
                intArrayzW.setValue(i, i * 5);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Liczba: {intArrayzW.getItem(i)}");
            }

            Console.WriteLine("TABLICA GENERYCZNA (char)");

            MojaGenerycznaTablica<char> charArray = new MojaGenerycznaTablica<char>(5);
            for (int i = 0; i < 5; i++)
            {
                charArray.setGenericValue(i, (char)(i+97));
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"L" +
                    $"iczba: {charArray.getGenericItem(i)}");
            }
            Console.ReadKey();
        }
    }
}
