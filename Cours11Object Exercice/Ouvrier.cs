using System;

namespace Cours11Object_Exercice
{
    public class Ouvrier : Employe
    {

        private static double _salaireMin = 2500;
        private DateTime _dateEmbauche { get; set; }

        /// <summary>
        /// Using base and adding a Hire Date
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        /// <param name="dateEmbauche"></param>
        public Ouvrier(string nom, string prenom, DateTime dateNaissance , DateTime dateEmbauche) : base(nom, prenom, dateNaissance)
        {
            _dateEmbauche = dateEmbauche;
        }

        public Ouvrier(){}


        /// <summary>
        /// GetSalaire calculated as 100$ per month more for each year hired
        /// </summary>
        /// <returns></returns>
        public override double GetSalaire()
        {
            double _salaireMensuel = ((double)( DateTime.Now.Year - _dateEmbauche.Year) * 100) + (double)_salaireMin;
            if (_salaireMensuel > (_salaireMin*2))
            {
                return  _salaireMin * 2;
            }
            else
            {
                return _salaireMensuel;
            }
        }

        /// <summary>
        /// Redefinition of Tostring adding HireDate and salary
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[Ouvrier]"+ base.ToString() + $"" +
                   $"Date Embauche      : {_dateEmbauche.ToShortDateString()}\n" +
                   $"Salaire Mensuel    : {GetSalaire():C2}\n";
        }
    }
}