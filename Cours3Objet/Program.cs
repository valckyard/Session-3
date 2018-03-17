using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours3Objet
{
    public class dummy
    {
        // not b4 4.0 framework
        public int Suif { get; private set; }
        private int _age { get; set; }

        public dummy(int suif, int age)
        {
            Suif = suif;
            _age = age;
        }

        //accessor changer int for aggage
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }

    //old methods
    public class dummy2
    {
        private int _suiffage;
        private int _aggage;

        public dummy2(int suiffage, int sggage)
        {
            _suiffage = suiffage;
            _aggage = sggage;
        }

        public int Suiffage
        {
            get { return _suiffage; }
            set { _suiffage = value; }
        }

        public int Age
        {
            get { return _suiffage; }
            set { _aggage = value; }
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            var test = new dummy(12,12);
            // peut get mais pas set;
         //   test.Suif = 22;

            /* ENCAPSULATION
             - Visibility of the class outside in the solution/program
             
            3 Types
                -public
                    -accessible outside the class or as a library
                    
                -private
                    -accessible default and used in the class
                    -per convention everthing is private
                    -changed to public for use outside only when needed

                -protected
                    -inherited stuff
                    -almost identic to private 
                    -unless it unherit from some other class

                -internal
                -virtual
                -abstract
                -override
            
                Property
                    -get
                    -set

                

            */
        }
    }
}
