using System;
using LibS3.C3;

namespace Cours3Object_Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Choice();
           
        }
        private static void Choice()
        {
            Console.Write("Choose : 1 - Employe \n" +
                          "         2 - Cercle\n" +
                          "         Choice : ");

            int x;
            while (int.TryParse(Console.ReadLine(), out x) == false)
            {

            }

            if (x < 1 & x > 2)
            {
                Choice();
            }
            Console.Clear();
            switch (x)
            {
                case 1:
                    EmployeInit();
                    break;
                case 2:
                    CircleInit();
                    break;
            }

            Console.ReadLine();
            Console.Clear();
            Choice();
        }

        private static void EmployeInit()
        {
            var emp = new EmployeC3(32132132, "pablo", "escobar", new DateTime(1980, 09, 28), new DateTime(1999, 01, 01), 11.75);
            emp.AfficherEmploye();
        }

        private static void CircleInit()
        {
            float rayon;
            float pX;
            float pY;

            //rayon
            Console.Write("Rayon du Cercle ? : ");
            while (float.TryParse(Console.ReadLine(), out rayon) == false) { }

            //le point
            Console.Write("\nLe point a veifier l'appartenance\n");
            Console.Write("X ? : ");
            while (float.TryParse(Console.ReadLine(), out pX) == false) { }
            Console.Write("Y ? : ");
            while (float.TryParse(Console.ReadLine(), out pY) == false) { }

            //creation et process
            var point = new PointC3(pX, pY);
            var cercle = new CercleC3(rayon);
            cercle.Afficher(point);
        }
    }
}
