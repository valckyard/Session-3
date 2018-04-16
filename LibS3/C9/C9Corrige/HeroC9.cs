namespace LibS3.C9.C9Corrige
{
    public class HeroC9 : VillagoisC9
    {
        public ArmeC9 Arme { get; set; }
        public ArmureC9 Armure { get; set; }

        public HeroC9(){}

        public HeroC9(string nom, int force, int dexterite, int endurance, int intelligence) : base(nom, force, dexterite, endurance, intelligence)
        {
            Arme = new ArmeC9("Mains Nues", 0);
            Armure = new ArmureC9("Vetements", 0);
        }

        public HeroC9(string nom, int force, int dexterite, int endurance, int intelligence, ArmeC9 arme, ArmureC9 armure) : base(nom, force, dexterite, endurance, intelligence)
        {
            Arme = arme;
            Armure = armure;
        }


        public void Equiper(ArmeC9 arme, ArmureC9 armure)
        {
            Arme = arme;
            Armure = armure;
        }

        public void Equiper(ArmureC9 armure)
        {
            Armure = armure;
        }
        public void Equiper(ArmeC9 arme)
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
