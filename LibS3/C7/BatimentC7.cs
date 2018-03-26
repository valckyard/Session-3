using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibS3.C7
{
   public class BatimentC7
   {
       private string _adresse;

        public string Adresse { get => _adresse; protected set => _adresse = value; }

        public BatimentC7(string _adresse)
        {
           this._adresse = _adresse;
        }

        public BatimentC7()
        {
        }

       public override string ToString()
       {
           return $"Adresse : {Adresse}";
       }
    }
}
