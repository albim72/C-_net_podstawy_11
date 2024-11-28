using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukladsloneczny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var planets = new[]
            {
                        new PlanetInfo(2439.7,3.3011e23), //Merkury,
                        new PlanetInfo(6051.8,4.87e24),//Wenus,
                        new PlanetInfo(6371,5.97e24),//Ziemia,
                        new PlanetInfo(3389.5,6.42e23),//Mars,
                        new PlanetInfo(69911,1.9e27),//Jowisz,
                        new PlanetInfo(58232,5.68e26),//Saturn,
                        new PlanetInfo(25362,8.7e25),//Uran,
                        new PlanetInfo(24622,1.024e26),//Neptun,
                        new PlanetInfo(1190,1.3e22)//Pluton
            };



        }
    }
}
