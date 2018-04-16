using System;

namespace Cours10Object_Exercice_2
{
    public class Employe : Personne
    {
        protected double _salaire { get; set; }

        public Employe()
        {
        }

        public Employe(string nom, string prenom, DateTime dateNaissance, double salaire) : base(nom, prenom, dateNaissance)
        {
            _salaire = salaire;
        }

        public override string Afficher()
        {
            return base.Afficher() + $"Salaire           : {_salaire:C2}\n";
        }
    }
}