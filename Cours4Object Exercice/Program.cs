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

            Console.WriteLine("Copie de l'article 1");
            var article4 = new ArticleC4(article1);
            article4.AfficherArticle();

            Console.ReadLine();
            Console.Clear();

            var article2 = new ArticleC4("Legume vert avec des feuilles","Salade Iceberg");
            article2.AfficherArticle();

            Console.ReadLine();
            Console.Clear();

            var article3 = new ArticleC4(null,1.10,null,null);
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
                if (art.Taxes == null & PrixArticle == 0 & Designation == null & References == null)
                {
                    Console.WriteLine("Cet Article est initialise mais vide...");
                }
                else
                {

                    Console.Write("Article     : " + Designation + "\n" +
                                  "Description : " + References + "\n");
                    if (Math.Abs(PrixArticle) > 0)
                    {
                        Console.Write("Prix        : " + PrixArticle.ToString("C2") + "\n");
                    }

                    if (Taxes != null)
                    {
                        Console.Write("TVQ         : " + (PrixArticle * Taxes.Tvq).ToString("C2") + "\n" +
                                      "TPS         : " + (PrixArticle * Taxes.Tps).ToString("C2") + "\n" +
                                      $"Prix Total  : {CalculerTotal()}");
                    }

                    if (PrixArticle > 0 & Taxes == null)
                    {
                        Console.Write("Prix Total  : " + PrixArticle.ToString("C2") + "(Aucune Taxes Lie)\n");
                    }
                }
            }
        }
}
