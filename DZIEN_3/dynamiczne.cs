using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamiczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic value1 = "mojprogram";
            dynamic value2 = false;
            dynamic value3 = 323;
            dynamic value4 = 12.4564;

            Console.WriteLine($"Wartość: {value1}, Typ: {value1.GetType().ToString()}");
            Console.WriteLine($"Wartość: {value2}, Typ: {value2.GetType().ToString()}");
            Console.WriteLine($"Wartość: {value3}, Typ: {value3.GetType().ToString()}");
            Console.WriteLine($"Wartość: {value4}, Typ: {value4.GetType().ToString()}");

            value3 = "trzy";
            Console.WriteLine($"Wartość: {value3}, Typ: {value3.GetType().ToString()}");
            Console.ReadKey();
        }
    }
}
