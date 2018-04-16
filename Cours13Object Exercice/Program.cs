using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours13Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            var joe = new Eleve();
            Console.WriteLine(joe.ToString());
            IntCatch();
            DateCatch();
        }


        public static bool IntCatch()
        {
            Console.WriteLine("entrez un int");
            try
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine($"Success : Integer Number is {x}");
                return true;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Failure : Number is not a Integer try again !");
                return IntCatch();
            }
        }

        public static bool DateCatch()
        {
            Console.WriteLine("entrez une Date (yyyy-mm--dd)");
            try
            {
                DateTime x = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"Success : Date is {x.ToShortDateString()}");
                return true;
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Failure : Date was not a valid : try again !");
                return DateCatch();
            }
        }

     

    }
}
