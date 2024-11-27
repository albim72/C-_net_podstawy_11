using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejs_pojazd
{
    internal interface IPojazd
    {
        void dlugosc_pojazdu();
        string kolor_pojazdu();
        int liczbadrzwi(int ldrzwi);
    }
}
