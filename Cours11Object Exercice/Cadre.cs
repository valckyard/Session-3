using System;

namespace Cours11Object_Exercice
{
    public class Cadre : Employe
    {

        private int _indice;


        public Cadre(){}

        /// <summary>
        /// Cons for cadre adding _indice for salary purposes
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        /// <param name="indice"></param>
        public Cadre(string nom, string prenom, DateTime dateNaissance , int indice) : base(nom, prenom, dateNaissance)
        {
            _indice = indice;
        }


        /// <summary>
        /// Definition of GetSalaire using _indice to calculate 
        /// since it grow by 3000 for each indice from 1 that is 13000
        ///  _indice - 1 * 3000 is added to base (1 will none)
        /// </summary>
        /// <returns></returns>
        public override double GetSalaire()
        {
            return 13000 + ((_indice - 1)*3000);
        }


        /// <summary>
        /// redefinition of ToString for Cadre with his GetSalaire and his Indice
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "[Cadre]  " + base.ToString() + $"" +
                   $"Indice             : {_indice}\n" +
                   $"Salaire Mensuel    : {GetSalaire():C2}\n";
        }
    }
}