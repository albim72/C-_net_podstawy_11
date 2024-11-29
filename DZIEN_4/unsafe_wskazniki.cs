using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wskazniki
{
    internal class Program
    {

        public unsafe void Swap(int* a,int* b)
        {
            int temp = *a;
            *a = *b;
            *b= temp;
        }
        unsafe static void Main(string[] args)
        {
            Program pr = new Program();
            int a = 10;
            int b = 190;
            int* ap = &a;
            int* bp = &b;
            Console.WriteLine($"wartości przez zmianą: a = {a}, b = {b}");
            pr.Swap(ap, bp);

            Console.WriteLine($"wartości po zmianie: a = {a}, b = {b}");
            Console.ReadKey();
        }
    }
}
