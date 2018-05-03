using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace _2___Final_Project_Object_Lib
{
    public class SQLConn
    {
        private readonly string _connString;
        private readonly SqlConnection _projConn;


        public SQLConn()
        {
            _connString = Crypto("patachouMaMa", "conn.txt.crypto");
            _projConn = new SqlConnection(_connString);
        }

        public string SQLConnect()
        {
            try
            {
                _projConn.Open();
                return true + " Connected to SQL Database";
            }
            catch (Exception)
            {

               
                return false + " Could not connect to SQL Database";
            }
        }

        public string SQLDisconnect()
        {
            try
            {
                _projConn.Close();
                return true + " Disconnected SQL Database";
            }
            catch (Exception)
            {


                return false + " Could not Disconnect from SQL Database";
            }
        }

        public string SQLCommand(string command)
        {

            try
            {
                SQLConnect();
                SqlCommand insertCommand = new SqlCommand(command, _projConn);
                // cannot do insertcommmand if disconectedduh
                string returning = true + " Command executed! Total rows affected are " + insertCommand.ExecuteNonQuery();
                SQLDisconnect();
                return returning;
            }
            catch (Exception e)
            {
                return false+$" {e} "+" Command Failed!";
            }
        }

        public string Crypto(string sKey, string File)
        {
            try
            {
                byte[] Fichier = System.IO.File.ReadAllBytes(File);
                byte[] Key = Encoding.ASCII.GetBytes(sKey);

                for (int i = 0; i < Fichier.Length; i++)
                {
                    int iKey = i % Key.Length;
                    Fichier[i] ^= Key[iKey];
                    Fichier[i] ^= (byte)i;
                }
                System.IO.File.WriteAllBytes("key.txt", Fichier);

                string stringcon = null;
                using (StreamReader sr = new StreamReader("key.txt"))
                {
                    stringcon = sr.ReadLine();
                }

                System.IO.File.Delete("key.txt");

                return stringcon;
            }
            catch (Exception)
            {
                return "failed to get key";
            }
        
            
        }

        public string CheckConnection(byte[] loginByte, byte[] passwordByte)
        {
            string login = Encoding.ASCII.GetString(loginByte);
            string password = Encoding.ASCII.GetString(passwordByte);
            string passCheck = $"SELECT * FROM users WHERE USERNAME = '{login}' AND USERPASS = '{password}'";

            string compairPass = SQLGetParam(passCheck, "userpass");
            if (password != compairPass)
            {
                return "Invalid password!";
            }
            else
            {
                return "Good Password";
            }
        }


        public string SQLGetParam(string command, string valueCheck)
        {
            string checking = "";

            SqlDataReader myReader = null;
            SQLConnect();
            SqlCommand sqlCom = new SqlCommand(command, _projConn);
            myReader = sqlCom.ExecuteReader();
            while (myReader.Read())
            {
                checking = myReader[valueCheck].ToString();
            }
            SQLDisconnect();

            return checking;
        }

        public List<MessageSQL> GetMessagesFromDB(int userid)
        {
            var newList = new List<MessageSQL>();

            string command = $"SELECT * FROM message WHERE foruser='{userid}';";

            SqlDataReader myReader = null;
            SQLConnect();
            SqlCommand sqlCom = new SqlCommand(command, _projConn);
            myReader = sqlCom.ExecuteReader();
            while (myReader.Read())
            {
                int foruser = int.Parse(myReader["foruser"].ToString());
                string ti = myReader["title"].ToString();
                string body = myReader["body"].ToString();
                int sender = int.Parse(myReader["sender"].ToString());
                
                newList.Add(new MessageSQL(ti,body,sender,foruser));
            }
            SQLDisconnect();

            return newList;
        }
        


    }
}
