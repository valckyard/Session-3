namespace Cours09Object_Corrige
{
    public class Arme : Objet
    {
        public int Dommage { get; set; }

        public Arme()
        {
        }

        public Arme(string nom, int dommage) : base(nom)
        {
            Nom = nom;
            Dommage = dommage;
        }

        public override string ToString()
        {
            return $"   ~Arme No_{base.Id}~\n" +
                   $"Nom   : {base.Nom}\n" +
                   $"Dommage : {Dommage}\n";
        }

    }
}
