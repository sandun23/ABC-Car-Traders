using ABC_Car_Traders.DB_Connection;
using ABC_Car_Traders.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo.impl
{
    class CustomerRepoImpl : ICustomerRepo
    {
        MySqlCommand command;
        public bool AddCustomer(Customer customer)
        {
            bool isSuccess;
            try
            {
                DBConnector dbConnection = new DBConnector();
                dbConnection.OpenConnection();
                command = new MySqlCommand("INSERT INTO customer(CustomerName,CustomerMobile,CustomerEmail,CustomerAddress,CustomerUserName,CustomerPassword) VALUES('" + customer.CustomerName + "','" + customer.CustomerMobile + "','" + customer.CustomerEmail + "','" + customer.CustomerAddress + "','" + customer.CustomerUserName + "',CONCAT('*',UPPER(SHA1(UNHEX(SHA1('"+ customer.CustomerPassword +"'))))))", dbConnection.conn);
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

        public int CustomerLogin(string email, string password)
        {
            int result;
            string dbPassword = "";
            string pass = "";
            string dbEmail = "";
            int customerId = 0;

            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();

            command = new MySqlCommand("SELECT c.CustomerId, c.CustomerName, c.CustomerEmail, c.CustomerMobile, c.CustomerUserName, c.CustomerPassword FROM customer c WHERE c.CustomerEmail = '"+email+"';", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dbPassword = (string)reader["CustomerPassword"];
                dbEmail = (string)reader["CustomerEmail"];
                customerId = (int)reader["CustomerId"];
                CommonLogin.userId = customerId;
                CommonLogin.user_Email = dbEmail;
                CommonLogin.user_name = (string)reader["CustomerUserName"]; ;


            }
            reader.Close();
            command = new MySqlCommand("SELECT CONCAT('*',UPPER(SHA1(UNHEX(SHA1('"+ password +"'))))) as pass", dbConnection.conn);
            MySqlDataReader passwordReader = command.ExecuteReader();
            while (passwordReader.Read())
            {
                pass = (string)passwordReader["pass"];
            }

            if (dbEmail == email && dbPassword == pass)
            {
              //  CUSTOMER_ID = customerId;
                result = 1;
            }
            else
            {
                result = 0;
            }

            dbConnection.CloseConnection();
            return result;
        }

        public List<Customer> FilterCustomerList(string filterString)
        {
            List<Customer> customerList = new List<Customer>();
            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();
            command = new MySqlCommand("SELECT * FROM customer c WHERE (c.CustomerName LIKE '%" + filterString + "%' OR c.CustomerMobile LIKE '%" + filterString + "%');", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer(Convert.ToInt32(reader["CustomerId"]), (string)reader["CustomerName"], (string)reader["CustomerMobile"], (string)reader["CustomerEmail"], (string)reader["CustomerAddress"], (string)reader["CustomerUserName"], "Password Secured");
                customerList.Add(customer);
            }
            dbConnection.CloseConnection();
            return customerList;
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();
            command = new MySqlCommand("SELECT * FROM customer", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer(Convert.ToInt32(reader["CustomerId"]), (string)reader["CustomerName"], (string)reader["CustomerMobile"], (string)reader["CustomerEmail"], (string)reader["CustomerAddress"], (string)reader["CustomerUserName"], "Password Secured");
                customerList.Add(customer);
            }
            dbConnection.CloseConnection();
            return customerList ;
        }
    }
}
