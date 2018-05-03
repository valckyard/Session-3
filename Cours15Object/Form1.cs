using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours15Object
{
    public partial class Form1 : Form
    {
        private TextBox mbox;
        private TextBox mbox2;
        private ListBox lbox1;
        private Button b_reset;
        private Label lb1;
        private Button b1;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.b1 = new System.Windows.Forms.Button();
            this.mbox = new System.Windows.Forms.TextBox();
            this.mbox2 = new System.Windows.Forms.TextBox();
            this.lbox1 = new System.Windows.Forms.ListBox();
            this.b_reset = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(2, 23);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(243, 23);
            this.b1.TabIndex = 0;
            this.b1.Text = "Jaime Les Perchaudes";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // mbox
            // 
            this.mbox.Location = new System.Drawing.Point(12, 107);
            this.mbox.Name = "mbox";
            this.mbox.Size = new System.Drawing.Size(179, 20);
            this.mbox.TabIndex = 1;
            this.mbox.Enter += new System.EventHandler(this.b1_Click);
            // 
            // mbox2
            // 
            this.mbox2.Location = new System.Drawing.Point(12, 133);
            this.mbox2.Name = "mbox2";
            this.mbox2.Size = new System.Drawing.Size(179, 20);
            this.mbox2.TabIndex = 2;
            this.mbox2.Text = "NANANANA BATMAN";
            // 
            // lbox1
            // 
            this.lbox1.FormattingEnabled = true;
            this.lbox1.Location = new System.Drawing.Point(12, 159);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(179, 95);
            this.lbox1.TabIndex = 3;
            // 
            // b_reset
            // 
            this.b_reset.Location = new System.Drawing.Point(197, 189);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(75, 60);
            this.b_reset.TabIndex = 4;
            this.b_reset.Text = "RESET";
            this.b_reset.UseVisualStyleBackColor = true;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(197, 107);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 13);
            this.lb1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.lbox1);
            this.Controls.Add(this.mbox2);
            this.Controls.Add(this.mbox);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void b1_Click(object sender, EventArgs e)
        {
            mbox.Text = b1.Text;
            mbox.ForeColor = Color.White;
            mbox.BackColor = Color.Blue;
            mbox2.ForeColor = Color.Yellow;
            mbox2.BackColor = Color.Black;
          
            AddFields();
            lb1.Text = "COPIED!";
            lb1.ForeColor = Color.Green;
            
        }

        private void AddFields()
        {
            if (lbox1.Items.Count <2)
            {
                lbox1.BeginUpdate();
                lbox1.Items.Add(mbox.Text);
                lbox1.Items.Add(mbox2.Text);
                lbox1.EndUpdate();
            }
        }

        private void b_reset_Click(object sender, EventArgs e)
        {
            lbox1.BeginUpdate();
            lbox1.Items.Clear();
            lbox1.EndUpdate();
            mbox.Text = null;
            mbox2.Text = null;
            lb1.Text = "RESETTED!";
            lb1.ForeColor = Color.Red;

        }
    }
}
