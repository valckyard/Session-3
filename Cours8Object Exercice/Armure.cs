namespace Cours8Object_Exercice
{
    public class Armure : Objet
    {
        // prop defence de l armure
        private int _defense;

        public int Defense
        {
            get { return _defense; }
            private set { _defense = value; }
        }

        public Armure()
        {
        }

        public Armure(string nom, int defense) : base(nom)
        {
            _defense = defense;
        }

        //Return string pour affichage
        public override string ToString()
        {
            return $"Armure\n" +
                   $"ID        : {base.Id}\n" +
                   $"Nom       : {base.Nom}\n" +
                   $"Dommage : {_defense}\n";
        }
    }
}