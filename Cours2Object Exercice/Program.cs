using LibS3;
using LibS3.C2;

namespace Cours2Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var tax = new TaxesC2(0.075,0.05);
            var sda = new LivreC2("Le Seigneur des Anneaux Book 1","J.R.R. Tolkien", 39.20);
            var sda2 = new LivreC2("Le Seigneur des Anneaux Book 2", "J.R.R. Tolkien", 29.99);

            sda.Afficher();
            sda2.Afficher();

            sda.AfficherAvecTaxes(tax);
            sda2.AfficherAvecTaxes(tax);
        }
    }
}
