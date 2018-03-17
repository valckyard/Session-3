namespace LibS3.C1
{
    public class CompteBancaireC1
    {
        public string Titulaire { get; set; }
        public double Solde { get; set; }
        public DevisesMonaitairesC1 Devise { get; set; }

        public CompteBancaireC1(string titulaire, double solde, DevisesMonaitairesC1 devise)
        {
            Titulaire = titulaire;
            Solde = solde;
            Devise = devise;
        }

        public void Crediter(double montant)
        {
            Solde += montant;
        }

        public void Debiter(double montant)
        {
            Solde -= montant;
        }

		public double SoldeConverter(DevisesMonaitairesC1 converttothisdevise)
		{
			double value;
			value = (Solde * Devise.Taux) * converttothisdevise.Taux;
			return value;
		}

    }
}
