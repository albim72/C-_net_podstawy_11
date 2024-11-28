using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack mstos = new Stack();

            mstos.Push("ważna informacja");
            mstos.Push("bilet numer: 58349");
            mstos.Push(8756544332);
            mstos.Push(true);
            mstos.Push(22.3);

            foreach(var em in mstos)
            {
                Console.WriteLine(em);
            }

            var k1  = mstos.Pop();
            Console.WriteLine(k1);

            Console.WriteLine("________________________");
            foreach (var em in mstos)
            {
                Console.WriteLine(em);
            }

            Console.WriteLine("___________ KOLEJKA _____________");
            Queue mqu = new Queue();

            mqu.Enqueue("XXXXXXXX");
            mqu.Enqueue(753544523);
            mqu.Enqueue(false);
            mqu.Enqueue(0.765);
            mqu.Enqueue("Xabc");

            Console.WriteLine("________________________");
            foreach (var em in mqu)
            {
                Console.WriteLine(em);
            }

            var k2 = mqu.Peek();
            Console.WriteLine(k2);
            Console.WriteLine("________________________");
            foreach (var em in mqu)
            {
                Console.WriteLine(em);
            }

           
            Console.ReadKey();
        }
    }
}
