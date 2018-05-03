using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours18Object_Martin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbCel.Checked = true;
        }

        private void bConversion_Click(object sender, EventArgs e)
        {
            try
            {
                double tempvalue = double.Parse(tbDegree.Text);

                if (rbCel.Checked)
                {
                    lbresult.Text = ((tempvalue - 32) / 1.8).ToString("N2") + " Degree Celcius";
                    listbrecord.Items.Add(tempvalue.ToString("N2") + " Deg Fahrenheit ---> " + lbresult.Text);
                    listbrecord.Update();
                }
                else
                {
                    lbresult.Text = ((tempvalue * 1.8) + 32).ToString("N2") + " Degree Fahrenheit";
                    listbrecord.Items.Add(tempvalue.ToString("N2") + " Deg Celcius ---> " + lbresult.Text);
                    listbrecord.Update();
                }
            }
            catch (Exception exception)
            {
                lbresult.Text = "Invalid Characters!";
            }
           
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog SavAll = new SaveFileDialog();
            SavAll.Title = "SAVE STESTI DE FICHER ";
            SavAll.FileName = $@"SaveConversion";
            SavAll.Filter = "Text Files|*.txt";
            SavAll.FilterIndex = 1;
            SavAll.DefaultExt = "txt";
            SavAll.InitialDirectory = @"d:\";
            SavAll.CheckPathExists = true;
            if (SavAll.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(SavAll.OpenFile()))
                {

                    foreach (var item in listbrecord.Items)
                    {
                        sw.WriteLine(item);
                    }


                    sw.Close();
                    sw.Dispose();

                }
            }
            SavAll.Dispose();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbtypepoid.Items.Add("LIVRES");
            cbtypepoid.Items.Add("KILOJRAMME");
            cbtypepoid.Update();
            cbtypepoid.SelectedIndex = 0;
        }

        private void bCvtpoid_Click(object sender, EventArgs e)
        {
            if (cbtypepoid.SelectedIndex == 0)
            {
                lbpdsCvt.Text = (double.Parse(tbPoids.Text) * 2.2).ToString("N2") + " Livres";

            }
            else if (cbtypepoid.SelectedIndex == 1)
            {
                lbpdsCvt.Text = (double.Parse(tbPoids.Text) / 2.2).ToString("N2") + " Kilojrammes";

            }
            else
            {
                lbpdsCvt.Text = "vachier ca pas rapport";
            }
           
        }
    }
}
