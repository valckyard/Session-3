namespace Cours09Object_Corrige
{
    public class Hero : Villagois
    {
        public Arme Arme { get; set; }
        public Armure Armure { get; set; }

        public Hero(){}

        public Hero(string nom, int force, int dexterite, int endurance, int intelligence) : base(nom, force, dexterite, endurance, intelligence)
        {
            Arme = new Arme("Mains Nues", 0);
            Armure = new Armure("Vetements", 0);
        }

        public Hero(string nom, int force, int dexterite, int endurance, int intelligence, Arme arme, Armure armure) : base(nom, force, dexterite, endurance, intelligence)
        {
            Arme = arme;
            Armure = armure;
        }


        public void Equiper(Arme arme, Armure armure)
        {
            Arme = arme;
            Armure = armure;
        }

        public void Equiper(Armure armure)
        {
            Armure = armure;
        }
        public void Equiper(Arme arme)
        {
            Arme = arme;
        }

        public string Inventaire()
        {
            return $"     ~Inventaire~\n" +
                   $"{Arme.ToString()}\n" +
                   $"{Armure.ToString()}\n";
        }

        public override string ToString()
        {
            return $"      ~Hero~\n" +
                   $"{base.ToString()}\n" +
                   $"{Inventaire()}\n";
        }
    }
}
