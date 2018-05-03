using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours16Object_Exercice
{
    public partial class Form1 : Form
    {
        private List<string> bla;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bla = new List<string>();

            bla.Add("chose");
        }



        public void hahah()
        {
          string chose =  bla[0];
        }
    }
}
