namespace LibS3.C8
{

        public class Objet
        {
            //counter static for number of Objet
            private static int _objectidcounter;

            //prop of Objet
            private int _id;

            private string _nom;


            //accessors
            public string Nom
            {
                get { return _nom; }
               protected set { _nom = value; }
            }

            public int Id
            {
                get { return _id; }
                protected set { _id = value; }
            }

            //static accessor for count
            public static int Objectidcounter
            {
                get { return _objectidcounter; }
               protected set { _objectidcounter = value; }
            }

            //base constructor
            public Objet(string nom)
            {
                _nom = nom;
                _id = _objectidcounter;
                _objectidcounter++;
            }

            //empty one
            public Objet()
            {
            }
        }
    
}
