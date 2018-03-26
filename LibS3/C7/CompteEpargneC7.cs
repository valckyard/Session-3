using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibS3.C7
{
    public class CompteEpargneEX2C7 : CompteC7
    {
        private int _tauxinteret;

        public CompteEpargneEX2C7()
        {
            _tauxinteret = 6;
        }

        public CompteEpargneEX2C7(double Solde): base(Solde)
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
