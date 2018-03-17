using System;

namespace LibS3.C2
{
    public class LivreC2
    {
        public string Titre { get; set; }
        public string NomAuteur { get; set; }
        public double Prix { get; set; }

        public LivreC2(string titre, string nomAuteur, double prix)
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

        public void AfficherAvecTaxes(TaxesC2 taxes)
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
