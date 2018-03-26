using LibS3.C6;

namespace LibS3.C7
{
    public class CompteEpargneC7 : CompteC6
    {
        private double _tauxinteret;

        public double Tauxinteret
        {
            get { return _tauxinteret; }
            set { _tauxinteret = value; }
        }

        public CompteEpargneC7(ClientC6 clientC6, double _tauxinteret) : base(clientC6)
        {
            this._tauxinteret = _tauxinteret;
        }


        public void AddInterest()
        {
           Solde *= (1 + Tauxinteret); //changed to protected set not the whole thing
        }
    }
}
