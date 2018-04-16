using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cours13Object_Exercice
{
    public class Eleve
    {
        private string Nom { get; set; }
        private int Age { get; set; }
        private double Moyenne { get; set; }

        public Eleve(string nom, int age, double moyenne)
        {
            Nom = nom;
            Age = age;
            Moyenne = moyenne;
        }

        public Eleve()
        {
            Nom = GetName();
            Age = GetAge();
           Moyenne = GetNote();
        }


        private string GetName()
        {
            try
            {
                string x = Console.ReadLine();
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter Name Again" + e);
                return GetName();
            }
        }

        private int GetAge()
        {

            int x;

            try
            {
                Console.WriteLine("Age de L'Eleve ?");

                x = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                try
                {
                    if (x < 18 | x > 26)
                    {
                        throw new InvalidAgeExeption();
                    }
                }
                catch (InvalidAgeExeption e)
                {
                    Console.WriteLine(e);
                    return GetAge();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("format exp");
                return GetAge();
            }
            return x;
        }


        private int GetNote()
        {
            int x;
            try
            {
                Console.WriteLine("Moyenne de L'Eleve ?");
                x = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                try
                {
                    if (x < 0 | x > 20)
                    {
                        throw new InvalidNoteExeption();
                    }
                }
                catch (InvalidNoteExeption e)
                {
                    Console.WriteLine(e);
                    return GetNote();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("format exp");
                return GetNote();
            }
            return x;
        }


        public override string ToString()
        {
            return $"Nom {Nom}\n" +
                   $"Age {Age}\n" +
                   $"Moyenne {Moyenne}\n";
        }
    }



    public class InvalidAgeExeption : Exception
    {
        public InvalidAgeExeption() : base("Age must be Between 18 and 26")
        {
       
        }
    }
    public class InvalidNoteExeption : Exception
    {
        public InvalidNoteExeption() : base("Note Must be between 0 and 20")
        {

        }
    }
}
