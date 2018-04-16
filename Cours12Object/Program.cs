using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Cours12Object
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  system IO
             *
             *
             * Reader
             * 
             */

            //streamwriter/reader
            var myWriter = new StreamWriter(@"file");
            var myReader = new StreamReader(@"File");

            //1st method
            string text = System.IO.File.ReadAllText(@"the file");
            System.IO.File.WriteAllText(@"File", text);

            //2nd method
            string[] lines = System.IO.File.ReadAllLines(@"this file");

          

            foreach (var line in lines)
            {
                Console.WriteLine(line+$"\n");
                myWriter.WriteLine(line);
            }

            //3rd method
            string readString;
            var stringList = new List<string>();

            while ((readString  = myReader.ReadLine()) != null)
            {
                stringList.Add(readString);
                myWriter.WriteLine();
            }

            // OR  with stringbuilder//
            var stringBuild = new StringBuilder();
            while ((readString = myReader.ReadLine()) != null)
            {
                stringBuild.AppendLine(readString);
            }

            myWriter.Write(stringBuild);

        }

    }
}
