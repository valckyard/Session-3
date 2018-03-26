using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibS3.C7;

namespace Cours7Object_Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {

            var comptestd = new CompteC7(122);

            var compteep = new CompteEpargneEX2C7(444);

            var comptepay = new ComptePayantC7(100);

            comptepay.Retrait(1);
            comptepay.Depot(1);
            Console.WriteLine(comptepay.ToString());

            Console.WriteLine();

            compteep.CalculInteret();
            Console.WriteLine(compteep.ToString());

            Console.WriteLine();

            comptestd.Retrait(123);
            Console.WriteLine(comptestd.ToString());
      
        }
    }
}
