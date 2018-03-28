namespace Cours8Object_Exercice
{
    public class Hero : Villagois
    {
        private Arme _arme;

        private Armure _armure;


        public Arme Arme
        {
            get { return _arme; }
           private set { _arme = value; }
        }

        public Armure Armure
        {
            get { return _armure; }
           private set { _armure = value; }
        }



        // constructor using base att protected
        public Hero(string nom, int force, int endurance, int dexterite, int intelligence) : base(nom, force, endurance, dexterite, intelligence)
        {
            Arme = new Arme("Mains Nues",0);
            Armure = new Armure("Vetements", 0);
        }

        public Hero()
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
                   $"Intelligence : {base.Intelligence}\n" +
                   $"Arme         : {Arme.Nom}\n" +
                   $"Armure       : {Armure.Nom}\n";
        }


        //Thats what it is !
        public void Equiper(Arme arme)
        {
            _arme = arme;
        }

        public void Equiper(Armure armure)
        {
            _armure = armure;
        }
    }
}