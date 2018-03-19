using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibS3.C4;
using LibS3.C3;

namespace Cours4Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxes = new TaxesC3(0.095,0.005);
            var article1 = new ArticleC4("Vraiment pas bon",1.60,taxes,"Cherry Blossom");
            article1.AfficherArticle();

            Console.ReadLine();
            Console.Clear();

            var article2 = new ArticleC4("Legume vert avec des feuilles","Salade Iceberg");

            article2.AfficherArticle();

            Console.ReadLine();
            Console.Clear();

            var article3 = new ArticleC4();

            article3.AfficherArticle();
            Console.ReadLine();

        }
    }
}
