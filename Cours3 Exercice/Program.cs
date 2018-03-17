using System;

namespace Cours3_Exercice
{
    public partial class Program
    {

        private static void Main(string[] args)
        {
            Choice();
        }





        private static void Choice()
        {
            Console.Write("Choose : 1 - LivreC3 \n" +
                          "         2 - RectangleC3\n" +
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
                    Livreinit();
                    break;
                case 2:
                    RectangleInit();
                    break;
            }

         
            Console.Clear();
            Choice();
        }
    }
}
