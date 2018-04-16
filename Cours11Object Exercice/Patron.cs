using System;

namespace Cours11Object_Exercice
{
    public class Patron : Employe
    {
        public static double _chiffreAffaire { get; private set; }
        private double _pourcentage { get; set; }

        public Patron(){}

        /// <summary>
        /// using base and adding _pourcentage
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        /// <param name="pourcentage"></param>
        public Patron(string nom, string prenom, DateTime dateNaissance , double pourcentage) : base(nom, prenom, dateNaissance)
        {
            _pourcentage = pourcentage;
        }


        /// <summary>
        /// using _pourcetage to define salary
        /// </summary>
        /// <returns></returns>
        public override double GetSalaire()
        {
            //remove from total ?
            return (_chiffreAffaire * _pourcentage);
        }

        /// <summary>
        /// needed something to add to chiffreAffaire and didint want to set it public directly nor define a base in all of them
        /// </summary>
        /// <param name="somme"></param>
        public static void AddToChiffreAffaire(double somme) //would add a password at minimum haha
        {
            _chiffreAffaire += somme;
        }

        /// <summary>
        /// Redefinition of ToString  / Chiffre Affaires / Pourcentage // GetSalaire
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[Patron] " + base.ToString() + $"Chiffre d'Affaires : {_chiffreAffaire:C2}\n" +
                   $"Poucentage         : {_pourcentage:P2}\n" +
                   $"Salaire Mensuel    : {GetSalaire():C2}\n";
        }
    }
}