using System;
using System.Collections.Generic;
using System.IO;

namespace Cours15Object_C14Form
{
    public class EleveTempsPlein : Eleve
    {
        private List<Cours> _coursOptionnels { get; set; }

        //for save
        public override List<Cours> GetCoursOpt(){return _coursOptionnels;}


        public EleveTempsPlein()
        {
            _coursOptionnels = new List<Cours>();
        }



        public EleveTempsPlein(string codePermanent, string nom, string prenom, string adresse,
            DateTime dateNaissance) : base(codePermanent, nom, prenom, adresse, dateNaissance)
        {
            _coursOptionnels = new List<Cours>();
        }


        /// <summary>
        //Assigner les cours reg et optionnels d'une 2eime maniere
        /// </summary>
        /// <param name="cours"></param>
        /// <param name="optionnel"></param>
        /// <returns></returns>
        public override string AssignerCours(Cours cours, bool optionnel)
        {

            if (!optionnel)
            {
                
                return base.AssignerCours(cours);
            }
            else
            {
                if (base._coursBase.Count == 3)
                {
                    if (_coursOptionnels.Count < 2 & !base._coursBase.Contains(cours) &
                        !this._coursOptionnels.Contains(cours))
                    {
                        this._coursOptionnels.Add(cours);
                        cours.AjouterNote(CodePermanent, 0);
                        return $"Le cours optionnel a ete ajoute !";
                    }
                    else
                    {
                        return $"Vous ne pouvez pas ajouter ce cours optionnels !";
                    }
                }
                else return $"Le cours n'a pas pu etre ajoute, vous n'avez pas tout vos cours reguliers !";
            }
        }
        public override string LoadCours(Cours cours, bool optionnel)
        {

            if (!optionnel)
            {
                return base.LoadCours(cours);
            }
            else
            {
                if (base._coursBase.Count == 3)
                {
                    if (_coursOptionnels.Count < 2 & !base._coursBase.Contains(cours) &
                        !this._coursOptionnels.Contains(cours))
                    {
                        this._coursOptionnels.Add(cours);
                        return $"Le cours optionnel a ete ajoute !";
                    }
                    else
                    {
                        return $"Vous ne pouvez pas ajouter ce cours optionnels !";
                    }
                }
                else return $"Le cours n'a pas pu etre ajoute, vous n'avez pas tout vos cours reguliers !";
            }
        }


        /// <summary>
        /// Remove a Class
        /// </summary>
        /// <param name="cours"></param>
        /// <param name="optionnel"></param>
        /// <returns></returns>
        public override string EnleverCours(Cours cours, bool optionnel)
        {
            if (!optionnel)
            {
                if (this._coursOptionnels.Count == 0)
                {
                    return base.EnleverCours(cours);
                }
                else
                {
                    return "Il reste des cours Optionnels !";
                }
            }
            else
            {
                if (this._coursOptionnels.Contains(cours))
                {
                    this._coursOptionnels.Remove(cours);
                    return $"Le cours optionnel a ete enleve !";
                }
                else
                {
                    return "Le cours optionnel n a pas pu etre enleve !";
                }
            }
        }



        /// <summary>
        /// Override pour le bulletin des gens etant a temps pleins\
        /// avoir le temps j utiliserais ma base me retourner la liste et continuer ici
        /// </summary>
        /// <returns></returns>
        public override List<string> Bulletin()
        {
            var noteList = base.BulletinBase(out double stdNotes);

            //Ajout des notes de cours optionnels
            foreach (var course in _coursOptionnels)
            {
                noteList.Add($"CoursOpt: {course.Titre}     \nNote: {course.Notes[CodePermanent]}%");
                stdNotes += course.Notes[CodePermanent];
            }

            //Calcul moyenne
            double moyenne = stdNotes / (_coursBase.Count + _coursOptionnels.Count);
            noteList.Add($"\nMoyenne : {moyenne:N2}%\n");
            noteList.Add($"-----------------------------------------");

            //retourner pour l'affichage
            return noteList;
        }


        /// <summary>
        /// Imprimer le bulletin en fichier
        /// </summary>
        public override void ImprimerBulletin()
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
        /// not needed but for the heck of it
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            switch (_coursOptionnels.Count)
            {
                case 1:
                    return base.ToString() + $"CoursOpt1 : {_coursOptionnels[0].Titre}\n";
                case 2:
                    return base.ToString() + $"CoursOpt1 : {_coursOptionnels[0].Titre}\n" +
                                             $"CoursOpt2 : {_coursOptionnels[1].Titre}\n";
                default:
                    return base.ToString();
            }
        }
    }
}