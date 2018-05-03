namespace Cours18Object_Martin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbDegree = new System.Windows.Forms.TextBox();
            this.rbFah = new System.Windows.Forms.RadioButton();
            this.rbCel = new System.Windows.Forms.RadioButton();
            this.lbresult = new System.Windows.Forms.Label();
            this.bConversion = new System.Windows.Forms.Button();
            this.listbrecord = new System.Windows.Forms.ListBox();
            this.bSave = new System.Windows.Forms.Button();
            this.cbtypepoid = new System.Windows.Forms.ComboBox();
            this.tbPoids = new System.Windows.Forms.TextBox();
            this.bCvtpoid = new System.Windows.Forms.Button();
            this.lbpdsCvt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbDegree
            // 
            this.tbDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDegree.Location = new System.Drawing.Point(94, 49);
            this.tbDegree.Name = "tbDegree";
            this.tbDegree.Size = new System.Drawing.Size(100, 35);
            this.tbDegree.TabIndex = 0;
            // 
            // rbFah
            // 
            this.rbFah.AutoSize = true;
            this.rbFah.Location = new System.Drawing.Point(200, 67);
            this.rbFah.Name = "rbFah";
            this.rbFah.Size = new System.Drawing.Size(75, 17);
            this.rbFah.TabIndex = 1;
            this.rbFah.TabStop = true;
            this.rbFah.Text = "Fahrenheit";
            this.rbFah.UseVisualStyleBackColor = true;
            // 
            // rbCel
            // 
            this.rbCel.AutoSize = true;
            this.rbCel.Location = new System.Drawing.Point(200, 44);
            this.rbCel.Name = "rbCel";
            this.rbCel.Size = new System.Drawing.Size(59, 17);
            this.rbCel.TabIndex = 2;
            this.rbCel.TabStop = true;
            this.rbCel.Text = "Celcius";
            this.rbCel.UseVisualStyleBackColor = true;
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.Location = new System.Drawing.Point(282, 49);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(0, 31);
            this.lbresult.TabIndex = 3;
            // 
            // bConversion
            // 
            this.bConversion.Location = new System.Drawing.Point(147, 103);
            this.bConversion.Name = "bConversion";
            this.bConversion.Size = new System.Drawing.Size(75, 23);
            this.bConversion.TabIndex = 4;
            this.bConversion.Text = "Conversion";
            this.bConversion.UseVisualStyleBackColor = true;
            this.bConversion.Click += new System.EventHandler(this.bConversion_Click);
            // 
            // listbrecord
            // 
            this.listbrecord.FormattingEnabled = true;
            this.listbrecord.Location = new System.Drawing.Point(94, 150);
            this.listbrecord.Name = "listbrecord";
            this.listbrecord.Size = new System.Drawing.Size(434, 134);
            this.listbrecord.TabIndex = 5;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(271, 304);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 23);
            this.bSave.TabIndex = 6;
            this.bSave.Text = "Save Conversions";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // cbtypepoid
            // 
            this.cbtypepoid.FormattingEnabled = true;
            this.cbtypepoid.Location = new System.Drawing.Point(587, 49);
            this.cbtypepoid.Name = "cbtypepoid";
            this.cbtypepoid.Size = new System.Drawing.Size(121, 21);
            this.cbtypepoid.TabIndex = 7;
            // 
            // tbPoids
            // 
            this.tbPoids.Location = new System.Drawing.Point(608, 23);
            this.tbPoids.Name = "tbPoids";
            this.tbPoids.Size = new System.Drawing.Size(100, 20);
            this.tbPoids.TabIndex = 8;
            // 
            // bCvtpoid
            // 
            this.bCvtpoid.Location = new System.Drawing.Point(565, 90);
            this.bCvtpoid.Name = "bCvtpoid";
            this.bCvtpoid.Size = new System.Drawing.Size(134, 23);
            this.bCvtpoid.TabIndex = 9;
            this.bCvtpoid.Text = "Converti Ma Graisse";
            this.bCvtpoid.UseVisualStyleBackColor = true;
            this.bCvtpoid.Click += new System.EventHandler(this.bCvtpoid_Click);
            // 
            // lbpdsCvt
            // 
            this.lbpdsCvt.AutoSize = true;
            this.lbpdsCvt.Location = new System.Drawing.Point(587, 139);
            this.lbpdsCvt.Name = "lbpdsCvt";
            this.lbpdsCvt.Size = new System.Drawing.Size(0, 13);
            this.lbpdsCvt.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbpdsCvt);
            this.Controls.Add(this.bCvtpoid);
            this.Controls.Add(this.tbPoids);
            this.Controls.Add(this.cbtypepoid);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.listbrecord);
            this.Controls.Add(this.bConversion);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.rbCel);
            this.Controls.Add(this.rbFah);
            this.Controls.Add(this.tbDegree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDegree;
        private System.Windows.Forms.RadioButton rbFah;
        private System.Windows.Forms.RadioButton rbCel;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.Button bConversion;
        private System.Windows.Forms.ListBox listbrecord;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.ComboBox cbtypepoid;
        private System.Windows.Forms.TextBox tbPoids;
        private System.Windows.Forms.Button bCvtpoid;
        private System.Windows.Forms.Label lbpdsCvt;
    }
}

