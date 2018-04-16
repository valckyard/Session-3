namespace LibS3.C9.C9Corrige
{
    public class ArmeC9 : ObjetC9
    {
        public int Dommage { get; set; }

        public ArmeC9()
        {
        }

        public ArmeC9(string nom, int dommage) : base(nom)
        {
            Nom = nom;
            Dommage = dommage;
        }

        public override string ToString()
        {
            return $"   ~Arme No_{base.Id}~\n" +
                   $"Nom   : {base.Nom}\n" +
                   $"Dommage : {Dommage}\n";
        }

    }
}
