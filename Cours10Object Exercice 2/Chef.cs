using System;

namespace Cours10Object_Exercice_2
{
    public class Chef : Employe
    {
        protected string _service { get; set; }

        public Chef(string nom, string prenom, DateTime dateNaissance, double salaire, string service) : base(nom, prenom, dateNaissance, salaire)
        {
            _service = service;
        }

        public Chef()
        {
        }

        public override string Afficher()
        {
            return base.Afficher() + $"Service           : {_service}\n";
        }
    }
}