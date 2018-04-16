using System;

namespace Cours10Object_Exercice_2
{
    public class Personne
    {
        protected string _nom { get; set; }
        protected string _prenom { get; set; }
        protected DateTime _dateNaissance { get; set; }

        public Personne(string nom, string prenom, DateTime dateNaissance)
        {
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
        }

        public Personne()
        {
        }

        public virtual string Afficher()
        {
            return $"Personne          : {_prenom} {_nom}\n" +
                   $"Date de Naissance : {_dateNaissance.ToShortDateString()}\n";
        }
    }
}
