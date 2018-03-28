using System;
using LibS3;
using LibS3.C1;

namespace Cours2Objet
{
    class Program
    {
        static void Main(string[] args)
        {
			var CAD = new DevisesMonaitairesC1 (DevName.CAD, 0.72);
			//var USD = new DevisesMonaitaires (DevName.USD, 1.0);
			var EUR = new DevisesMonaitairesC1 (DevName.EUR, 1.32);

			var Pierre = new CompteBancaireC1 ("Pierre Bono", 0.2, CAD);

			Pierre.Crediter (20.22);
			Pierre.Debiter (2.11);

			double converted = Pierre.SoldeConverter (EUR);
			Console.WriteLine ($"Solde de "+ Pierre.Titulaire +" en "+ EUR.Name +" "+ converted);

        }
    }
}
