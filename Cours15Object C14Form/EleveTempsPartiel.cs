using System;
using System.Collections.Generic;

namespace Cours15Object_C14Form
{
    public class EleveTempsPartiel : Eleve
    {
        /// <summary>
        /// Est un eleve de base // rien a ajouter jusqua present
        /// </summary>
        public EleveTempsPartiel()
        {
        }

        public EleveTempsPartiel(string codePermanent, string nom, string prenom, string adresse,
            DateTime dateNaissance) : base(codePermanent, nom, prenom, adresse, dateNaissance)
        {
        }

        public override List<Cours> GetCoursOpt()
        {
            return base.GetCours();
        }

        public override string AssignerCours(Cours cours, bool optionnel)
        {
           return base.AssignerCours(cours);
        }

        public override string EnleverCours(Cours cours, bool optionnel)
        {
            return base.EnleverCours(cours);
        }

        public override string LoadCours(Cours cours, bool optionnel)
        {
            return base.LoadCours(cours);
        }
    }
}