using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibS3.C7;

namespace Cours7Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
           var mamaison = new MaisonC7(5,"13500 Rue des Pinsons");
            Console.WriteLine(mamaison.ToString());

            var monbatim = new BatimentC7("1234567 violette");
            Console.WriteLine(monbatim.ToString());
        }
    }
}
