using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dziedziczenie
{
    public class Pojazd
    {
        public string zmarka;
        public string zmodel;

        public Pojazd(string zmarka, string zmodel)
        {
            this.zmarka = zmarka;
            this.zmodel = zmodel;
        }

        public string info()
        {
            return $"Marka: {zmarka}, model: {zmodel}";
        }
    }
}
