namespace LibS3.C3
{
    public class RectangleC3
    {
        private int _longeur;
        private int _largeur;

        public int Longeur
        {
            get { return _longeur;}
            set { _longeur = value; }
        }

        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }

        public RectangleC3(int longeur, int largeur)
        {
            _longeur = longeur;
            _largeur = largeur;
        }

        public int Perimetre()
        {
            int perimetre = (Longeur * 2) + (Largeur * 2);
            return perimetre;
        }

        public int Aire()
        {
            int aire = Longeur * Largeur;
            return aire;
        }

        public string EstCarre()
        {
            if (Longeur == Largeur)
            {
                return "Est un Carre !";
            }
            else
            {
                return "N'est pas un Carre !";
            }
        }
    }
}
