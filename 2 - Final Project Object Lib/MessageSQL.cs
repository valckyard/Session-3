using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Final_Project_Object_Lib
{
    public class MessageSQL
    {
        public string _titre { get; }
        public string _bodymsg { get; }
        private int _senderId;
        private int _mailtouser;

        public MessageSQL(string titre, string bodymsg, int senderid, int mailtouser)
        {
            _titre = titre;
            _bodymsg = bodymsg;
            _senderId = senderid;
            _mailtouser = mailtouser;
        }

        public string SendMessage(SQLConn conn)
        {
            string getMailtoId = $"SELECT * FROM users WHERE USERNAME = '{_mailtouser}'";

           int receiverId = int.Parse(conn.SQLGetParam(getMailtoId, "userid"));

            string sender = $"INSERT INTO message VALUES('{_titre}' , '{_bodymsg}',{receiverId}, {_senderId});";
           return conn.SQLCommand(sender);
            
        }

    }
}
