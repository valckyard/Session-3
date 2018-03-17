using System;

namespace LibS3.C2
{
    public class RectangleC2
    {
        public int Longeur { get; set; }
        public int Largeur { get; set; }

        public RectangleC2(int longeur, int largeur)
        {
            Longeur = longeur;
            Largeur = largeur;
        }

        public int Perimetre()
        {
            int perimetre = (Longeur * 2) + (Largeur * 2);
            return perimetre;
        }

        public int Aire()
        {
            int aire = Longeur * Largeur;
            return aire;
        }

        public string EstCarre()
        {
            if (Longeur == Largeur)
            {
                return "Est un Carre !";
            }
            else
            {
                return "N'est pas un Carre !";
            }
        }

        public void AfficherRectangle()
        {
            Console.Write("╔");
            for (int i = 0; i < Largeur*2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╗");


            int counter = 1;
            for (int i = 0; i < Longeur; i++)
            {
                Console.SetCursorPosition(0,counter);
                Console.Write("║");
                Console.SetCursorPosition(Largeur*2+1,counter);
                Console.Write("║\n");
                ++counter;
            }

            Console.SetCursorPosition(0,counter);
            Console.Write("╚");
            for (int i = 0; i < Largeur*2; i++)
            {
                Console.Write("═");
            }
            Console.Write("╝");

            ++counter;
            Console.SetCursorPosition(0,counter);
            Console.Write($"Longeur   : {Longeur}\n" +
                          $"Largeur   : {Largeur}\n" +
                          $"Aire      : {Aire()}\n" +
                          $"Perimetre : {Perimetre()}\n" +
                          $"Carre     : {EstCarre()}\n");

        }
    }
}
