using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rower rw = new Rower("Trek", "Madone", "Shimano");
            Console.WriteLine($"Przerzutka: {rw.modprz()}");
            Console.WriteLine(rw.info());
            Console.ReadKey();

        }
    }
}
