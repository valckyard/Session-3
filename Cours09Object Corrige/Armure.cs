namespace Cours09Object_Corrige
{
    public class Armure : Objet
    {
        public int Defense { get; set; }

        public Armure()
        {
        }

        public Armure(string nom, int defense) : base(nom)
        {
            Nom = nom;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"   ~Armure No_{base.Id}~\n" +
                   $"Nom   : {base.Nom}\n" +
                   $"Defense : {Defense}\n";
        }
    }
}
