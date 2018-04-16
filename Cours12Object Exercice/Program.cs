using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Cours12Object_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            //streamwriter/reader
            var myWriter = new StreamWriter(@"E:\Projects\2 - C# Building\School Projects\Session 3\Cours12Object Exercice\bin\Debug\save.txt");
            var myReader = new StreamReader(@"E:\Projects\2 - C# Building\School Projects\Session 3\Cours12Object Exercice\bin\Debug\yay.txt");

           // string[] readString;

            // OR  with stringbuilder//

            while (myReader.Peek() >= 0)
            {
                var line = myReader.ReadLine().Split(new Char[] { ' ' },2);
                line = line[0].Split(new char[]{'a'}, 2);

                myWriter.WriteLine(line[0] ,true);                
            }


            //var stringBuild = new StringBuilder();
            //stringBuild.Append(myReader.ReadToEnd());
            //myWriter.Write(stringBuild);
            myWriter.Close();




        }


    }
}

