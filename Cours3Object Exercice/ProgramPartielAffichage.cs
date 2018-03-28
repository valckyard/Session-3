using System;
using LibS3;
using LibS3.C3;

namespace Cours3_Exercice
{
    public partial class Program
    {


        public static void AfficherRectangle(RectangleC3 rec)
        {
            Console.Write("╔");
            for (int i = 0; i < rec.Largeur * 2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");


            int counter = 1;
            for (int i = 0; i < rec.Longeur; i++)
            {
                Console.SetCursorPosition(0, counter);
                Console.Write("║");
                Console.SetCursorPosition(rec.Largeur * 2 + 1, counter);
                Console.Write("║\n");
                ++counter;
            }

            Console.SetCursorPosition(0, counter);
            Console.Write("╚");
            for (int i = 0; i < rec.Largeur * 2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");

            ++counter;
            Console.SetCursorPosition(0, counter);
            Console.Write($"Longeur   : {rec.Longeur}\n" +
                          $"Largeur   : {rec.Largeur}\n" +
                          $"Aire      : {rec.Aire()}\n" +
                          $"Perimetre : {rec.Perimetre()}\n" +
                          $"Carre     : {rec.EstCarre()}\n");
            Console.ReadLine();
            Console.Clear();
        }



        public static void AfficherLivre(LivreC3 liv, TaxesC3 taxesC3)
        {

            Console.WriteLine("Titre  : " + liv.Titre + "\n" +
                              "Auteur : " + liv.NomAuteur + "\n" +
                              "Prix   : " + liv.Prix.ToString("C2") + "\n\n");


            Console.WriteLine("Titre  : " + liv.Titre + "\n" +
                              "Auteur : " + liv.NomAuteur + "\n" +
                              "Prix   : " + liv.Prix.ToString("C2") + "\n" +
                              "TVQ    : " + (liv.Prix * taxesC3.Tvq).ToString("C2") + "\n" +
                              "TPS    : " + (liv.Prix * taxesC3.Tps).ToString("C2") + "\n" +
                              "PrixTot: " + (liv.Prix + (liv.Prix * taxesC3.Tvq) + (liv.Prix * taxesC3.Tps)).ToString("C2") + "\n\n");

            Console.WriteLine("Enter for next one...");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
