using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metody
{
    internal class Program
    {

        static void MojaMetoda()
        {
            Console.WriteLine("pierwsza metoda klasy. Metoda statyczna!");
        }

        static void PodajImie(string imie = "Piotr")
        {
            Console.WriteLine($"uczestnik konferencji: {imie}");
        }

        static int obliczenie(int a,int b, int c)
        {
            return a + b - c;
        }

        static int plus(int x,int y)
        {
            return x + 2*y;
        }

        static double plus(double x,double y) {
            return  x - 2*y;
        }

        static double minus(double x,double y, double z) {
            return plus(x, y) - z;
        }


        static void Main(string[] args)
        {
            MojaMetoda();
            MojaMetoda();
            MojaMetoda();

            PodajImie("Janek");
            PodajImie("Anna");
            PodajImie();

            Console.WriteLine(obliczenie(5,7,1));
            Console.WriteLine(plus(9,6));
            Console.WriteLine(plus(5.74,23.5));
            Console.WriteLine(plus(4.3,4));
            Console.WriteLine(minus(6.7,3.2,7.7));

            Console.ReadKey();
        }
    }
}
