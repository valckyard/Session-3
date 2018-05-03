using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours17Object_Exercice
{
    public partial class Calculatrice : Form
    {
        private List<float> _calcnum;
        private List<char> _operands;

        private string tempstring;
        private string temprender;
     

        public Calculatrice()
        {
            

            _calcnum = new List<float>();
            _operands = new List<char>();
            InitializeComponent();
        }

        public void button_Click(object sender, EventArgs e)
        {
                Button pushed = (Button)sender;
                tempstring += pushed.Text;
                temprender = tempstring;
                tbcalc.Text = temprender;
        }


        private void bequal_Click(object sender, EventArgs e)
        {

            float result =  Calc();
            EndCalcSemiClear(result, "Calculated");
        }

        public float Evaloperand(float value, char operand, float result)
        {
            try
            {
                switch (operand)
                {
                    case '/':
                        return result /= value;
                    case '*':
                        return result *= value;
                    case '-':
                        return result -= value;
                    case '+':
                        return result += value;
                    case '%':
                        return result % value;
                    case '^':
                        return (float)Math.Pow(result, value);
                    default:
                        return result;
                }
            }
            catch (Exception e)
            {
                Clear("Error Operand Clearing calc");
                return 0;
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Clear("Cleared");
           
        }

        public void Clear(string text)
        {
            temprender = null;
            tempstring = null;
            tbcalc.Text = null;
            tbreponse.Text = null;
            _calcnum = new List<float>();
            _operands = new List<char>();
            lberrors.Text = text;

        }

        public void EndCalcSemiClear(float result, string text)
        {
            tbreponse.Text = result.ToString();
            lberrors.Text = text;
            tempstring = null;
            _calcnum = new List<float>();
            _operands = new List<char>();
        }


        public float Calc()
        {
            try
            {


                var calcsplit = tempstring.Split('/', '*', '-', '+', '%', '^');
                var opsplit = tempstring.Split('1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '.', 'm');
                foreach (var s in calcsplit)
                {
                   if (s[0] == 'm')
                    {
                        var minusfloat = s.Split('m');
                        _calcnum.Add(0 - (float.Parse(minusfloat[1])));
                    }
                    else
                    {
                        _calcnum.Add(float.Parse(s));

                    }

                }

                foreach (var s in opsplit)
                {
                    if (s != "")
                    {
                        char operand = s[0];
                        _operands.Add(operand);
                    }


                }



                float result = _calcnum[0];
                for (int i = 1; i < _calcnum.Count; i++)
                {
                    result = Evaloperand(_calcnum[i], _operands[i - 1], result);
                }

                return result;

            }
            catch (Exception exception)
            {

                EndCalcSemiClear(0 , "INVALID OPERATION");
                return 0;
            }

        }

        private void bsqareroot_Click(object sender, EventArgs e)
        {
            try
            {
                float result = Calc();
                result = (float)Math.Sqrt(result);
                if (result > 0)
                {
                    EndCalcSemiClear(result, "Square Root Calculated");
                }
                else
                {
                    EndCalcSemiClear(0, "Square Root Could not be Calculated");
                }
            }
            catch (Exception exception)
            {

                lberrors.Text = "Square Root Failed";
            }
           
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (tempstring != null)
            {

                if (tempstring.Length != 0)
                {
                    int last = tempstring.Length;
                    tempstring = tempstring.Remove(last - 1);
                    temprender = tempstring;
                    tbcalc.Text = temprender;
                }
            }

          
        }
    }
}
