using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejs_pojazd
{
    internal interface ISilnik
    {
        void pojemnosc();
        double spalanie();
        double koszty(double cena);
        string rodzajsilnika();
    }
}
