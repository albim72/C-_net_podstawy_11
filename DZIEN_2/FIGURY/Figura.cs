using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public abstract class Figura
    {
        protected double a;
        protected double b;

        protected Figura(double a, double b) { 
            this.a = a;
            this.b = b;
            message();
        }
        public abstract double policzPole();

        public void message()
        {
            Console.WriteLine("To jest obiekt klasy abstrakcyjnej FIGURA!");
        }
    }
}
