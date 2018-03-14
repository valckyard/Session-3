using System;

namespace Cours2Object_Exercice
{
    public class Livre
    {
        public string Titre { get; set; }
        public string NomAuteur { get; set; }
        public double Prix { get; set; }

        public Livre(string titre, string nomAuteur, double prix)
        {
            Titre = titre;
            NomAuteur = nomAuteur;
            Prix = prix;
        }

        public void Afficher()
        {
            Console.WriteLine("Titre  : "+ Titre +"\n" +
                              "Auteur : " + NomAuteur+ "\n" +
                              "Prix   : "+ Prix +"\n");

        }
    }
}
