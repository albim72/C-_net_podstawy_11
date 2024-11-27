using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Trapez:Figura
    {
        public double h;

        public Trapez(double a, double b, double h) : base(a, b)
        {
            this.h = h;
        }

        public override double policzPole()
        {
            return (a + b) * h / 2;
        }
    }
}
