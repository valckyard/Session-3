using System;

namespace Cours12Object_Correction
{
    public class Ouvrier : Employe
    {
        private DateTime _embauche { get; set; }

        public Ouvrier()
        {
        }

        public Ouvrier(string nom, string prenom, DateTime dateNaissance, DateTime embauche) : base(nom, prenom, dateNaissance)
        {
            _embauche = embauche;
        }


        public override double GetSalaire()
        {
            double Salaire = (double)(((DateTime.Now.Year - _embauche.Year) * 100) + 2500)*12;

            if (Salaire >= 5000*12) return 50000*12;
            return Salaire;

        }

        public override string ToString()
        {
            return $"[Ouvrier]\n" + base.ToString() + $"Date _embauche : {_embauche}\n" +
                   $"Salaire    : {GetSalaire():C2}\n";
        }
    }
}