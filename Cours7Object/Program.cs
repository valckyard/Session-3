using LibS3.C6;
using LibS3.C7;

namespace Cours7Object
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * La relation d~heirtage
             *
             * Mechanisme fondamental de POO
             *
             *
             * Ex compte (Cheque, Epargne)
             *
             * Epargne interet a largent
             *
             * Cheque pas interet
             *
             *
             * public class CompteEpargne : Compte
             *
             * C& CLASS
             *
             *
             * protected for derivated classes
             */
            var clienttest = new ClientC6("Bozo", "LeClown", 180088888888);
            var test = new CompteEpargneC6note(clienttest,0.01);

           
            
        }
    }
}
