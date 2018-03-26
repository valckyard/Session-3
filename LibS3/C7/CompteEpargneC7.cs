using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibS3.C7
{
    public class CompteEpargneC7 : CompteC7
    {
        private int _tauxinteret;

        public CompteEpargneC7(): base()
        {
            _tauxinteret = 6;
        }

        public CompteEpargneC7(double solde): base(solde)
        {
            base.Solde = Solde;
            _tauxinteret = 6;
        }

        public void CalculInteret()
        {
            base.Solde *= (double)(100+_tauxinteret) / 100;
        }
    }
}
