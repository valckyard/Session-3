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
using _2___Final_Project_Object_Lib;

namespace _1___Final_Project_Object
{
    public partial class Form1 : Form
    {
        private SQLConn _databaseConnection;
        private UserConnection _loggedUserConnection = null;

        public Form1()
        {
            InitializeComponent();

        }

        private void App_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSharpProjFinalDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.cSharpProjFinalDataSet.users);
            _databaseConnection = new SQLConn();

        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            byte[] login = Encoding.ASCII.GetBytes(tbLogin.Text);
            byte[] password = Encoding.ASCII.GetBytes(tbPassword.Text);

          string connectionResponse =  _databaseConnection.CheckConnection(login, password);
            consoletest.Items.Add(connectionResponse);

            if (connectionResponse == "Good Password")
            {
                string comm =
                    $"SELECT * FROM users WHERE USERNAME = '{tbLogin.Text}' AND USERPASS = '{tbPassword.Text}'";
               string acctype = _databaseConnection.SQLGetParam(comm, "usertype");
                consoletest.Items.Add(acctype);


                string getiduser = $"SELECT * FROM users WHERE USERNAME = '{Encoding.ASCII.GetString(login)}'";

                string iduser = _databaseConnection.SQLGetParam(getiduser, "userid");
                _loggedUserConnection = new UserConnection(login, password, int.Parse(acctype), int.Parse(iduser));
                _loggedUserConnection.GetMessages(_databaseConnection);
                lstTitre = _loggedUserConnection.GetTitres(lstTitre);
            }
            else
            {
                consoletest.Items.Add("Could not log in");
            }
        }

        private void tabControl_TabIndexChanged(object sender, EventArgs e)
        {
            if (_loggedUserConnection == null) tabControl.SelectedTab = tabPage1;
            if(_loggedUserConnection != null)
            {
                TabControl test = (TabControl) sender;
                tabControl.SelectedIndex = test.SelectedIndex;
            }
        }

        private void bSendMsg_Click(object sender, EventArgs e)
        {

            string tosend = null;

            foreach (var line in rtbMsgBody.Lines)
            {
                tosend += line + '¸';
            }


            string sendto = _databaseConnection.SQLGetParam($"SELECT * FROM user WHERE username='{tbUserTo.Text}';","userid");

            var msg = new MessageSQL(TbTitre.Text, tosend, _loggedUserConnection.Userid, int.Parse(sendto));

            consoletest.Items.Add(msg.SendMessage(_databaseConnection));
        }

 
        private void lstTitre_SelectedIndexChanged(object sender, EventArgs e)
        {
            var message = _loggedUserConnection.ShowMessage(lstTitre.SelectedIndex);

            if (message != null)
            {

                //foreach (var s in message)
                //{

                //    rtbMsgBody.Text += Environment.NewLine + s;
                //}
                rtbMsgBody.Text = message;

                rtbMsgBody.Update();
            }
        }
    }
}
