using System;
using LibS3.C4;
using LibS3.C1;

namespace Cours4Object
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * private static to keep track of things in a class
             * 
             */
            var dev = new DevisesMonaitairesC1(DevName.CAD,0.72);

            var compte1 = new CompteBancaireC4("joe", 2.2, dev);
            Console.WriteLine(compte1.AfficherCompte());
            var compte2 = new CompteBancaireC4("joe", 2.2, dev);
            Console.WriteLine(compte2.AfficherCompte());
            var compte3 = new CompteBancaireC4("joe", 2.2, dev);
            Console.WriteLine(compte3.AfficherCompte());


        }

    }
}
