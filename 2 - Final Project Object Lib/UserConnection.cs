using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _2___Final_Project_Object_Lib
{
     public class UserConnection
     {
         public int Userid { get; }
         private byte[] _login;
        private byte[] _password;
        private int _type;
         private List<MessageSQL> _userMsg;


        public UserConnection(byte[] login, byte[] password, int type , int id)
        {
            this._login = login;
            this._password = password;
            _type = type;
            Userid = id;


        }


         public void GetMessages(SQLConn conn)
         {

            _userMsg = conn.GetMessagesFromDB(Userid);
         }

         public ListBox GetTitres(ListBox list)
         {
             foreach (var messageSql in _userMsg)
             {
                 list.Items.Add(messageSql);
                 list.Text = messageSql._titre;
             }

             return list;
         }

         public string ShowMessage(int index)
         {
             string mess = _userMsg[index]._bodymsg;
             return mess;
         }


    }
}
