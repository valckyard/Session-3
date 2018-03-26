namespace LibS3.C6
{
    public class CompteC6
    {
        public static int CompteNumIdIncrement { get; private set; }
        //jai fait les attributs old school pour le besoin de l exercise omis Comptenum


        //Attrib/Props
        private int _compteClientId;
        public int CompteClientId
        {
            get { return _compteClientId; }
            private set { _compteClientId = value; }
        }   

        private double _solde;
        public double Solde
        {
            get { return _solde; }
            protected set { _solde = value; }
        }

        private ClientC6 _clientC6;
        public ClientC6 ClientC6
        {
            get { return _clientC6; }
            set { _clientC6 = value; }
        }


        //constructor
        public CompteC6(ClientC6 clientC6)
        {
            this._clientC6 = clientC6;
            _solde = 0;
            _compteClientId = CompteNumIdIncrement;
            CompteNumIdIncrement++;
        }

        //Crediter // entree d'argent simple
        public void Crediter(double montant)
        {
            _solde += montant;
        }

        //Crediter d un autre compteC6 et enlever l'argent
        public void Crediter(CompteC6 transfer, double montant)
        {
            if ((transfer.Solde - montant) >= 0)  //nofunds
            {
                Crediter(montant);
                transfer.Debiter(montant);
            }
        }

        //debiter compteC6 // sortie d'argent simple
        public void Debiter(double montant) //no funds
        {
            if ((Solde - montant) >= 0)
            {
                Solde -= montant;
            }
            
        }

        //Debiter and transferer a un autre compteC6
        public void Debiter(CompteC6 transfer, double montant)
        {
            if ((Solde - montant) >= 0) //no funds
            {
                Debiter(montant);
                transfer.Crediter(montant);
            }
        }
    }
}
