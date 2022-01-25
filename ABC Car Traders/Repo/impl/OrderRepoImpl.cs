using ABC_Car_Traders.DB_Connection;
using ABC_Car_Traders.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo.impl
{
    class OrderRepoImpl : IOrderRepo
    {

        MySqlCommand command;

        public bool AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> FilterOrderList(string filterString)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orderList = new List<Order>();
            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();
            command = new MySqlCommand("SELECT orders.OrderToken, orders.TotalAmount, orders.Status, orders.OrderDate, customer.CustomerName, customer.CustomerMobile, order_detail.UnitPrice, order_detail.Qty, order_detail.SubTotal, car.Brand, car.Edition, car.Model, spare_part.SparePartName, spare_part.Brand FROM orders JOIN order_detail ON orders.OrderId = order_detail.OrderDetailId JOIN car ON car.CarId = order_detail.CarId JOIN spare_part ON spare_part.SparePartId = order_detail.CarPartId JOIN customer ON customer.CustomerId = orders.CustomerId", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               // Order order = new Order(Convert.ToInt32(reader["CustomerName"]), (string)reader["CustomerMobile"], (string)reader["OrderToken"], (string)reader["TotalAmount"], (string)reader["Status"], (string)reader["OrderDate"],
                //   (string)reader["Brand"], (string)reader["Edition"], (string)reader["Model"], (string)reader["SparePartName"], (string)reader["Brand"],
                 //  Convert.ToDouble(reader["UnitPrice"]), Convert.ToDouble(reader["SubTotal"]), Convert.ToInt32(reader["Qty"]));
              //  orderList.Add(order);
            }
            dbConnection.CloseConnection();
            return orderList;
        }
    }
}
