using System;

namespace Cours12Object_Correction
{
    public class Cadre : Employe
    {
        private int _indice { get; set; }

        protected Cadre(string nom, string prenom, DateTime dateNaissance, int indice) : base(nom, prenom, dateNaissance)
        {
            _indice = indice;
        }

        public override double GetSalaire()
        {
            return (double)((_indice * 3000 + 13000)*12);
        }

        public override string ToString()
        {
            return $"[Cadre]\n" + base.ToString() + $"Indice   : {_indice}\n" +
                   $"Salaire    : {GetSalaire():C2}\n";
        }
    }
}