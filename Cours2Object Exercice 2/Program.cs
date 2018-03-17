using System;
using LibS3.C2;

namespace Cours2Object_Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var monrect = new RectangleC2(5, 12);

            monrect.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();

            var monrect1 = new RectangleC2(5, 5);

            monrect1.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();

            var monrect2 = new RectangleC2(12, 2);

            monrect2.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();

            var monrect3 = new RectangleC2(8, 8);

            monrect3.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();

            var monrect4 = new RectangleC2(2, 2);

            monrect4.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
