using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibS3.C9.C9Corrige_2
{
    public class CompteC9
    {
        public static int CompteurCode { get; protected set; }
        public int Code { get; protected set; }
        public double Solde { get; protected set; }
        public ClientC9 Client { get; protected set; }
        public static List<int> UsedCodes = new List<int>();

        public CompteC9()
        {
        }

        public CompteC9(ClientC9 client)
        {
            Client = client;
            Code = CompteurCode;
            CompteurCode++;
            UsedCodes.Add(Code);
        }

        public string Crediter(double somme)
        {
            try
            {
                Solde += somme;
                return "Reussi";
            }
            catch (Exception)
            {
                return "Erreur";
            }
        }


        public string Crediter(CompteC9 compte, double somme)
        {
            try
            {
                if (compte.Debiter(somme) == "Reussi")
                {
                    Solde += somme;
                    return "Reussi";
                }
                else
                {
                    return "Erreur";
                }
            }
            catch (Exception)
            {
                return "Erreur";
            }
        }


        public string Debiter(double somme)
        {
            try
            {
                if ((this.Solde -= somme) >= 0)
                {
                    return "Reussi";
                }
                else
                {
                    return "Erreur";
                }
            }
        
            catch (Exception)
            {
                return "Erreur";
            }
      
        }

        public string Debiter(CompteC9 compte, double somme)
        {
            try
            {
                if (this.Debiter(somme) == "Reussi")
                {
                    compte.Crediter(somme);
                    return "Reussi";
                }
                else
                {
                    return "Erreur";
                }
            }
            catch (Exception)
            {
                return "Erreur"; 
            }
        }

        

        public string Afficher()
        {
            return $"___________________________________\n" +
                   $"~Compte : Code_{this.Code}\n" +
                   $"Solde  : {this.Solde}\n" +
                   $"___________________________________\n" +
                   $"{this.Client.Afficher()}";
        }

        
    }
}
