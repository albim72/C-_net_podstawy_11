using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Prostokat : Figura
    {
        public Prostokat(double a, double b) : base(a, b)
        {
        }

        public override double policzPole()
        {
            return a * b;
        }
    }
}
