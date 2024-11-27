using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
    public class Kolo : Figura
    {
        public Kolo(double a) : base(a)
        {
        }

        public override double policzPole()
        {
            return Math.PI * Math.Pow(a, 2);
        }
    }
}
