using System;

namespace LibS3.C3
{
   public class CercleC3
    {

        public PointC3 Centre { get; set; }
        public float Rayon { get; set; }

        public CercleC3(float rayon)
        {
            Rayon = rayon;
            Centre = new PointC3(rayon,rayon);
        }

        public float GetPerimetre()
        {
            return (float) ((Rayon * 2) * Math.PI);
        }

        public float GetSurface()
        {
            return (float) (Math.PI * (Math.Pow(Rayon,2)));
        }

        public bool Appartient(PointC3 point)
        {
            if( (float) Math.Sqrt(Math.Pow(point.X - Centre.X, 2) + Math.Pow(point.Y - Centre.Y, 2)) <= Rayon) return true;
            else return false;
            
        }

        public void Afficher()
        {
            Console.WriteLine($"Cercle(X: {Centre.X} ,Y: {Centre.Y} ,R: {Rayon}).");
        }

        public void Afficher(PointC3 point)
        {
            Console.WriteLine($"\nRayon              : {Rayon}" +
                              $"\nDiametre           : {Rayon*2}" +
                              $"\nPerimetre          : {GetPerimetre()}" +
                              $"\nSurface            : {GetSurface()}" +
                              $"\nPoint Externe      : {point.Afficher()}" +
                              $"\nPoint Appartient ? : {Appartient(point)}");
        }
}
}
