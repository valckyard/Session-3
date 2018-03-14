using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours2Object_Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var monrect = new Rectangle(5, 12);

            monrect.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();

            var monrect1 = new Rectangle(5, 5);

            monrect1.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();

            var monrect2 = new Rectangle(12, 2);

            monrect2.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();

            var monrect3 = new Rectangle(8, 8);

            monrect3.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();

            var monrect4 = new Rectangle(2, 2);

            monrect4.AfficherRectangle();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
