using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours09Object_Corrige
{
    public class Objet
    {
        public int Id { get; protected set; }
        public static int CompteurId { protected get; set; }
        public string Nom { get; protected set; }

        public Objet()
        {
        }

        public Objet(string nom)
        {
            Nom = nom;
            Id = CompteurId;
            CompteurId++;
        }
    }
}
