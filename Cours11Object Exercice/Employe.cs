using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours11Object_Exercice
{
    public abstract class Employe
    {
        protected static int _matriculeCounter = 10230;
        protected int _matricule { get; set; }
        protected string _nom { get; set; }
        protected string _prenom { get; set; }
        protected DateTime _dateNaissance { get; set; }


        /// <summary>
        /// Auto Matricule increment from 10230
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        protected Employe(string nom, string prenom, DateTime dateNaissance)
        {
            _matricule = _matriculeCounter;
            _matriculeCounter++;
            _nom = nom;
            _prenom = prenom;
            _dateNaissance = dateNaissance;
        }

        protected Employe()
        {
        }

        /// <summary>
        /// abstract base for GetSalaire of child Classes
        /// </summary>
        /// <returns></returns>
        public abstract double GetSalaire();

        /// <summary>
        /// override of the base ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Matricule : {_matricule}\n" +
                   $"Nom                : {_prenom} {_nom}\n" +
                   $"Date Naissance     : {_dateNaissance.ToShortDateString()}\n";
        }
    }
}


