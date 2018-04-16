namespace Cours10Object_Exercice
{
    public abstract class Vehicule
    {
        protected static int _matriculeCounter = 12000;
        


        protected int _matricule { get; set; }
        protected int _annee { get; set; }
        protected string _modele { get; set; }
        protected double _prix { get; set; }

        protected Vehicule()
        {
        }

        protected Vehicule(int annee, string modele, double prix)
        {
            _matricule = _matriculeCounter;
            _matriculeCounter++;
            _annee = annee;
            _modele = modele;
            _prix = prix;
        }

        public abstract string Demarrer();

        public abstract string Accelerer();

        public override string ToString()
        {
            return $"Vehicule No_{_matricule}\n" +
                   $"_____________________________\n" +
                   $"_annee     : {_annee}\n" +
                   $"_modele    : {_modele}\n" +
                   $"_prix      : {_prix:C2}\n";
        }
    }
}
