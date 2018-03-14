using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours2Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var sda = new Livre("Le Seigneur des Anneaux Book 1","J.R.R. Tolkien", 39.20);
            var sda2 = new Livre("Le Seigneur des Anneaux Book 2", "J.R.R. Tolkien", 29.99);

            sda.Afficher();
            sda2.Afficher();
        }
    }
}
