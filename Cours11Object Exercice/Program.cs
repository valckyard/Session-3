using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours11Object_Exercice
{
    class Program
    {
        private static Random _rand = new Random();



        /// <summary>
        /// Random Name Gen
        /// </summary>
        /// <returns></returns>

        
        public static string RandName()
        {
            int lenght = _rand.Next(4, 15);

            Random r = new Random();
            string[] cons = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] voy = { "a", "e", "i", "o", "u", "ae", "y" };
            string nameGend = "";

            int counter = 0;
            while (counter < lenght)
            {
                nameGend += cons[_rand.Next(0, cons.Length)];
                counter++;
                nameGend += voy[_rand.Next(0, voy.Length)];
                counter++;
            }

            return char.ToUpper(nameGend[0]) + nameGend.Substring(1);
        }

      /// <summary>
      /// Random Adult/almost gen
      /// </summary>
      /// <returns></returns>

        public static  DateTime RandTime()
        {
            var year = _rand.Next(1950, 2019);

            while (year >= DateTime.Now.Year - 17)
            {
                year = _rand.Next(1990, 2019);
            }

            var month = _rand.Next(1, 13);
            var day = _rand.Next(1, 32);

            try
            {
                var date = new DateTime(year, month, day);
                return date;
            }
            catch (Exception)
            {
                return RandTime();
            }
        }

        /// <summary>
        /// return a Hire Date from 1990 if hesold enough
        /// </summary>
        /// <param name="naiss"></param>
        /// <returns></returns>
        public static DateTime RandTimeEmb(DateTime naiss)
        {
            var year = _rand.Next(1980, 2019);

            while (year >= naiss.Year + 17) 
            {
                year = _rand.Next(1990, 2019);
            }

            var month = _rand.Next(1, 13);
            var day = _rand.Next(1, 32);

            try
            {
                var date = new DateTime(year,month,day);
                return date;
            }
            catch (Exception)
            {
             return  RandTimeEmb(naiss);
            }
        }

        /// <summary>
        /// Random pourcentages
        /// </summary>
        /// <returns></returns>

        public static double RandDouble()
        {
            return ((double)_rand.Next(1, 10)/10 + ((double)_rand.Next(0, 10)/100 ))/100;
        }


        /// <summary>
        /// Generator Block
        /// </summary>
        /// <returns></returns>

        public static Ouvrier OuvrierGen()
        {
            string name = RandName() , surname = RandName();
            DateTime naiss = RandTime();
            DateTime embTime = RandTimeEmb(naiss);

            return new Ouvrier(name,surname,naiss,embTime);

        }

        public static Cadre CadreGen()
        {
           return new Cadre(RandName(), RandName(), RandTime(), _rand.Next(1, 5));
        }

        public static Patron PatronGen()
        {
            return new Patron(RandName(), RandName(), RandTime(), RandDouble());
        }


        /// <summary>
        /// Main App
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //Generate Employee
            var empList = new List<Employe>();

            for (int i = 0; i <= 1; i++)
            {
                empList.Add(PatronGen());
                for (int j = 0; j < 2; j++)
                {
                    empList.Add(CadreGen());
                    for (int k = 0; k < 5; k++)
                    {
                        empList.Add(OuvrierGen());
                    }
                }
            }

            //set a common Business Revenue
            Patron.AddToChiffreAffaire(12456121.34);

            // show all employees
            foreach (var employe in empList)
            {
                Console.WriteLine(employe.ToString());
            }
        }
    }
}
