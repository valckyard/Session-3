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
         
            Console.WriteLine("Titre  : " + Titre + "\n" +
                              "Auteur : " + NomAuteur + "\n" +
                              "Prix   : " + Prix.ToString("C2") + "\n");

        }

        public void AfficherAvecTaxes(Taxes taxes)
        {
            Console.WriteLine("Titre  : " + Titre + "\n" +
                              "Auteur : " + NomAuteur + "\n" +
                              "Prix   : " + Prix.ToString("C2") + "\n" +
                              "TVQ    : " + (Prix*taxes.Tvq).ToString("C2") +"\n" +
                              "TPS    : " + (Prix*taxes.Tps).ToString("C2") +"\n" +
                              "PrixTot: " + (Prix + (Prix * taxes.Tvq) + (Prix * taxes.Tps)).ToString("C2") +"\n");
        }
    }
}
