namespace LibS3.C3
{
    public class LivreC3
    {
        public string Titre { get; set; }
        public string NomAuteur { get; set; }
        public double Prix { get; set; }

        public LivreC3(string titre, string nomAuteur, double prix)
        {
            Titre = titre;
            NomAuteur = nomAuteur;
            Prix = prix;
        }
    }
}
