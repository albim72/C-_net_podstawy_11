using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_delegat
{
    internal class Program
    {

        private delegate int Operacja(int x);

        static int Transform(int value, Operacja operacja)
        {
            int wynik = operacja(value);
            return wynik;
        }

        private static int Cube(int a) => a * a * a;
        private static int Square(int a) => a * a;

        static void Main(string[] args)
        {
            int sq = Transform(5, Square);
            int qb = Transform(5, Cube);

            Console.WriteLine($"Wartość dla a = 5, kwadrat: {sq}, sześcan: {qb}");
            Console.ReadKey();
        }
    }
}
