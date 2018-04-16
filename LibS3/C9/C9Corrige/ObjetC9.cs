namespace LibS3.C9.C9Corrige
{
    public class ObjetC9
    {
        public int Id { get; protected set; }
        public static int CompteurId { protected get; set; }
        public string Nom { get; protected set; }

        public ObjetC9()
        {
        }

        public ObjetC9(string nom)
        {
            Nom = nom;
            Id = CompteurId;
            CompteurId++;
        }
    }
}
