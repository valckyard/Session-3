using System;

namespace Cours10Object_Exercice_2
{
    public class Directeur : Chef
    {
        private string _societe { get; set; }

        public Directeur(string nom, string prenom, DateTime dateNaissance, double salaire, string service,
            string societe) : base(nom, prenom, dateNaissance, salaire, service)
        {
            _societe = societe;
        }

        public Directeur()
        {
        }

        public override string Afficher()
        {
            return base.Afficher() + $"Societe           : {_societe}\n";
        }
    }
}