namespace LibS3.C6
{
    public class Client
    {
        private static int _idusers;

        //Attrib//Props
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nom;
        public string Nom
        {
          get { return _nom; }
          set{ _nom = value; }
         }

        private string _prenom;
        public string Prenom
        {
            get { return _prenom;}
            set { _prenom = value; }
        }

        private long _tel;
        public long Tel
        {
            get { return _tel;}
            set { _tel = value; }
        }

        //constructeur Simple
        public Client(int _id, string _nom, string _prenom, long _tel)
        {
            this._id = _id; 
            this._nom = _nom;
            this._prenom = _prenom;
            this._tel = _tel;
        }

        //Constructeur Dynamique de NoCompte
        public Client(string _nom, string _prenom, long _tel)
        {
            this._id = _idusers;
            this._nom = _nom;
            this._prenom = _prenom;
            this._tel = _tel;
            ++_idusers;
        }



    }
}
