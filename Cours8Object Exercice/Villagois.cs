namespace Cours8Object_Exercice
{
    public class Villagois
    {
        //Counter for number of Villagois
        private static int _villagoisIdCounter;

        //Each Villagois id
        private int _id;

        //prop of Villagois
        private string _nom;

        private int _force;

        private int _endurance;

        private int _dexterite;

        private int _intelligence;

        //static accessor for number created
        public static int VillagoisIdCounter
        {
            get { return  _villagoisIdCounter; }
           protected set { _villagoisIdCounter = value; }
        }

        //Accessors

        public string Nom
        {
            get { return _nom; }
        protected     set { _nom = value; }
        }

        public int Force
        {
            get { return _force; }
         protected   set { _force = value; }
        }

        public int Endurance
        {
            get { return _endurance; }
          protected  set { _endurance = value; }
        }

        public int Dexterite
        {
            get { return _dexterite; }
           protected set { _dexterite = value; }
        }

        public int Intelligence
        {
            get { return _intelligence; }
         protected   set { _intelligence = value; }
        }

        public int Id
        {
            get { return _id; }
           protected set { _id = value; }
        }

        //base constructor
        public Villagois(string nom, int force, int endurance, int dexterite, int intelligence)
        {
            _nom = nom;
            _force = force;
            _endurance = endurance;
            _dexterite = dexterite;
            _intelligence = intelligence;
            _id = _villagoisIdCounter;
            _villagoisIdCounter++;
        }

        //empty one
        public Villagois()
        {
        }

        //return string for affichage
        public override string ToString()
        {
            return $"   ~Villager Stats~\n" +
                   $"ID           : {_id}\n" +
                   $"Nom          : {_nom}\n" +
                   $"Force        : {_force}\n" +
                   $"Endurance    : {_endurance}\n" +
                   $"Dexterite    : {_dexterite}\n" +
                   $"Intelligence : {_intelligence}\n";
        }
    }
}
