using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Trojkat : Figura
    {
        public Trojkat(double a, double b) : base(a, b)
        {
        }

        public override double policzPole()
        {
            return a * b / 2;
        }
    }
}
