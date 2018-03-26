using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibS3.C7
{
   public class MaisonC7 : BatimentC7
   {
       private int _nbPieces;

        public int NbPieces { get => _nbPieces; set => _nbPieces = value; }

        public MaisonC7(int nbPieces,string Adresse ) : base(Adresse)
        {
            _nbPieces = nbPieces;
            base.Adresse = Adresse;
        }

       public override string ToString()
       {
           return $"Nb de pieces : {NbPieces}\nAdresse : {Adresse}";
       }
    }
}
