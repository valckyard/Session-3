using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Cours15Object_C14Form
{
    public partial class AppEx : Form
    {
        private static List<Cours> _crs = new List<Cours>();
        private static List<Eleve> _elv = new List<Eleve>();

        public AppEx()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Create Classes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreeCours_Click(object sender, EventArgs e)
        {
            try
            {
                bool exist = false;

                if (_crs.Count > 0)
                {
                    foreach (var course in _crs)
                    {
                        if (course.NumeroCours.ToString() == tbCreeCoursNo.Text)
                        {
                            exist = true;
                        }
                    }
                }

                if (exist)
                {
                    lbcCreate.Text = "Already Exist !";
                }
                else
                {
                    _crs.Add(new Cours(int.Parse(tbCreeCoursNo.Text), tbCreeCoursNom.Text));
                    lbcCreate.Text = $"Success";
                    tbCreeCoursNo.Text = null;
                    tbCreeCoursNom.Text = null;
                }
            }
            catch (Exception exception)
            {
                lbcCreate.Text = "INVALID";
            }
        }

        private void blistcours_Click(object sender, EventArgs e)
        {
            try
            {
                ListCours.Items.Clear();
                ListCours.BeginUpdate();
                if (_crs.Count > 0)
                {
                    foreach (var course in _crs)
                    {
                        ListCours.Items.Add($"No: {course.NumeroCours} Nom : {course.Titre}");
                    }
                }

                ListCours.EndUpdate();
            }
            catch (Exception exception)
            {
            }
        }






        /// <summary>
        /// Create Students
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCreateElv_Click(object sender, EventArgs e)
        {
            try
            {
                bool exist = false;
                if (_elv.Count > 0)
                {
                    foreach (var eleve in _elv)
                    {
                        if (eleve.CodePermanent == tbCreeElvCP.Text)
                        {
                            exist = true;
                        }
                    }
                }

                if (chbCreeElvTP.Checked & !exist)
                {
                    _elv.Add(new EleveTempsPartiel(tbCreeElvCP.Text, tbCreeElvNom.Text, tbCreeElvPrenom.Text,
                        tbCreeElvAdresse.Text,
                        dtCreeElvDNaiss.MinDate));
                    lbCreeElv.Text = "Success";
                }
                else if (!chbCreeElvTP.Checked & !exist)
                {
                    _elv.Add(new EleveTempsPlein(tbCreeElvCP.Text, tbCreeElvNom.Text, tbCreeElvPrenom.Text,
                        tbCreeElvAdresse.Text,
                        dtCreeElvDNaiss.MinDate));
                    lbCreeElv.Text = "Success";
                }
                else
                {
                    lbCreeElv.Text = "Eleve Exist Already";
                }

                tbCreeElvCP.Text = null;
                tbCreeElvNom.Text = null;
                tbCreeElvPrenom.Text = null;
                tbCreeElvAdresse.Text = null;
            }
            catch (Exception exception)
            {
                lbCreeElv.Text = "INVALID";
            }
        }

        private void blistElv_Click(object sender, EventArgs e)
        {
            try
            {
                listElv.Items.Clear();
                listElv.BeginUpdate();
                if (_elv.Count > 0)
                {
                    foreach (var eleve in _elv)
                    {
                        listElv.Items.Add($"CodePermanant: {eleve.CodePermanent}");
                    }
                }

                listElv.EndUpdate();
            }
            catch (Exception exception)
            {
            }
        }



        /// <summary>
        /// Add Class to Student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAddClass_Click(object sender, EventArgs e)
        {
            try
            {
                if (_elv.Count > 0 & _crs.Count > 0)
                {
                    Cours toAdd = null;

                    foreach (var course in _crs)
                    {
                        if (course.Titre == cbElvClassAddNC.Text)
                        {
                            toAdd = course;
                            break;
                        }
                    }

                    bool exist = false;
                    if (toAdd != null)
                    {
                        foreach (var eleve in _elv)
                        {
                            if (eleve.CodePermanent == cbElvClassAddCP.Text)
                            {
                                if (eleve.GetType() == typeof(EleveTempsPartiel))
                                {
                                    lbElvClassAdd.Text = eleve.AssignerCours(toAdd);
                                    exist = true;
                                    break;
                                }

                                if (eleve.GetType() == typeof(EleveTempsPlein))
                                {
                                    lbElvClassAdd.Text = eleve.AssignerCours(toAdd, chbElvClassAddOPT.Checked);
                                    exist = true;
                                    break;
                                }
                            }
                        }

                        if (!exist)
                        {
                            lbElvClassAdd.Text = "Eleve INVALID";
                        }
                    }
                    else
                    {
                        lbElvClassAdd.Text = "Cours INVALID";
                    }
                }

                cbElvClassAddNC.Text = null;
            }
            catch (Exception exception)
            {
            }
        }

        private void bEnlvCl_Click(object sender, EventArgs e)
        {
            try
            {
                var NC = cbElvClassRmvNC.Text.Split(' ');

                if (_elv.Count > 0 & _crs.Count > 0)
                {
                    Cours toRmv = null;

                    foreach (var course in _crs)
                    {
                        if (course.Titre == NC[0])
                        {
                            toRmv = course;
                            break;
                        }
                    }

                    bool exist = false;
                    if (toRmv != null)
                    {
                        foreach (var eleve in _elv)
                        {
                            if (eleve.CodePermanent == cbElvClassRmvCP.Text)
                            {
                                if (eleve.GetType() == typeof(EleveTempsPartiel))
                                {
                                    lbElvClassRmv.Text = eleve.EnleverCours(toRmv);
                                    exist = true;
                                    break;
                                }

                             bool state =  chbElvClassRmvOPT.Checked;

                                if (eleve.GetType() == typeof(EleveTempsPlein))
                                {
                                    lbElvClassRmv.Text = eleve.EnleverCours(toRmv, state);
                                    exist = true;
                                    break;
                                }
                            }
                        }

                        if (!exist)
                        {
                            lbElvClassRmv.Text = "Eleve INVALID";
                        }
                    }
                    else
                    {
                        lbElvClassRmv.Text = "Cours INVALID";
                    }
                }

                cbElvClassRmvNC.Text = null;
            }
            catch (Exception exception)
            {
            }
        }

        private void bAjModSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Cours selectedCours = null;

                if (_elv.Count > 0 & _crs.Count > 0)
                {
                    foreach (var course in _crs)
                    {
                        if (course.Titre == cbAjModNoteNC.Text)
                        {
                            selectedCours = course;
                            break;
                        }
                    }

                    bool exist = false;
                    if (selectedCours != null)
                    {
                        foreach (var eleve in _elv)
                        {
                            if (eleve.CodePermanent == cbAjModNoteCP.Text)
                            {
                                lbAjModNoteAction.Text =
                                    selectedCours.AjouterNote(eleve.CodePermanent, double.Parse(tbAjModNoteNote.Text));
                                exist = true;
                            }
                        }
                    }

                    if (!exist)
                    {
                        lbAjModNoteAction.Text = "Eleve INVALID";
                    }
                }
                else
                {
                    lbAjModNoteAction.Text = "Cours INVALID";
                }



                listRapportCours.Items.Clear();
                listRapportCours.BeginUpdate();
                var rapportCours = selectedCours.RapportNotesClasse();
                if (rapportCours.Count > 0)
                {
                    foreach (var rapportCour in rapportCours)
                    {
                        listRapportCours.Items.Add(rapportCour);
                    }
                }

                listRapportCours.EndUpdate();

             
                tbAjModNoteNote.Text = null;
            }
            catch (Exception exception)
            {
            }
        }

        private void bBul_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> bulletin = new List<string>();
                bool exist = false;

                if (_elv.Count > 0)
                {
                    foreach (var eleve in _elv)
                    {
                        if (eleve.CodePermanent == cbBulCP.Text)
                        {
                            bulletin = eleve.Bulletin();
                            exist = true;
                        }
                    }

                    if (exist)
                    {
                        listBul.Items.Clear();
                        listBul.BeginUpdate();
                        if (bulletin.Count > 0)
                        {
                            foreach (var line in bulletin)
                            {
                                listBul.Items.Add(line);
                            }
                        }

                        listBul.EndUpdate();
                    }
                    else
                    {
                        listBul.Items.Clear();
                        listBul.BeginUpdate();
                        listBul.Items.Add("Invalid or empty");
                        listBul.EndUpdate();
                    }
                }
            }
            catch (Exception exception)
            {
            }
        }

        private void bSaveBul_Click(object sender, EventArgs e)
        {


            try
            {
                if (cbBulCP != null)
                {
                    List<string> bulletin = new List<string>();
                    bool exist = false;
                    SaveFileDialog SavAll = new SaveFileDialog();
                    SavAll.FileName = $"{cbBulCP.Text}.txt";
                    SavAll.Filter = "Text Files | *.txt";
                    SavAll.DefaultExt = "txt";
                    SavAll.InitialDirectory = @"c:\";
                    using (StreamWriter sw = new StreamWriter(SavAll.OpenFile()))
                    {
                        foreach (var eleve in _elv)
                        {
                            if (eleve.CodePermanent == cbBulCP.Text)
                            {
                                bulletin = eleve.Bulletin();
                                exist = true;
                            }
                        }

                        foreach (var line in bulletin)
                        {
                            sw.WriteLine(line);
                        }

                        sw.Close();
                        sw.Dispose();
                    }

                    if (exist)
                    {
                        SavAll.ShowDialog();

                    }
                }
            }
            catch (Exception exception)
            {

            }


        }




        /// <summary>
        /// SAVE / LOAD classes function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void save_Cours_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void load_Cours_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public static void SaveData()
        {
            try
            {
                var swc = new StreamWriter("CoursSave.dat");
                var swe = new StreamWriter("EleveSave.dat");

                foreach (var course in _crs)
                {
                    swc.WriteLine(course.NumeroCours);
                    swc.WriteLine(course.Titre);
                    foreach (var notes in course.Notes)
                    {
                        swc.WriteLine(notes.Key.ToString());
                        swc.WriteLine(notes.Value.ToString());
                    }

                    swc.WriteLine("end");
                }

                swc.WriteLine("endclass");

                swc.Close();
                swc.Dispose();

                List<Cours> reusable = new List<Cours>();
                foreach (var eleve in _elv)
                {
                    if (eleve.GetType() == typeof(EleveTempsPlein))
                    {
                        swe.WriteLine("tp");
                    }
                    else
                    {
                        swe.WriteLine("par");
                    }

                    swe.WriteLine(eleve.CodePermanent);
                    swe.WriteLine(eleve.GetNom());
                    swe.WriteLine(eleve.GetPrenom());
                    swe.WriteLine(eleve.GetAdress());
                    swe.WriteLine(eleve.GetNaissance());
                    reusable = eleve.GetCours();
                    if (reusable.Count > 0)
                    {

                        foreach (var course in reusable)
                        {
                            swe.WriteLine(course.NumeroCours);
                        }

                        swe.WriteLine("endbase");
                        if (eleve.GetType() == typeof(EleveTempsPlein))
                        {
                            reusable = eleve.GetCoursOpt();
                            foreach (var course in reusable)
                            {
                                swe.WriteLine(course.NumeroCours);
                            }

                            swe.WriteLine("endopt");
                        }

                    }

                    swe.WriteLine("endstudent");

                }
                swe.WriteLine("endfile");
                swe.Close();
                swe.Dispose();
            }
            catch (Exception e)
            {
            }
         

        }

        public static void LoadData()
        {

            try
            {
                var src = new StreamReader("CoursSave.dat");
                var sre = new StreamReader("EleveSave.dat");
                int count = 0;
                string endfile = src.ReadLine();
                while (endfile != "endclass" & endfile != "")
                {

                    _crs.Add(new Cours(int.Parse(endfile), src.ReadLine()));
                    string store = src.ReadLine();
                    while (store != "end")
                    {
                        _crs[count].Notes.Add(store, double.Parse(src.ReadLine()));
                        store = src.ReadLine();
                    }

                    count++;
                    endfile = src.ReadLine();
                }

                src.Close();
                src.Dispose();

                count = 0;
                endfile = sre.ReadLine();
                while (endfile != "endfile" & endfile != "")
                {
                    string cp = sre.ReadLine(),
                        nm = sre.ReadLine(),
                        pr = sre.ReadLine(),
                        adr = sre.ReadLine(),
                        dt = sre.ReadLine();

                    string[] dts = dt.Split('/');

                    if (endfile == "tp")
                        _elv.Add(new EleveTempsPlein(cp, nm, pr, adr,
                            new DateTime(int.Parse(dts[2]), int.Parse(dts[1]), int.Parse(dts[0]))));
                    else
                    {
                        _elv.Add(new EleveTempsPartiel(cp, nm, pr, adr,
                            new DateTime(int.Parse(dts[2]), int.Parse(dts[1]), int.Parse(dts[0]))));
                    }

                    string cbase = sre.ReadLine();
                    if (cbase != "endstudent")
                    {

                        while (cbase != "endbase")
                        {


                            foreach (var course in _crs)
                            {
                                if (cbase == course.NumeroCours.ToString())
                                {
                                    _elv[count].LoadCours(course, false);
                                }
                            }

                            cbase = sre.ReadLine();
                        }

                        string endoropt = sre.ReadLine();
                        if (endoropt != "endstudent")
                        {
                            while (endoropt != "endopt")
                            {

                                foreach (var course in _crs)
                                {
                                    if (endoropt == course.NumeroCours.ToString())
                                    {
                                        _elv[count].LoadCours(course, true);
                                    }
                                }

                                endoropt = sre.ReadLine();
                            }
                        }

                    }
                    endfile = sre.ReadLine();
                    if (endfile == "endstudent")
                        endfile = sre.ReadLine();
                    count++;

                }


            }
            catch (Exception e)
            {
            }

            

        }

        private void cbElvClassAddCP_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbElvClassAddCP.Items.Clear();
                foreach (var eleve in _elv)
                {
                    cbElvClassAddCP.Items.Add(eleve.CodePermanent);
                    cbElvClassAddCP.Update();
                }
            }
            catch (Exception exception)
            {
           
            }
       
        }

        private void cbElvClassAddNC_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbElvClassAddNC.Items.Clear();
                foreach (var course in _crs)
                {
                    cbElvClassAddNC.Items.Add(course.Titre);
                    cbElvClassAddNC.Update();
                }
            }
            catch (Exception)
            {

            }

          
        }

        private void cbElvClassRmvCP_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbElvClassRmvCP.Items.Clear();
                foreach (var eleve in _elv)
                {
                    cbElvClassRmvCP.Items.Add(eleve.CodePermanent);
                    cbElvClassRmvCP.Update();
                }
            }
            catch (Exception exception)
            {
            }

          
        }

        private void cbElvClassRmvNC_DropDown(object sender, EventArgs e)
        {
            try
            {

                cbElvClassRmvNC.Items.Clear();

                Eleve selected = null;
                foreach (var eleve in _elv)
                {
                    if (cbElvClassRmvCP.Text == eleve.CodePermanent)
                    {
                        selected = eleve;
                    }


                }

                List<Cours> selectedcrs = selected.GetCours();

                foreach (var course in _crs)
                {
                    if (selectedcrs.Contains(course))
                    {
                        cbElvClassRmvNC.Items.Add(course.Titre);
                        cbElvClassRmvNC.Update();
                    }

                }

                if (selected.GetType() == typeof(EleveTempsPlein))
                {
                    selectedcrs = selected.GetCoursOpt();

                    foreach (var course in _crs)
                    {
                        if (selectedcrs.Contains(course))
                        {
                            cbElvClassRmvNC.Items.Add(course.Titre + " Optionnel");
                            cbElvClassRmvNC.Update();
                        }
                    }

                }
            }
            catch (Exception exception)
            {
            }



        }

        private void cbAjModNoteNC_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbAjModNoteNC.Items.Clear();

                foreach (var course in _crs)
                {
                    cbAjModNoteNC.Items.Add(course.Titre);
                    cbAjModNoteNC.Update();
                }
            }
            catch (Exception exception)
            {
               
            }

          

        }

        private void cbAjModNoteCP_DropDown(object sender, EventArgs e)
        {
            try
            {
                cbAjModNoteCP.Items.Clear();

                foreach (var course in _crs)
                {
                    if (cbAjModNoteNC.Text == course.Titre)
                    {
                        foreach (var courseNote in course.Notes)
                        {
                            cbAjModNoteCP.Items.Add(courseNote.Key.ToString());
                            cbAjModNoteCP.Update();
                        }

                    }
                }
            }
            catch (Exception exception)
            {
    
            }

         
        }

        private void cbAjModNoteNC_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Cours selectedCours = null;

                foreach (var course in _crs)
                {
                    if (cbAjModNoteNC.Text == course.Titre)
                    {
                        selectedCours = course;
                    }
                }

                listRapportCours.Items.Clear();
                listRapportCours.BeginUpdate();
                var rapportCours = selectedCours.RapportNotesClasse();
                if (rapportCours.Count > 0)
                {
                    foreach (var rapportCour in rapportCours)
                    {
                        listRapportCours.Items.Add(rapportCour);
                    }
                }

                listRapportCours.EndUpdate();
            }
            catch (Exception exception)
            {
            }

           
        }

        private void cbBulCP_DropDown(object sender, EventArgs e)
        {

            try
            {

                cbBulCP.Items.Clear();
                foreach (var eleve in _elv)
                {
                    cbBulCP.Items.Add(eleve.CodePermanent);
                    cbBulCP.Update();
                }
            }
            catch (Exception exception)
            {
            }


        }
    }
}