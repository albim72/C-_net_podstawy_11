using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var imiona  = new List<string> {".....","<name>","Anna","Leon","Ola","Piotr","Olga","Ludwik","Fela"};
            Console.WriteLine(imiona);
            imiona.Add("Maria");
            imiona.Add("Karol");
            imiona.Add("...");

            foreach(var n in imiona)
            {
                Console.WriteLine($"użytkownik serwisu:: {n.ToUpper()}");
            }

            Console.WriteLine("_________________________________");
            Console.WriteLine($"użytkownik z pozycji 3: {imiona[2]}");
            Console.WriteLine($"użytkownicy z pozycji 3-5: {imiona[2][3]}");
            Console.WriteLine($"liczba użytkowników: {imiona.Count -1}");

            int[] tablica = new int[10];
            for(int i=0;i<tablica.Length;i++)
            {
                tablica[i] = 2*i*i;
            }

            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine($"tablica[{i}] - {tablica[i]}");
            }

            Console.ReadKey();
        }
    }
}
