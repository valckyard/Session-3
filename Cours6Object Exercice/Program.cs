using System;
using LibS3.C6;

namespace Cours6Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }


        // Methodes Daffichages


        private static void AfficherClient(ClientC6 clientC6)
        {
            Console.WriteLine($"User ID        : {clientC6.Id}\n" +
                              $"Nom            : {clientC6.Nom}\n" +
                              $"Prenom         : {clientC6.Prenom}\n" +
                              $"Telephone      : {clientC6.Tel}\n");
        }
        private static void AfficherCompte(CompteC6 compteC6)
        {
            Console.WriteLine("   --- Resume de CompteC6 ---\n" +
                              "_______________________________________________\n");

            AfficherClient(compteC6.ClientC6);

            Console.WriteLine($"CompteC6 ID : {compteC6.CompteClientId}\n" +
                              $"Solde     : {compteC6.Solde:C2}\n" +
                              $"_______________________________________________\n");
        }

        private static void GetNumberAccountsCreated()
        {
            Console.WriteLine($"\nNombre de comptes cree : {CompteC6.CompteNumIdIncrement}\n"); //pas de -1 car mes nombre de compteC6 commencent a 0
        }


        private static void test()
        {
            var usager1 = new ClientC6("Escobar", "Pablo", 18005558888);
            var usager2 = new ClientC6("Trump", "Donald", 18003335555);

            var comptePab = new CompteC6(usager1);
            var compteDon = new CompteC6(usager2);

            Console.WriteLine("Test d'affichage press enter");
            Console.ReadLine();
            Console.Clear();

            AfficherCompte(comptePab);
            AfficherCompte(compteDon);

            GetNumberAccountsCreated();

            Console.WriteLine("Test de Ajout au compteC6 press enter");
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
