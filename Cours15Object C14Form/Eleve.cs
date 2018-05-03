using System;
using System.Collections.Generic;
using System.IO;

namespace Cours15Object_C14Form
{
    public abstract class Eleve
    {
        //besoin de cette valeur pour assignation notes au cours
        public string CodePermanent { get; protected set; }

        //Garder ces infos confidentielles
        protected string _nom { get;  set; }
        protected string _prenom { get;  set; }
        protected string _adresse { get; set; }
        protected DateTime _dateNaissance { get; set; }
        protected List<Cours> _coursBase { get; set; }

        public string GetNom() { return _nom; }
        public string GetPrenom() { return _prenom; }
        public string GetAdress() { return _adresse; }
        public string GetNaissance() { return _dateNaissance.ToShortDateString(); }
        public List<Cours> GetCours() { return _coursBase; }
        public abstract List<Cours> GetCoursOpt();

        public Eleve(string codePermanent, string nom, string prenom, string adresse, DateTime dateNaissance)
        {
            CodePermanent = codePermanent;
            _nom = nom;
            _prenom = prenom;
            _adresse = adresse;
            _dateNaissance = dateNaissance;
            _coursBase = new List<Cours>();
        }


        public Eleve()
        {
            _coursBase = new List<Cours>();
        }



        //Methode Assignation de cours
        public string AssignerCours(Cours cours)
        {
            if (this._coursBase.Count < 3 & !this._coursBase.Contains(cours))
            {
                this._coursBase.Add(cours);
                cours.AjouterNote(CodePermanent, 0);
                return $"Le cours a ete ajoute !";
            }
            else
            {
                return $"Vous ne pouvez pas ajouter de cours !";
            }
        }
      


        /// <summary>
        /// enlever un cours
        /// </summary>
        /// <param name="cours"></param>
        /// <returns></returns>
        public string EnleverCours(Cours cours)
        {
            if (_coursBase.Contains(cours))
            {
                _coursBase.Remove(cours);
                cours.EnleverNote(CodePermanent);
                return $"Le cours a ete enleve !";
            }
            else
            {
                return "Le cours n a pas pu etre enleve !";
            }
        }


        public abstract string AssignerCours(Cours cours, bool optionnel);
        public abstract string EnleverCours(Cours cours, bool optionnel);
        public abstract string LoadCours(Cours cours, bool optionnel);
        /// <summary>
        /// Creation des notes du bulletin de base
        /// </summary>
        /// <param name="stdNotes"></param>
        /// <returns></returns>
        public List<string> BulletinBase(out double stdNotes)
        {
            var noteList = new List<string>();

            stdNotes = 0;
            noteList.Add($"-----------------------------------------");
            noteList.Add($"Nom : {_prenom} {_nom}\n");

            //Ajout notes Regulieres
            foreach (var course in _coursBase)
            {
                noteList.Add($"Cours: {course.Titre}   \nNote: {course.Notes[CodePermanent]}%");
                stdNotes += course.Notes[CodePermanent];
            }

            return noteList;
        }

        public string LoadCours(Cours cours)
        {
            if (this._coursBase.Count < 3 & !this._coursBase.Contains(cours))
            {
                this._coursBase.Add(cours);
                return $"Le cours a ete ajoute !";
            }
            else
            {
                return $"Vous ne pouvez pas ajouter de cours !";
            }
        }

        /// <summary>
        /// Impression de Bullletin et retour des valeurs pour affichage
        /// </summary>
        /// <returns></returns>
        public virtual List<string> Bulletin()
        {
            var noteList = BulletinBase(out double stdNotes);

            //Calc Moyenne
            double moyenne = stdNotes / _coursBase.Count;
            noteList.Add($"\nMoyenne : {moyenne:N2}%\n");
            noteList.Add($"-----------------------------------------");

            //retourne pour affichage
            return noteList;
        }

        /// <summary>
        /// Impression en fichier du bulletin
        /// </summary>
        public virtual void ImprimerBulletin()
        {
            var noteList = this.Bulletin();
            //Ecrire Bulletin
            var myWriter = new StreamWriter($"{CodePermanent}.txt");
            foreach (var nt in noteList)
            {
                myWriter.WriteLine(nt);
            }
            myWriter.Close();
        }


        /// <summary>
        /// Affichage Etudiant
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string infos = $"Etudiant    : {CodePermanent}\n" +
                           $"Nom Complet : {_prenom} {_nom}\n" +
                           $"Adresse     : {_adresse}\n" +
                           $"Ne le       : {_dateNaissance}\n";

            switch (_coursBase.Count)
            {
                case 1:
                    infos += $"Cours1      : {_coursBase[0].Titre}\n";
                    break;
                case 2:
                    infos += $"Cours1      : {_coursBase[0].Titre}\n" +
                             $"Cours2      : {_coursBase[1].Titre}\n";
                    break;

                case 3:
                    infos += $"Cours1      : {_coursBase[0].Titre}\n" +
                             $"Cours2      : {_coursBase[1].Titre}\n" +
                             $"Cours3      : {_coursBase[2].Titre}\n";
                    break;
            }

            return infos;

        }
    }
}