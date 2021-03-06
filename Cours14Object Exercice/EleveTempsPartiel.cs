﻿using System;

namespace Cours14Object_Exercice
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

        public override string AssignerCours(Cours cours, bool optionnel)
        {
           return base.AssignerCours(cours);
        }

        public override string EnleverCours(Cours cours, bool optionnel)
        {
            return base.EnleverCours(cours);
        }
    }
}