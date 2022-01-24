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
                command = new MySqlCommand("INSERT INTO customer(CustomerName,CustomerMobile,CustomerEmail,CustomerAddress,CustomerUserName,CustomerPassword) VALUES('" + customer.CustomerName + "','" + customer.CustomerMobile + "','" + customer.CustomerEmail + "','" + customer.CustomerAddress + "','" + customer.CustomerUserName + "','" + customer.CustomerPassword + "')", dbConnection.conn);
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
