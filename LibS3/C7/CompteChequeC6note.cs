using LibS3.C6;

namespace LibS3.C7
{
    public class CompteChequeC7 : CompteC6
    {
        private int _nombreOperations;

        public int NombreOperations
        {
            get { return _nombreOperations; }
            set { _nombreOperations = value; }
        }

        public CompteChequeC7(ClientC6 clientC6, int _nombreOperations) : base(clientC6) //utilise le Client seter de base CompteC6
        {
            this._nombreOperations = _nombreOperations;
        }
    }
}
