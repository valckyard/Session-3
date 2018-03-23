using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Cours6Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }


        // Methodes Daffichages


        private static void AfficherClient(Client client)
        {
            Console.WriteLine($"User ID        : {client.Id}\n" +
                              $"Nom            : {client.Nom}\n" +
                              $"Prenom         : {client.Prenom}\n" +
                              $"Telephone      : {client.Tel}\n");
        }
        private static void AfficherCompte(Compte compte)
        {
            Console.WriteLine("   --- Resume de Compte ---\n" +
                              "_______________________________________________\n");

            AfficherClient(compte.Client);

            Console.WriteLine($"Compte ID : {compte.CompteClientId}\n" +
                              $"Solde     : {compte.Solde:C2}\n" +
                              $"_______________________________________________\n");
        }

        private static void GetNumberAccountsCreated()
        {
            Console.WriteLine($"\nNombre de comptes cree : {Compte.CompteNumIdIncrement}\n"); //pas de -1 car mes nombre de compte commencent a 0
        }


        private static void test()
        {
            var usager1 = new Client("Escobar", "Pablo", 18005558888);
            var usager2 = new Client("Trump", "Donald", 18003335555);

            var comptePab = new Compte(usager1);
            var compteDon = new Compte(usager2);

            Console.WriteLine("Test d'affichage press enter");
            Console.ReadLine();
            Console.Clear();

            AfficherCompte(comptePab);
            AfficherCompte(compteDon);

            GetNumberAccountsCreated();

            Console.WriteLine("Test de Ajout au compte press enter");
            Console.ReadLine();

            compteDon.Crediter(50000.33);
            comptePab.Crediter(53000.11);

            AfficherCompte(comptePab);
            AfficherCompte(compteDon);

            Console.WriteLine("Test de Transfers press enter\n" +
                              "Debite Don 14000");
            Console.ReadLine();

            compteDon.Debiter(comptePab, 14000.12);


            AfficherCompte(comptePab);
            AfficherCompte(compteDon);

            Console.WriteLine("Test de Transfers press enter \n" +
                              "Credite Pablo");
            Console.ReadLine();

            comptePab.Crediter(compteDon, 12000.11);

            AfficherCompte(comptePab);
            AfficherCompte(compteDon);

            Console.WriteLine("Test de Nombre de Comptes press enter");
            Console.ReadLine();

            GetNumberAccountsCreated();

            Console.ReadLine();
        }
        
       
    }
}
