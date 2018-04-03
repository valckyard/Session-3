using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours09Object_Corrige
{
    public class Villagois
    {
        public int Id { get; protected set; }
        public static int CompteurId { get; protected set; }
        public string Nom { get; protected set; }
        public int Force { get; protected set; }
        public int Dexterite { get; protected set; }
        public int Endurance { get; protected set; }
        public int Intelligence { get; protected set; }

        public Villagois(){}

        public Villagois(string nom, int force, int dexterite, int endurance, int intelligence)
        {
            Nom = nom;
            Force = force;
            Dexterite = dexterite;
            Endurance = endurance;
            Intelligence = intelligence;
            Id = CompteurId;
            CompteurId++;
        }

        public override string ToString()
        {
            return $"     ~Villagois No_{Id}~\n" +
                   $"Nom          : {Nom}\n" +
                   $"Force        : {Force}\n" +
                   $"Dexterite    : {Dexterite}\n" +
                   $"Endurance    : {Endurance}\n" +
                   $"Intelligence : {Intelligence}\n";
        }
    }
}
