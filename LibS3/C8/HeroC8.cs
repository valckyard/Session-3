namespace LibS3.C8
{
    public class HeroC8 : VillagoisC8
    {
        private ArmeC8 _arme;

        private ArmureC8 _armure;


        public ArmeC8 Arme
        {
            get { return _arme; }
           private set { _arme = value; }
        }

        public ArmureC8 Armure
        {
            get { return _armure; }
           private set { _armure = value; }
        }



        // constructor using base att protected
        public HeroC8(string nom, int force, int endurance, int dexterite, int intelligence) : base(nom, force, endurance, dexterite, intelligence)
        {
            Arme = new ArmeC8("Mains Nues",0);
            Armure = new ArmureC8("Vetements", 0);
        }

        public HeroC8()
        {
        }

        //Weapon and armor display
        public string Inventaire()
        {
            return $"    ~Inventaire~\n" +
                   $"{Arme}{Armure}";
        }

        //display full Hero Characteristics
        //I put the tag since its the exercise objective
        public override string ToString()
        {
            return $"     ~Hero Stats~\n" +
                   $"ID           : {base.Id}\n" +
                   $"Nom          : {base.Nom}\n" +
                   $"Force        : {base.Force}\n" +
                   $"Endurance    : {base.Endurance}\n" +
                   $"Dexterite    : {base.Dexterite}\n" +
                   $"Intelligence : {base.Intelligence}" +
                   $"{Inventaire()}";

        }


        //Thats what it is !
        public void Equiper(ArmeC8 arme)
        {
            _arme = arme;
        }

        public void Equiper(ArmureC8 armure)
        {
            _armure = armure;
        }
    }
}