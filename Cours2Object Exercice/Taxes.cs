using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours2Object_Exercice
{
    public class Taxes
    {
        public double Tvq { get; set; }
        public double Tps { get; set; }

        public Taxes(double tvq, double tps)
        {
            Tvq = tvq;
            Tps = tps;
        }
    }
}
