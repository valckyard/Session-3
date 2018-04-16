namespace LibS3.C9.C9Corrige
{
    public class ArmureC9 : ObjetC9
    {
        public int Defense { get; set; }

        public ArmureC9()
        {
        }

        public ArmureC9(string nom, int defense) : base(nom)
        {
            Nom = nom;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"   ~Armure No_{base.Id}~\n" +
                   $"Nom   : {base.Nom}\n" +
                   $"Defense : {Defense}\n";
        }
    }
}
