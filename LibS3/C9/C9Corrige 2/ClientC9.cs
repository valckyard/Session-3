using System.Collections.Generic;

namespace LibS3.C9.C9Corrige_2
{
    public class ClientC9
    {
        public static int CompteurId { get; private set; }
        public int Id { get; private set; }
        public string Nom { get; private set; }
        public string Prenom { get; private set; }
        public long Telephone { get; private set; }
        public static List<int> UsedIds = new List<int>();

        public ClientC9(string nom, string prenom, long telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
            while (UsedIds.Contains(CompteurId))
            {
                CompteurId++;
            }

            Id = CompteurId;

            UsedIds.Add(Id);
        }

        

        public ClientC9(int id, string nom, string prenom, long telephone)
        {
            if (id >= CompteurId & !UsedIds.Contains(id))
            {
                Id = id;
                UsedIds.Add(Id);
            }
            else
            {
                Id = CompteurId;
                CompteurId++;
                UsedIds.Add(Id);
            }
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }

        public ClientC9()
        {
        }

        public string Afficher()
        {
            return $"~Client : No_{Id}~ \n" +
                   $"Nom        :  {Prenom} {Nom}\n" +
                   $"Telephone  : {Telephone}\n" +
                   $"__________________________________\n";
        }
    }
}
