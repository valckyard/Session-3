using C6Lib;

namespace Cours4Object_Exercice
{
    class Compte
    {
        private static int _compteId = 0;

        private int _compteClientID;
        public int CompteId
        {
            get { return _compteClientID; }
            private set { _compteClientID = value; }
        }   

        private double _solde;

        public double Solde
        {
            get { return _solde; }
           private set { _solde = value; }
        }

        private Client _client;

        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }

        public Compte(Client _client)
        {
            this._client = _client;
            _solde = 0;
            _compteClientID = _compteId;
            ++_compteId;
        }

        public void Crediter(double montant)
        {
            Solde += montant;
        }

        public void Crediter(Compte transfer, double montant)
        {
            if ((Solde - montant) >= 0)
            {
                Solde -= montant;
                transfer.Crediter(montant);
            }
        }
        public void Debiter(double montant)
        {
            if ((Solde - montant) >= 0)
            {
                Solde -= montant;
            }
            
        }

        public void Debiter(Compte transfer, double montant)
        {
            if ((transfer.Solde - montant) >= 0)
            {
                transfer.Debiter(montant);
                Solde += montant;
            }
        }
    }
}
