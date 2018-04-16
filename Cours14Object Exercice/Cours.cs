using System.Collections.Generic;
using System.Linq;

namespace Cours14Object_Exercice
{
    public class Cours
    {
        private int _numeroCours { get; set; }

        //besoin de ces valeurs pour le bulletin ~ tbh i could do a better encap job
        //if i had more time ... but meh
        public string Titre { get; private set; }
        public Dictionary<string, double> Notes { get; private set; }

        public Cours()
        {
        }

        public Cours(int numeroCours, string titre)
        {
            _numeroCours = numeroCours;
            Titre = titre;
            Notes = new Dictionary<string, double>();
        }


        /// <summary>
        /// Ajout et modification des notes
        /// </summary>
        /// <param name="eleve"></param>
        /// <param name="note"></param>
        /// <returns></returns>
        public string AjouterNote(Eleve eleve, double note)
        {
            //new
            if (!this.Notes.ContainsKey(eleve.CodePermanent))
            {
                this.Notes.Add(eleve.CodePermanent, note);
                return $"La note de a ete ajoutee!";
            }
            //existing
            else
            {
                foreach (string n in Notes.Keys.ToList())
                {
                    if (eleve.CodePermanent == n)
                    {
                        this.Notes[n] = note;
                    }
                }

                return $"La note de a ete Modifie!";
            }
        }

        /// <summary>
        /// retoune une liste contenant le code permanent et la note
        /// </summary>
        /// <returns></returns>
        public List<string> RapportNotesClasse()
        {
            var strList = new List<string>();
            strList.Add($"\nNotes pour le cours No : {_numeroCours} : {Titre}");
            strList.Add($"-------------------------------------------------\n");
            foreach (var notes in Notes)
            {
                strList.Add($"Code Permanent : {notes.Key}  Note : {notes.Value:N2}%");
            }
            strList.Add($"\n-------------------------------------------------");

            return strList;
        }


        /// <summary>
        /// override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Numero Cours : {_numeroCours}\n" +
                   $"Titre        : {Titre}\n";
        }
    }
}