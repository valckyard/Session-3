using System;

namespace LibS3.C3
{
    public class PointC3
    {
        public float X { get; set; }
        public float Y { get; set; }

        public PointC3(float x, float y)
        {
            X = x;
            Y = y;
        }

        public string Afficher()
        {
            return $"Point({X:N4} ,{Y:N4}).";
        }
    }
}
