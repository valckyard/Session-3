using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibS3.C7
{
   public class ComptePayantC7 : CompteC7
    {
        public ComptePayantC7(double Solde): base(Solde)
        {
        }

        public ComptePayantC7()
        {
        }


        public new void Depot(double somme)
        {
            base.Solde -= 5;
            base.Solde += somme;
        }
        public new void Retrait(double somme)
        {
            base.Solde -= 5;
            base.Solde -= somme;
        }

    }
}
