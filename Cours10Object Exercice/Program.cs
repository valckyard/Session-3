using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Cours10Object_Exercice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var voiture1 = new Voiture(1999, "Honda CR-V", 300.21);
            var voiture2 = new Voiture(2005, "Mitsubishi Lancer", 6701.21);
            var voiture3 = new Voiture(1969, "Pontiac Le Mans", 15030.12);

            var camion1 = new Camion(2000, "Ford F-150", 3200.11);
            var camion2 = new Camion(2017, "Ford F-350", 62800.77);
            var camion3 = new Camion(2012, "Dodge Ram", 17344.21);

            var vehicList = new List<Vehicule>();

            vehicList.Add(voiture1);
            vehicList.Add(voiture2);
            vehicList.Add(voiture3);

            vehicList.Add(camion1);
            vehicList.Add(camion2);
            vehicList.Add(camion3);


            foreach (var vehicule in vehicList)
            {
                Console.WriteLine();
                Console.WriteLine(vehicule.ToString());
                Console.WriteLine(vehicule.Accelerer());
                Console.WriteLine(vehicule.Demarrer());
                Console.WriteLine("_____________________________");
            }
        }
    }
}
