using LibS3.C1;

namespace LibS3.C4
{
   public class CompteBancaireC4
    {
        public string Titulaire { get; set; }
        public double Solde { get; set; }
        public DevisesMonaitairesC1 Devise { get; set; }
        public int CompteBancaireNumber { get; set; }
        private static int _numeroCompteBancaireGlobal = 1;

        public CompteBancaireC4(string titulaire, double solde, DevisesMonaitairesC1 devise)
        {
            Titulaire = titulaire;
            Solde = solde;
            Devise = devise;
            CompteBancaireNumber = _numeroCompteBancaireGlobal;
            _numeroCompteBancaireGlobal++;
        }

        public void Crediter(double montant)
        {
            Solde += montant;
        }

        public void Debiter(double montant)
        {
            Solde -= montant;
        }

        public string AfficherCompte()
        {
            return _numeroCompteBancaireGlobal.ToString();
        }

        public double SoldeConverter(DevisesMonaitairesC1 converttothisdevise)
        {
            double value = (Solde * Devise.Taux) * converttothisdevise.Taux;
            return value;
        }

    }
}
