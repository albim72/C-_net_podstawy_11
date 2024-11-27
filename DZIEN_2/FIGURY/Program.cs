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



            Console.ReadKey();
        }
    }
}
