using System;
using System.Text;

namespace LibS3.C3
{
    public class EmployeC3
    {
        public int Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public DateTime DateEmbauche { get; set; }
        public double Salaire { get; set; }

        public EmployeC3(int matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEmbauche, double salaire)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
            DateEmbauche = dateEmbauche;
            Salaire = salaire;
        }

        public int Age()
        {
            return DateTime.Now.Year - DateNaissance.Year;
        }

        public int Anciennete()
        {
            return DateTime.Now.Year - DateEmbauche.Year;
        }

        public void AugmentationDuSalaire()
        {
            if (Anciennete()<5)
            {
                Salaire *= 1.02;
            }

            if (Anciennete()<10)
            {
                Salaire *= 1.05;
            }
            else
            {
                Salaire *= 1.10;
            }
        }

        public string Aprenom()
        {
            // string test = prenom.ToLower();
            // test.ElementAt(1).ToUpper;
            // return test;

            StringBuilder builder = new StringBuilder();
            if (Prenom != null)
            {
                string s = null;
                char[] modulatedsurname = Prenom.ToCharArray();
                for (int i = 0; i < modulatedsurname.Length; i++)
                {
                    if (i == 0) // Premier element maj
                    {
                        s = modulatedsurname[i].ToString();
                        s = s.ToUpper();
                       builder.Insert(i,s);
                    }
                    else //autres elem minuscule
                    {
                        s = modulatedsurname[i].ToString();
                        s = s.ToLower();
                        builder.Insert(i, s);
                    }
                }
            }
           // return (double)(DateTime.Today - _dateDeNaissance).Days / 365;
            return builder.ToString();
        }

        public void AfficherEmploye()
        {
            Console.Write($"Matricule : {Matricule}\nNom Complet : {Aprenom()} {Nom.ToUpper()}\nAge : {Age()}\nAnciennete : {Anciennete()}\nSalaire : {Salaire.ToString("C2")}\n");
        }
    }
}
