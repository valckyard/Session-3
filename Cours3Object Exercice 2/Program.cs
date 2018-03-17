using System;
using LibS3;
using LibS3.C3;

namespace Cours3Object_Exercice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new EmployeC3(32132132,"pablo","escobar",new DateTime(1980,09,28),new DateTime(1999,01,01),11.75);

            emp.AfficherEmploye();
        }
    }
}
