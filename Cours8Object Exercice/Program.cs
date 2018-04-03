using System;
using LibS3.C8;

namespace Cours8Object_Exercice
{
     class Program
    {

        static void Main(string[] args)
        {
            //Cree Villagois
            var vil1 = new Villagois("Bob",4,100,55,9);
            var vil2 = new Villagois("Bobette", 2, 100, 99, 67);

            //Cree Hero : Villagois
            var hero1 = new Hero("Joe",12,100,55,12);

            //Affiche Villagois : Hero
            Console.WriteLine(hero1.ToString());
            Console.WriteLine(hero1.Inventaire());

            //Affiche Villagois
            Console.WriteLine(vil1.ToString());
            Console.WriteLine(vil2.ToString());

            //Cree Armes & Armure
            var arme1 = new Arme("Crayon Destructeur", 1);
            var armure1 = new Armure("Manteau de Pluie" , 1);
            //Equip Test
            hero1.Equiper(arme1);
            hero1.Equiper(armure1);
            //Affiche Test
            Console.WriteLine(hero1.Inventaire());


            Console.WriteLine();


            //Test Armes Armure Affichage ToString
            Console.WriteLine(hero1.Arme.ToString());
            Console.WriteLine(hero1.Armure.ToString());

            //afficher les obj cree
            Console.WriteLine(GetAffichageNbObjets());
            Console.WriteLine(GetAffichageNbVillagois());
        }
        

        /// <summary>
        /// Aurait pu faire part de la classe en tant que membre static pour quil sois facile a retrouver
        /// sapplique pour les 2
        /// </summary>
        /// <returns></returns>
        public static string GetAffichageNbObjets()
        {
            return "Nombre d'objets(and Childs) cree : " + Objet.Objectidcounter;
        }
        public static string GetAffichageNbVillagois()
        {
            return "Nombre de villagois(and Childs) cree : " + Villagois.VillagoisIdCounter;
        }
    }
}
