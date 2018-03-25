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
            var taxes = new TaxesC3(0.095, 0.005);
            var article1 = new ArticleC4("Vraiment pas bon", 1.60, taxes, "Cherry Blossom");
            article1.AfficherArticle();

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Copie de l'article 1");
            var article4 = new ArticleC4(article1);
            article4.AfficherArticle();

            Console.ReadLine();
            Console.Clear();

            var article2 = new ArticleC4("Legume vert avec des feuilles", "Salade Iceberg");
            article2.AfficherArticle();

            Console.ReadLine();
            Console.Clear();

            var article3 = new ArticleC4(null, 1.10, null, null);
            article3.AfficherArticle();


            Console.ReadLine();
            Console.Clear();

            var article5 = new ArticleC4();

            article5.AfficherArticle();
            Console.ReadLine();

        }

        public static void AfficherArticle(ArticleC4 art)
        {
            {
                if (art.Taxes == null & art.PrixArticle == 0 & art.Designation == null & art.References == null)
                {
                    Console.WriteLine("Cet Article est initialise mais vide...");
                }
                else
                {

                    Console.Write("Article     : " + art.Designation + "\n" +
                                  "Description : " + art.References + "\n");
                    if (Math.Abs(art.PrixArticle) > 0)
                    {
                        Console.Write("Prix        : " + art.PrixArticle.ToString("C2") + "\n");
                    }

                    if (art.Taxes != null)
                    {
                        Console.Write("TVQ         : " + (art.PrixArticle * art.Taxes.Tvq).ToString("C2") + "\n" +
                                      "TPS         : " + (art.PrixArticle * art.Taxes.Tps).ToString("C2") + "\n" +
                                      $"Prix Total  : {art.CalculerTotal()}");
                    }

                    if (art.PrixArticle > 0 & art.Taxes == null)
                    {
                        Console.Write("Prix Total  : " + art.PrixArticle.ToString("C2") + "(Aucune Taxes Lie)\n");
                    }
                }
            }
        }
    }
}
