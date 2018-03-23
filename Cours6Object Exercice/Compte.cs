using System;

namespace Cours6Object_Exercice
{
    class Compte
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
           private set { _solde = value; }
        }

        private Client _client;
        public Client Client
        {
            get { return _client; }
            set { _client = value; }
        }


        //constructor
        public Compte(Client _client)
        {
            this._client = _client;
            _solde = 0;
            _compteClientId = CompteNumIdIncrement;
            CompteNumIdIncrement++;
        }

        //Crediter // entree d'argent simple
        public void Crediter(double montant)
        {
            _solde += montant;
        }

        //Crediter d un autre compte et enlever l'argent
        public void Crediter(Compte transfer, double montant)
        {
            if ((transfer.Solde - montant) >= 0)  //nofunds
            {
                Crediter(montant);
                transfer.Debiter(montant);
            }
        }

        //debiter compte // sortie d'argent simple
        public void Debiter(double montant) //no funds
        {
            if ((Solde - montant) >= 0)
            {
                Solde -= montant;
            }
            
        }

        //Debiter and transferer a un autre compte
        public void Debiter(Compte transfer, double montant)
        {
            if ((Solde - montant) >= 0) //no funds
            {
                Debiter(montant);
                transfer.Crediter(montant);
            }
        }
    }
}
