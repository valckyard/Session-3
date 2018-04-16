using System;

namespace Cours12Object_Correction
{
    public class Patron : Employe
    {
        public static double ChiffreAffaire { get; private set; }
        public double Pourcentage { get; set; }

        protected Patron()
        {
        }


        protected Patron(string nom, string prenom, DateTime dateNaissance, double pourcentage) : base(nom, prenom, dateNaissance)
        {
            Pourcentage = pourcentage;
        }


        public override double GetSalaire()
        {
            ChiffreAffaire = 12000000.11;
            return (ChiffreAffaire * Pourcentage) / 100;
        }

        public override string ToString()
        {
            return $"[Cadre]\n" + base.ToString() + $"Chiffre d'Affaires  : {ChiffreAffaire}\n" +
                   $"Pourcentage   : {Pourcentage:P2}\n" +
                   $"Salaire       : {GetSalaire():C2}\n";
        }
    }
}