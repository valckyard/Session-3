using System;
using System.Collections.Generic;

namespace Cours10Object_Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // forward slash dont work well with datetime in a primitive container new DateTime(1978 - 03 - 12)
            var pers1 = new Personne("Bocho","Bob",new DateTime(1978,03,12));
            var pers2 = new Personne("Bocho", "Tim", new DateTime(1971 , 11 , 22));
            var pers3 = new Personne("Bocho", "Keren", new DateTime(1978 , 12 , 17));
            var pers4 = new Personne("Bocho", "Chose", new DateTime(1978 , 01 , 01));
            var pers5 = new Personne("Bocho", "Truc", new DateTime(1978 , 08 , 08));
            var pers6 = new Personne("Bocho", "Machin", new DateTime(1978 , 06 , 22));
            var pers7 = new Personne("Bocho", "Chose", new DateTime(1978 , 09 , 29));
            var pers8 = new Personne("Bocho", "Patente", new DateTime(1978 , 02 , 13));

            var emp1 = new Employe("Tremblay", "Maxime", new DateTime(2001 , 04 , 23),15.19);
            var emp2 = new Employe("Tremblay", "Gertrude", new DateTime(1991 , 03 , 30),12.88);
            var emp3 = new Employe("Tremblay", "Patricia", new DateTime(1999 , 07 , 21),13.90);
            var emp4 = new Employe("Tremblay", "George", new DateTime(1967 , 09 , 16),11.67);
            var emp5 = new Employe("Tremblay", "Bill", new DateTime(1953 , 02 , 03), 10.75);

            var chf1 = new Chef("Gagnon", "Sylvain", new DateTime(1944 , 12 , 23), 22.50, "Paye");
            var chf2 = new Chef("Gagnon", "Hermanegille", new DateTime(1974 , 11 , 09), 24.50, "Operations");

            var dir1 = new Directeur("Boss", "Big",new DateTime(1964,01,06),33.42,"Direction","Deneigeurs du Royaume" );

            var cieList = new List<Personne>
            {
                pers1,
                pers2,
                pers3,
                pers4,
                pers5,
                pers6,
                pers7,
                pers8,
                emp1,
                emp2,
                emp3,
                emp4,
                emp5,
                chf1,
                chf2,
                dir1
            };

            //foreach (var personne in cieList)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("________________________________");
            //    Console.WriteLine(personne.Afficher());
            //    Console.WriteLine("________________________________");
            //}

            Console.WriteLine($"\tAfficher le tableau avec un for");
            Console.ReadLine();

            Personne[] cieTab = new Personne[cieList.Count];

            for (int i = 0; i < cieList.Count; i++)
            {

                cieTab[i] = cieList[i];

                Console.WriteLine();
                Console.WriteLine(cieTab[i].Afficher());
                Console.WriteLine("________________________________");
            }

            Console.WriteLine($"\tAfficher le tableau avec un foreach");
            Console.ReadLine();

            foreach (var personne in cieTab)
            {
                Console.WriteLine();
                Console.WriteLine(personne.Afficher());
                Console.WriteLine("________________________________");
            }
        }
    }
}
