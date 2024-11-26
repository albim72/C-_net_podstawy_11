using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmienne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, result;
            float floatresult;
            x = 7;
            y = 5;
            result = x + y;
            Console.WriteLine("x+y = {0}",result);

            result = x - y;
            Console.WriteLine("x-y = {0}", result);

            result = x * y;
            Console.WriteLine("x*y = {0}", result);

            floatresult = (float)x / y;
            Console.WriteLine("x/y = {0}", floatresult);

            result = x % y;
            Console.WriteLine("x%y = {0}", result);

            result += x; //result = result + x
            Console.WriteLine("x*y = {0}", result);



            Console.ReadKey();
        }
    }
}
