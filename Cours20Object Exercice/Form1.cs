using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;


namespace Cours20Object_Exercice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbGauche.Checked = true;
        }

        /// <summary>
        /// LOAD FROM TEXT FILES
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "*.txt|Text Files";
            oFile.DefaultExt = "txt";
            oFile.FileName = "*.txt";
            oFile.InitialDirectory = @"c:";

            if (oFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(oFile.OpenFile(), Encoding.Default))
                {

                    string line = null;
                    while ((line = sr.ReadLine()) != null)
                    {
                        lstLoaded.Items.Add(line);
                    }
                    sr.Dispose();
                }
                MessageBox.Show("File is Loaded","Load", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }



        /// <summary>
        /// SAVE FILE FROM RIGHT HAND BOX
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sFile = new SaveFileDialog();
            sFile.Filter = "*.txt|'Text'|*.*|'ALL FILES'"; // all files for fun
            sFile.DefaultExt = "txt";
            sFile.FileName = "Cours20TP";
            sFile.InitialDirectory = @"c:";

            if (sFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sFile.OpenFile(), Encoding.Default))
                {

                    foreach (var item in lstToSave.Items)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Dispose();
                }
                MessageBox.Show("File is Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        /// <summary>
        /// Tranfer button check the checked one and transfer accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bTransfer_Click(object sender, EventArgs e)
        {
            if (rbDroite.Checked)
            {
                BoxMoveRight();
            }
            else
            {
                BoxMoveLeft();
            }
        }




        /// <summary>
        /// move right
        /// </summary>
        public void BoxMoveRight()
        {
            if (lstLoaded.SelectedItem != null)
            {
                lstToSave.Items.Add(lstLoaded.SelectedItem.ToString());
                lstLoaded.Items.RemoveAt(lstLoaded.SelectedIndex);
            }
       

        }

        /// <summary>
        /// move left
        /// </summary>
        public void BoxMoveLeft()
        {
            if (lstToSave.SelectedItem != null)
            {
                lstLoaded.Items.Add(lstToSave.SelectedItem.ToString());
                lstToSave.Items.RemoveAt(lstToSave.SelectedIndex);
            }
        }



        /// <summary>
        /// FULL MOVE METHODS
        /// </summary>
        public void FullMoveLeft()
        {
            if (lstToSave.Items.Count > 0)
            {
                foreach (var item in lstToSave.Items)
                {
                    lstLoaded.Items.Add(item);
                }
                lstToSave.Items.Clear();
            }
        }
       

        public void FullMoveRight()
        {
            if (lstLoaded.Items.Count > 0)
            {
                foreach (var item in lstLoaded.Items)
                {
                    lstToSave.Items.Add(item);
                }
                lstLoaded.Items.Clear();

            }
        }


        /// <summary>
        /// full moves Buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAllLeft_Click(object sender, EventArgs e)
        {
            FullMoveLeft();
        }
        private void bAllRight_Click(object sender, EventArgs e)
        {
            FullMoveRight();
        }



        /// <summary>
        /// preview single item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstboxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstToSave.Focused)
            {
                richTextBox1.Text = lstToSave.SelectedItem.ToString();
            }

            if (lstLoaded.Focused)
            {
                richTextBox1.Text = lstLoaded.SelectedItem.ToString();
            }
        }









        /// <summary>
        /// get html code from a web page
        /// </summary>
        /// <param name="Url"></param>
        /// <returns></returns>

        public static String GetHTMLCode(string Url)
        {
            try
            {
                string baseUrl = "http://";

                Url = baseUrl + Url;

                String result = null;

                using (WebClient client = new WebClient())
                {
                    result = client.DownloadString(Url);

                }
                return result;
            }
            catch (Exception e)
            {
                return "Invalid web page";
            }
        }


        /// <summary>
        /// use the getter and split the string making it more readable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSplitHtml_Click(object sender, EventArgs e)
        {
           String htmlCodestring = GetHTMLCode(textBox1.Text);

            var htmlPageSplit = Regex.Split(htmlCodestring, @"(?<=[>])");

            foreach (var s in htmlPageSplit)
            {
                lstLoaded.Items.Add(s);
            }
           
            richTextBox1.Text = htmlPageSplit[0];
        }



        /// <summary>
        /// Uses the full string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bGetHTMLString_Click(object sender, EventArgs e)
        {
            String htmlCodestring = GetHTMLCode(textBox1.Text);
            lstLoaded.Items.Add(htmlCodestring);
            richTextBox1.Text = htmlCodestring;
        }



      

      
    }
}
