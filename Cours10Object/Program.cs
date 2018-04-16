using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours10Object
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Polymorphisme
             *
             * inherit class can be added to same list of parents
             *
             * ex list<comptebancaire>  add comptebancaire compteepargre(CHILD OF BANK) comptecheque
             *
             *          compte bancaire
             *          |           |
             *  compte epargne  compte courrant
             *
             *  - compte bancaire (inclus tout en commun)
             *      -is an abstract class (never used but is common ground) //only used on base parent
             *              that will never be used
             *
             *      -abstract method
             *          public abstract void Debiter(double somme); //no need for brackets
             *          -  all abstract will be overriden
             *          
             *compte courrant
             *
             *
             *      -no carte
             *      -decouvert
             *      -pas plus que la moitie de l argent
             *
             *
             * les descriptions sont differentes mais utilise la base virtuelle et utilise override et redefinie ou complete
             *
             *
             */
        }
    }
}
