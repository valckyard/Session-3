using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibS3.C7
{
    public class CompteC7
    {

        private static int _codeincrement;
        private double _solde;
        private int _codecompte;

        public static int Codeincrement
        {
            get { return _codeincrement; }
        }

        public double Solde
        {
            get { return _solde; }
            protected set { _solde = value; }
        }

        public int Codecompte
        {
            get { return _codecompte; }
            set { _codecompte = value; }
        }




        public CompteC7()
        {
            _solde = 0;
            _codecompte = _codeincrement;
            ++_codeincrement;
        }

        public CompteC7(double solde)
        {
            _solde = solde;
            _codecompte = _codeincrement;
            ++_codeincrement;
        }

        public void Depot(double somme)
        {
            Solde += somme;
        }

        public void Retrait(double somme)
        {
            Solde -= somme;
        }

        public override string ToString()
        {
            return $"Numero Compte : {_codecompte}\n" +
                   $"Solde         : {_solde}";
        }
    }
}
