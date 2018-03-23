using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace C6Lib
{
    public class Client
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nom;
        public string Nom
        {
          get { return _nom; }
          set{ _nom = value; }
         }

        private string _prenom;
        public string Prenom
        {
            get { return _prenom;}
            set { _prenom = value; }
        }

        private int _tel;

        public int Tel
        {
            get { return _tel;}
            set { _tel = value; }
        }

        public Client(int _id, string _nom, string _prenom, int _tel)
        {
            this._id = _id;
            this._nom = _nom;
            this._prenom = _prenom;
            this._tel = _tel;
        }
        public Client(string _nom, string _prenom, int _tel)
        {
            this._id = 0;
            this._nom = _nom;
            this._prenom = _prenom;
            this._tel = _tel;
        }

        public void Afficher()
        {
            Console.WriteLine($"ID        : {Id}\t" +
                              $"Nom       : {Nom}\t" +
                              $"Prenom    : {Prenom}\t" +
                              $"Telephone : {Tel}");
        }


    }
}
