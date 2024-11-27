using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prostokat pr = new Prostokat(9.8, 2.35);
            Console.WriteLine($"pole prostokąta: {pr.policzPole()}");


            Trojkat tr = new Trojkat(6.5, 7.8);
            Console.WriteLine($"pole trójkąta: {tr.policzPole()}");

            Trapez trp = new Trapez(7.4,5.4,4.3);
            Console.WriteLine($"pole trapeza: {trp.policzPole()}");

            Kolo kl = new Kolo(5.5);
            Console.WriteLine($"pole koła: {kl.policzPole()}");
            Console.ReadKey();
        }
    }
}
