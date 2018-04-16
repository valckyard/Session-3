using System;
using LibS3.C9.C9Corrige_2;

namespace Cours9Object_Corrige
{
    class Program
    {
        static void Main(string[] args)
        {

            var moncli = new ClientC9(26 ,"test", "test", 188888888);
            var moncli2 = new ClientC9(26 ,"test", "test", 188888888);
            var moncli3 = new ClientC9(88, "test", "test", 188888888);
            var moncli4 = new ClientC9(88, "test", "test", 188888888);

            var hiscompte = new CompteC9(moncli);
            var hiscompte2 = new CompteC9(moncli3);


            Console.WriteLine(moncli.Id);
            Console.WriteLine(moncli2.Id);
            Console.WriteLine(moncli3.Id);
            Console.WriteLine(hiscompte2.Afficher());


        }
    }
}
