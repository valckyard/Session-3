namespace _1___Final_Project_Object
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.consoletest = new System.Windows.Forms.ListBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.bConnect = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbMsgSendTo = new System.Windows.Forms.Label();
            this.tbUserTo = new System.Windows.Forms.TextBox();
            this.bSendMsg = new System.Windows.Forms.Button();
            this.rtbMsgBody = new System.Windows.Forms.RichTextBox();
            this.lbMsgTitre = new System.Windows.Forms.Label();
            this.TbTitre = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cSharpProjFinalDataSet = new _1___Final_Project_Object.CSharpProjFinalDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbMsgReader = new System.Windows.Forms.RichTextBox();
            this.lstTitre = new System.Windows.Forms.ListBox();
            this.usersTableAdapter = new _1___Final_Project_Object.CSharpProjFinalDataSetTableAdapters.usersTableAdapter();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpProjFinalDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 794);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            this.tabControl.TabIndexChanged += new System.EventHandler(this.tabControl_TabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.consoletest);
            this.tabPage1.Controls.Add(this.lbPassword);
            this.tabPage1.Controls.Add(this.lbLogin);
            this.tabPage1.Controls.Add(this.tbPassword);
            this.tabPage1.Controls.Add(this.tbLogin);
            this.tabPage1.Controls.Add(this.bConnect);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 768);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // consoletest
            // 
            this.consoletest.FormattingEnabled = true;
            this.consoletest.Location = new System.Drawing.Point(198, 306);
            this.consoletest.Name = "consoletest";
            this.consoletest.Size = new System.Drawing.Size(754, 225);
            this.consoletest.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(392, 180);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(392, 110);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(33, 13);
            this.lbLogin.TabIndex = 3;
            this.lbLogin.Text = "Login";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(395, 205);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(215, 20);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(395, 140);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(215, 20);
            this.tbLogin.TabIndex = 1;
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(454, 240);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(75, 23);
            this.bConnect.TabIndex = 0;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbMsgSendTo);
            this.tabPage2.Controls.Add(this.tbUserTo);
            this.tabPage2.Controls.Add(this.bSendMsg);
            this.tabPage2.Controls.Add(this.rtbMsgBody);
            this.tabPage2.Controls.Add(this.lbMsgTitre);
            this.tabPage2.Controls.Add(this.TbTitre);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 768);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbMsgSendTo
            // 
            this.lbMsgSendTo.AutoSize = true;
            this.lbMsgSendTo.Location = new System.Drawing.Point(318, 368);
            this.lbMsgSendTo.Name = "lbMsgSendTo";
            this.lbMsgSendTo.Size = new System.Drawing.Size(45, 13);
            this.lbMsgSendTo.TabIndex = 6;
            this.lbMsgSendTo.Text = "SendTo";
            // 
            // tbUserTo
            // 
            this.tbUserTo.Location = new System.Drawing.Point(408, 369);
            this.tbUserTo.Name = "tbUserTo";
            this.tbUserTo.Size = new System.Drawing.Size(100, 20);
            this.tbUserTo.TabIndex = 5;
            // 
            // bSendMsg
            // 
            this.bSendMsg.Location = new System.Drawing.Point(727, 683);
            this.bSendMsg.Name = "bSendMsg";
            this.bSendMsg.Size = new System.Drawing.Size(167, 23);
            this.bSendMsg.TabIndex = 4;
            this.bSendMsg.Text = "Send Message";
            this.bSendMsg.UseVisualStyleBackColor = true;
            this.bSendMsg.Click += new System.EventHandler(this.bSendMsg_Click);
            // 
            // rtbMsgBody
            // 
            this.rtbMsgBody.Location = new System.Drawing.Point(81, 459);
            this.rtbMsgBody.Name = "rtbMsgBody";
            this.rtbMsgBody.Size = new System.Drawing.Size(750, 200);
            this.rtbMsgBody.TabIndex = 3;
            this.rtbMsgBody.Text = "";
            // 
            // lbMsgTitre
            // 
            this.lbMsgTitre.AutoSize = true;
            this.lbMsgTitre.Location = new System.Drawing.Point(78, 369);
            this.lbMsgTitre.Name = "lbMsgTitre";
            this.lbMsgTitre.Size = new System.Drawing.Size(28, 13);
            this.lbMsgTitre.TabIndex = 2;
            this.lbMsgTitre.Text = "Titre";
            // 
            // TbTitre
            // 
            this.TbTitre.Location = new System.Drawing.Point(78, 408);
            this.TbTitre.Name = "TbTitre";
            this.TbTitre.Size = new System.Drawing.Size(100, 20);
            this.TbTitre.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.userpassDataGridViewTextBoxColumn,
            this.usertypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(193, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(717, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "userid";
            this.useridDataGridViewTextBoxColumn.HeaderText = "userid";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // userpassDataGridViewTextBoxColumn
            // 
            this.userpassDataGridViewTextBoxColumn.DataPropertyName = "userpass";
            this.userpassDataGridViewTextBoxColumn.HeaderText = "userpass";
            this.userpassDataGridViewTextBoxColumn.Name = "userpassDataGridViewTextBoxColumn";
            // 
            // usertypeDataGridViewTextBoxColumn
            // 
            this.usertypeDataGridViewTextBoxColumn.DataPropertyName = "usertype";
            this.usertypeDataGridViewTextBoxColumn.HeaderText = "usertype";
            this.usertypeDataGridViewTextBoxColumn.Name = "usertypeDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.cSharpProjFinalDataSet;
            // 
            // cSharpProjFinalDataSet
            // 
            this.cSharpProjFinalDataSet.DataSetName = "CSharpProjFinalDataSet";
            this.cSharpProjFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbMsgReader);
            this.tabPage3.Controls.Add(this.lstTitre);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1092, 768);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbMsgReader
            // 
            this.rtbMsgReader.Location = new System.Drawing.Point(422, 124);
            this.rtbMsgReader.Name = "rtbMsgReader";
            this.rtbMsgReader.Size = new System.Drawing.Size(587, 478);
            this.rtbMsgReader.TabIndex = 1;
            this.rtbMsgReader.Text = "";
            // 
            // lstTitre
            // 
            this.lstTitre.FormattingEnabled = true;
            this.lstTitre.Location = new System.Drawing.Point(252, 124);
            this.lstTitre.Name = "lstTitre";
            this.lstTitre.Size = new System.Drawing.Size(120, 95);
            this.lstTitre.TabIndex = 0;
            this.lstTitre.SelectedIndexChanged += new System.EventHandler(this.lstTitre_SelectedIndexChanged);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 791);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.App_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpProjFinalDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox consoletest;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CSharpProjFinalDataSet cSharpProjFinalDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private CSharpProjFinalDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbMsgSendTo;
        private System.Windows.Forms.TextBox tbUserTo;
        private System.Windows.Forms.Button bSendMsg;
        private System.Windows.Forms.RichTextBox rtbMsgBody;
        private System.Windows.Forms.Label lbMsgTitre;
        private System.Windows.Forms.TextBox TbTitre;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstTitre;
        private System.Windows.Forms.RichTextBox rtbMsgReader;
    }
}

