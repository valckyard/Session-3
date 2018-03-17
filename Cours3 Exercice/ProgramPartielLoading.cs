using System.Collections.Generic;
using LibS3;
using LibS3.C3;

namespace Cours3_Exercice
{
   public partial class Program
    {
        private static void RectangleInit()
        {

            var monrect = new RectangleC3(5, 12);
            var monrect1 = new RectangleC3(5, 5);
            var monrect2 = new RectangleC3(12, 2);
            var monrect3 = new RectangleC3(8, 8);
            var monrect4 = new RectangleC3(2, 2);
            var recList = new List<RectangleC3>() { monrect, monrect1, monrect2, monrect3, monrect4 };

            foreach (var rec in recList)
            {
                AfficherRectangle(rec);
            }

        }



        private static void Livreinit()
        {
            var tax = new TaxesC3(0.0975, 0.05);
            var sda = new LivreC3("Le Seigneur des Anneaux Book 1", "J.R.R. Tolkien", 39.20);
            var sda2 = new LivreC3("Le Seigneur des Anneaux Book 2", "J.R.R. Tolkien", 29.99);
            var livListe = new List<LivreC3>() { sda, sda2 };

            foreach (var livre in livListe)
            {
                AfficherLivre(livre, tax);
            }
        }
    }
}
