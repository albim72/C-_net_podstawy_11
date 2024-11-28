using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegat
{

    public delegate int Dzialanie(int x, int y);

    public class Matma
    {
        public int dodaj(int liczba1, int liczba2)
        {
            return (liczba1 + 2 * liczba2);
        }

        public int odejmij(int liczba1, int liczba2)
        {
            return (5*liczba1 - 3 * liczba2);
        }
    }
    public class Program
    {
        
               
        static void Main(string[] args)
        {
            Matma matma = new Matma();
            Dzialanie dzialanie = new Dzialanie(matma.dodaj);
            Dzialanie drugie = new Dzialanie(matma.odejmij);

            Console.WriteLine(dzialanie(5,7));  
            Console.WriteLine(dzialanie(434,1345));
            Console.WriteLine(dzialanie.Invoke(11, 4));

            Console.WriteLine(drugie(5, 7));
            Console.WriteLine(drugie(434, 1345));
            Console.WriteLine(drugie.Invoke(11, 4));

            Console.ReadKey();
        }
    }
}
