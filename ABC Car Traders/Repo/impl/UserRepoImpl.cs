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
                "VALUES('" + adminUser.email + "','" + adminUser.user_name + "','" + adminUser.user_role + "','" + adminUser.password + "')", dbConnection.conn);
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
