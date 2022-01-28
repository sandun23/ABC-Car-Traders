using ABC_Car_Traders.DB_Connection;
using ABC_Car_Traders.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo.impl
{
    class UserRepoImpl : IUserRepo
    {

        MySqlCommand command;
        public bool AddAdminUser(AdminUsers adminUser)
        {
            bool isSuccess;
            try
            {
                DBConnector dbConnection = new DBConnector();
                dbConnection.OpenConnection();
                command = new MySqlCommand("INSERT INTO user(email,user_name,user_role,password)" +
                "VALUES('" + adminUser.email + "','" + adminUser.user_name + "','" + adminUser.user_role + "',CONCAT('*',UPPER(SHA1(UNHEX(SHA1('" + adminUser.password + "'))))))", dbConnection.conn);
                command.ExecuteNonQuery();
                dbConnection.CloseConnection();
                isSuccess = true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                isSuccess = false;
            }
            return isSuccess;
        }

        public int AdminLogin(string email, string password)
        {
            int result;
            string dbPassword = "";
            string pass = "";
            string dbEmail = "";
            string userName = "";
            int userId = 0;

            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();

            command = new MySqlCommand("SELECT c.user_id , c.email, c.user_name, c.user_role, c.password FROM user c WHERE c.email = '" + email + "';", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dbPassword = (string)reader["password"];
                dbEmail = (string)reader["email"];
                userId = (int)reader["user_id"];
                CommonLogin.user_name = (string)reader["user_name"];
                CommonLogin.userId = userId;
                CommonLogin.user_Email = dbEmail;


            }
            reader.Close();
            command = new MySqlCommand("SELECT CONCAT('*',UPPER(SHA1(UNHEX(SHA1('" + password + "'))))) as pass", dbConnection.conn);
            MySqlDataReader passwordReader = command.ExecuteReader();
            while (passwordReader.Read())
            {
                pass = (string)passwordReader["pass"];
            }

            if (dbEmail == email && dbPassword == pass)
            {
                result = 1;
            }
            else
            {
                result = 0;
            }

            dbConnection.CloseConnection();
            return result;
        }

        public List<AdminUsers> FilterAdminUserList(string filterString)
        {
            throw new NotImplementedException();
        }

        public List<AdminUsers> GetAllAdminUsers()
        {
            throw new NotImplementedException();
        }
    }
}
