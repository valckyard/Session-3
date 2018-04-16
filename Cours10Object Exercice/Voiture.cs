namespace Cours10Object_Exercice
{
    public class Voiture : Vehicule
    {
        public Voiture()
        {
        }

        public Voiture(int annee, string modele, double prix) : base(annee,modele,prix)
        {
            
        }

        public override string Accelerer()
        {
            return $"Cette Voiture accelere weeee";
        }

        public override string Demarrer()
        {
            return $"Cette Voiture demarrare a tel degree";
        }
    }
}