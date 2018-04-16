namespace Cours10Object_Exercice
{
    public class Camion : Vehicule
    {
        public Camion() { }
        public Camion(int annee, string modele, double prix) : base(annee, modele, prix)
        {

        }
        public override string Accelerer()
        {
            return $"Ce Camion accelere weeee";
        }

        public override string Demarrer()
        {
            return $"Ce camion demarrare a tel degree";
        }
    }
}
