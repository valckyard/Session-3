using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours18Object_Corrige
{
    public partial class Form1 : Form
    {
        private string affichage;
        private List<char> nbone;
        private bool nb1used;
        private List<char> nbtwo;
        private bool nb2used;
        private string oper;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nbone = new List<char>();
            nb1used = false;
            nbtwo = new List<char>();
            nb2used = false;
            oper = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button pushedButton = (Button)sender;
            switch (pushedButton.Text)
            {
                case "/":
                    if (nb1used)
                    {
                        nb2used = true;
                    }
                    else
                    {
                        nb1used = true;
                        oper = "/";
                        affichage += "/";
                        textBox1.Text = affichage;
                    }

                    break;
                case "*":
                    if (nb1used)
                    {
                        nb2used = true;
                    }
                    else
                    {
                        nb1used = true;
                        oper = "*";
                        affichage += "*";
                        textBox1.Text = affichage;
                    }

                    break;
                case "-":
                    if (nb1used)
                    {
                        nb2used = true;
                    }
                    else
                    {
                        nb1used = true;
                        oper = "-";
                        affichage += "-";
                        textBox1.Text = affichage;
                      
                    }
                    break;
                case "+":
                    if (nb1used)
                    {
                        nb2used = true;
                    }
                    else
                    {
                        nb1used = true;
                        oper = "+";
                        affichage += "+";
                        textBox1.Text = affichage;
                    }

                    break;
                case "=":
                    if (oper != null)
                    {
                      float result =  Calc();
                        label1.Text = result.ToString();
                        nbone = new List<char>();
                        nb1used = false;
                        nbtwo = new List<char>();
                        nb2used = false;
                        oper = null;
                        affichage = null;
                    }
                    break;
                default:
                    if (!nb1used)
                    {
                        var numb = pushedButton.Text.ToString();
                        nbone.Add(numb[0]);
                        affichage += numb[0];
                        textBox1.Text = affichage;

                    }
                    else if(!nb2used)
                    {
                   
                        var numb = pushedButton.Text.ToString();
                        nbtwo.Add(numb[0]);
                        affichage += numb[0];
                        textBox1.Text = affichage;
                    }
              
                    break;
            }
           
          
        }

        public float Calc()
        {
            string sone = null;
            string stwo = null;
            bool dot1 = false;
            bool dot2 = false;
            foreach (var c in nbone)
            {
               
                if (c == '.')
                {
                    if (dot1)
                    {
                        break;
                    }
                    else
                    {
                        dot1 = true;
                    }

                }
                sone += c;

            }
            foreach (var c in nbtwo)
            {

                if (c == '.')
                {
                    if (dot2)
                    {
                        break;
                    }
                    else
                    {
                        dot2 = true;
                    }

                }
                stwo += c;
            }

            if (sone == null)
            {
                sone = "0";
            }

            if (stwo == null)
            {
                stwo = "0";
            }

            float one = float.Parse(sone);
            float two = float.Parse(stwo);
            float result;

            switch (oper)
            {
                case "/":
                    result = one / two;
                    return result;
                case "*":
                    result = one * two;
                    return result;
                case "-":
                    result = one - two;
                    return result;
                case "+":
                    result = one + two;
                    return result;
                default:
                    return 0;
            }

        }


    }
}


