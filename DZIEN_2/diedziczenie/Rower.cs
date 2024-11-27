using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    public class Rower:Pojazd
    {
        string przerzutka;

        public Rower(string zmarka, string zmodel, string przerzutka) : base(zmarka, zmodel)
        {
            this.przerzutka= przerzutka;
        }

        public string modprz() {
            return $"model przerzutki: {przerzutka}";
        }
    }
}
