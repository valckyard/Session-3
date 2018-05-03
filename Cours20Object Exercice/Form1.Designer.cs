namespace Cours20Object_Exercice
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
            this.lstLoaded = new System.Windows.Forms.ListBox();
            this.lstToSave = new System.Windows.Forms.ListBox();
            this.bTransfer = new System.Windows.Forms.Button();
            this.bExport = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.rbDroite = new System.Windows.Forms.RadioButton();
            this.rbGauche = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bGetSplithtml = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bGetHTMLString = new System.Windows.Forms.Button();
            this.bAllRight = new System.Windows.Forms.Button();
            this.bAllLeft = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstLoaded
            // 
            this.lstLoaded.FormattingEnabled = true;
            this.lstLoaded.Location = new System.Drawing.Point(12, 54);
            this.lstLoaded.Name = "lstLoaded";
            this.lstLoaded.Size = new System.Drawing.Size(257, 290);
            this.lstLoaded.TabIndex = 0;
            this.lstLoaded.SelectedIndexChanged += new System.EventHandler(this.lstboxes_SelectedIndexChanged);
            // 
            // lstToSave
            // 
            this.lstToSave.FormattingEnabled = true;
            this.lstToSave.Location = new System.Drawing.Point(338, 54);
            this.lstToSave.Name = "lstToSave";
            this.lstToSave.Size = new System.Drawing.Size(257, 290);
            this.lstToSave.TabIndex = 1;
            this.lstToSave.SelectedIndexChanged += new System.EventHandler(this.lstboxes_SelectedIndexChanged);
            // 
            // bTransfer
            // 
            this.bTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTransfer.Location = new System.Drawing.Point(275, 130);
            this.bTransfer.Name = "bTransfer";
            this.bTransfer.Size = new System.Drawing.Size(57, 23);
            this.bTransfer.TabIndex = 2;
            this.bTransfer.Text = "<<>>";
            this.bTransfer.UseVisualStyleBackColor = true;
            this.bTransfer.Click += new System.EventHandler(this.bTransfer_Click);
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(338, 12);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(257, 36);
            this.bExport.TabIndex = 3;
            this.bExport.Text = "EXPORT";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(12, 12);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(257, 36);
            this.bLoad.TabIndex = 4;
            this.bLoad.Text = "LOAD FILE";
            this.bLoad.UseVisualStyleBackColor = true;
            this.bLoad.Click += new System.EventHandler(this.bLoad_Click);
            // 
            // rbDroite
            // 
            this.rbDroite.AutoSize = true;
            this.rbDroite.Location = new System.Drawing.Point(275, 159);
            this.rbDroite.Name = "rbDroite";
            this.rbDroite.Size = new System.Drawing.Size(53, 17);
            this.rbDroite.TabIndex = 5;
            this.rbDroite.TabStop = true;
            this.rbDroite.Text = "Droite";
            this.rbDroite.UseVisualStyleBackColor = true;
            // 
            // rbGauche
            // 
            this.rbGauche.AutoSize = true;
            this.rbGauche.Location = new System.Drawing.Point(275, 182);
            this.rbGauche.Name = "rbGauche";
            this.rbGauche.Size = new System.Drawing.Size(63, 17);
            this.rbGauche.TabIndex = 6;
            this.rbGauche.TabStop = true;
            this.rbGauche.Text = "Gauche";
            this.rbGauche.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(75, 350);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "www.perdu.com";
            // 
            // bGetSplithtml
            // 
            this.bGetSplithtml.Location = new System.Drawing.Point(313, 382);
            this.bGetSplithtml.Name = "bGetSplithtml";
            this.bGetSplithtml.Size = new System.Drawing.Size(282, 23);
            this.bGetSplithtml.TabIndex = 8;
            this.bGetSplithtml.Text = "GET Splitted HTML";
            this.bGetSplithtml.UseVisualStyleBackColor = true;
            this.bGetSplithtml.Click += new System.EventHandler(this.bSplitHtml_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 425);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(583, 79);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "http://";
            // 
            // bGetHTMLString
            // 
            this.bGetHTMLString.Location = new System.Drawing.Point(12, 382);
            this.bGetHTMLString.Name = "bGetHTMLString";
            this.bGetHTMLString.Size = new System.Drawing.Size(295, 23);
            this.bGetHTMLString.TabIndex = 11;
            this.bGetHTMLString.Text = "GET  HTML String";
            this.bGetHTMLString.UseVisualStyleBackColor = true;
            this.bGetHTMLString.Click += new System.EventHandler(this.bGetHTMLString_Click);
            // 
            // bAllRight
            // 
            this.bAllRight.Location = new System.Drawing.Point(275, 252);
            this.bAllRight.Name = "bAllRight";
            this.bAllRight.Size = new System.Drawing.Size(57, 36);
            this.bAllRight.TabIndex = 12;
            this.bAllRight.Text = "ALL   >>>>";
            this.bAllRight.UseVisualStyleBackColor = true;
            this.bAllRight.Click += new System.EventHandler(this.bAllRight_Click);
            // 
            // bAllLeft
            // 
            this.bAllLeft.Location = new System.Drawing.Point(275, 294);
            this.bAllLeft.Name = "bAllLeft";
            this.bAllLeft.Size = new System.Drawing.Size(57, 36);
            this.bAllLeft.TabIndex = 13;
            this.bAllLeft.Text = "ALL   <<<<";
            this.bAllLeft.UseVisualStyleBackColor = true;
            this.bAllLeft.Click += new System.EventHandler(this.bAllLeft_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 521);
            this.Controls.Add(this.bAllLeft);
            this.Controls.Add(this.bAllRight);
            this.Controls.Add(this.bGetHTMLString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bGetSplithtml);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbGauche);
            this.Controls.Add(this.rbDroite);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.bTransfer);
            this.Controls.Add(this.lstToSave);
            this.Controls.Add(this.lstLoaded);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLoaded;
        private System.Windows.Forms.ListBox lstToSave;
        private System.Windows.Forms.Button bTransfer;
        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.RadioButton rbDroite;
        private System.Windows.Forms.RadioButton rbGauche;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bGetSplithtml;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bGetHTMLString;
        private System.Windows.Forms.Button bAllRight;
        private System.Windows.Forms.Button bAllLeft;
    }
}

