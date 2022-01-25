using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ABC_Car_Traders.DB_Connection
{
    public class DBConnector
    {
        public MySqlConnection conn;
        private static readonly string Host = "localhost";
        static readonly string DataBase = "abc_traders";
        static readonly string UserDB = "root";
        static readonly string Password = "1234";
        public static string strProvider = "server=" + Host + ";database=" +
            DataBase + ";uid=" + UserDB + ";pwd=" + Password;

        public bool OpenConnection()
        {
            try
            {
                conn = new MySqlConnection(strProvider);
                conn.Open();
                return true;
            }
            catch (Exception er)
            {
                MessageBox.Show("Connection Error ! " + er.Message, "Information");
            }
            return false;

        }


        public void CloseConnection()
        {
            conn.Close();
        }

    }
}
