using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours2Objet
{
    class CompteBancaire
    {
        public string Titulaire { get; set; }
        public double Solde { get; set; }
        public string Devise { get; set; }

        public CompteBancaire(string titulaire, double solde, string devise)
        {
            Titulaire = titulaire;
            Solde = solde;
            Devise = devise;
        }

        public void Crediter(double montant)
        {
            Solde += montant;
        }

        public void Debiter(double montant)
        {
            Solde -= montant;
        }

    }
}
