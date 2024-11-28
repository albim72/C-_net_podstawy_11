using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukladsloneczny
{
    enum Planet
    {
        Merkury,
        Wenus,
        Ziemia,
        Mars,
        Jowisz,
        Saturn,
        Uran,
        Neptun,
        Pluton
    }

    class PlanetInfo
    {
        public double Radius { get; set; }
        public double Mass { get; set; }
        public double Gravity { get; set; }

        public PlanetInfo(double radius, double mass)
        {
            Radius = radius;
            Mass = mass;
            //stała grawitacji
            const double G = 6.67430e-11;
            Gravity = G*Mass/Math.Pow(Radius*1000,2);
        }
    }
}
