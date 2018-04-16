using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Cours13Object
{
    public class ExeptChif : Exception
    {
        public ExeptChif(string message)
            : base("Erreur de chiffre:" + message)
        { }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Calc("12.14", 1115.1);

            Console.WriteLine();
            Console.WriteLine();

            Calc("12", 1115.1);

            Console.WriteLine();
            Console.WriteLine();


            Calc("allo", 1115);

            Console.WriteLine();
            Console.WriteLine();


            Calc(12, 111);

            Console.WriteLine();
            Console.WriteLine();

            Calc("1200", 333);
            /*
             *try catch
             *
             *
             *
             */

        }

        public static bool Calc<T,U>(T nb1, U nb2)
        {
            try
            {
                int x = int.Parse(nb1.ToString());
                int y = int.Parse(nb2.ToString());
                if (x < y)
                {
                    Console.WriteLine("pas bon 1 bas haut que 2");
                    return false;

                }
                else
                {
                    Console.Write(x-y);
                    return true;
                }
            }
            catch (FormatException e)
            {
                if (nb1 is string)
                {
                    Console.WriteLine("1-etait un string");
                    try
                    {
                       int x = int.Parse(nb1.ToString());
                        Console.WriteLine("     Conversion test success: int");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine("      Conversion test failure: not a int");
                    }
                }
                else if (nb1 is int)
                {
                    Console.WriteLine("1-etait un int");
                }
                else
                {
                    Console.WriteLine("1-N'est pas un int ou un string");
                }

                if (nb2 is string)
                {
                    Console.WriteLine("2-la valeur 2 etait une string et/ou une string de nombre non int");
                }
                else if(nb2 is int)
                {
                    Console.WriteLine("2-etait un int");
                }
                else
                {
                    Console.WriteLine("2-N'est pas un int ou un string");
                }

                return false;
            }
        }
    }
}
