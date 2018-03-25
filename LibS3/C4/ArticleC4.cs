using System;
using LibS3.C3;

namespace LibS3.C4
{
    public class ArticleC4
    {
        public string References { get; set; }
        public double PrixArticle { get; set; }
        public TaxesC3 Taxes { get; set; }
        public string Designation { get; set; }

        public ArticleC4()
        {
            References = null;
            PrixArticle = 0;
            Taxes = null;
            Designation = null;
        }

        public ArticleC4(string References, double PrixArticle, TaxesC3 Taxes, string Designation)
        {
            this.References = References;
            this.PrixArticle = PrixArticle;
            this.Taxes = Taxes;
            this.Designation = Designation;
        }

        public ArticleC4(string references, string designation)
        {
            References = references;
            Designation = designation;
            PrixArticle = 0;
            Taxes = null;
        }

        public ArticleC4(ArticleC4 previousArticle)
        {
            References = previousArticle.References;
            PrixArticle = previousArticle.PrixArticle;
            Taxes = previousArticle.Taxes;
            Designation = previousArticle.Designation;
        }


        public string CalculerTotal()
        {
            return (PrixArticle + (PrixArticle * Taxes.Tvq) + (PrixArticle * Taxes.Tps)).ToString();
        }



        //METTRE EN METHODE STAT
        public void AfficherArticle()
        {
            {
                if (Taxes == null & PrixArticle ==0 & Designation == null & References == null)
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
}