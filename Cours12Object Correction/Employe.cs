using System;

namespace Cours12Object_Correction
{
    public abstract class Employe
    {
        protected static int MatriculeCounter = 0;

        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected DateTime DateNaissance { get; set; }
        protected int Matricule { get; set; }

        protected Employe() {  }

        protected Employe(string nom, string prenom, DateTime dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            Matricule = MatriculeCounter;
            MatriculeCounter++;
        }

        public abstract double GetSalaire();

        public override string ToString()
        {
            return $"Matricule      : {Matricule}\n" +
                   $"Nom            : {Prenom} {Nom}\n" +
                   $"Date Naissance : {DateNaissance.ToShortDateString()}\n";
        }
    }
}