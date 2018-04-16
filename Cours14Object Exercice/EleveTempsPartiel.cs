using System;

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
    }
}