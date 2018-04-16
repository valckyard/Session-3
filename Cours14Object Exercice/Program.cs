using System;
using System.Collections.Generic;

namespace Cours14Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var ele1 = new EleveTempsPlein("CARA29088212","Caron","Alexandre","800 dela plaine", new DateTime(1982,08,29));
            var ele2 = new EleveTempsPlein("VERB29088212", "Verier", "Bob", "800 dela plaine", new DateTime(1982, 08, 29));
            var ele3 = new EleveTempsPlein("CORO29088212", "Cornno", "Olivier", "800 dela plaine", new DateTime(1982, 08, 29));
            var ele4 = new EleveTempsPartiel("SUIE29088212", "Suif", "Evelyne", "800 dela plaine", new DateTime(1982, 08, 29));

            var crs1 = new Cours(123, "Cours1");
            var crs2 = new Cours(124, "Cours2");
            var crs3 = new Cours(125, "Cours3");
            var crs4 = new Cours(126, "Cours4");
            var crs5 = new Cours(127, "Cours5");


            Console.WriteLine("Test d'ajout de cours incomplet --Partiel\n");

            //adding classes
            ele4.AssignerCours(crs1);
            ele4.AssignerCours(crs2);
            //testing incomplete form
            Console.WriteLine(ele4.ToString());
            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Test ajout de cours non-existant et existant\n");
            
            ele4.AssignerCours(crs3);

            // cannot add more classes test
            Console.WriteLine(ele4.AssignerCours(crs3));
            // adding classes test
            Console.WriteLine(ele1.AssignerCours(crs1));
            ele1.AssignerCours(crs2);
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Test d'ajout de cours incomplet --TempsPlein\n");

            //testing incomplete form
            Console.WriteLine(ele1.ToString());
            Console.ReadLine();
            Console.Clear();



            ele1.AssignerCours(crs3);
            ele1.AssignerCours(crs4, true);
            ele1.AssignerCours(crs5, true);

            crs1.AjouterNote(ele1, 66.44);
            crs2.AjouterNote(ele1, 92.31);
            crs3.AjouterNote(ele1, 44.93);
            crs4.AjouterNote(ele1, 55.13);
            crs5.AjouterNote(ele1, 88.12);

            crs1.AjouterNote(ele4, 6.44);
            crs2.AjouterNote(ele4, 44.31);
            crs3.AjouterNote(ele4, 42.93);

            Console.WriteLine("Test de bulletins affichage --Plein et Partiel\n");

            // Compilation des Bulletins
            // &
            // Affichage des Bulletins
            BulletinReader(ele4.Bulletin());
            BulletinReader(ele1.Bulletin());
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Test de bulletins de cours --Classe Cours\n");
            // Bulletin Affichage Du Cours
            AfficherNotes(crs1.RapportNotesClasse());
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Test de ToString --Plein --Partiel et Cours\n");
            // Test des ToString
            Console.WriteLine(ele1.ToString());
            Console.WriteLine(ele4.ToString());
            Console.WriteLine(crs1.ToString());
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Impression des bulletins en fichiers -- Press enter to end\n");
            //Ecriture des Bulletins en Fichiers
            ele1.ImprimerBulletin();
            ele4.ImprimerBulletin();
            Console.ReadLine();
            Console.Clear();

        }

        public static void BulletinReader(List<string> bulletin)
        {
            foreach (var n in bulletin)
            {
                Console.WriteLine(n);
            }
        }

        public static void AfficherNotes(List<string> noteList)
        {
            foreach (var note in noteList)
            {
                Console.WriteLine(note);
            }
        }
    }
}