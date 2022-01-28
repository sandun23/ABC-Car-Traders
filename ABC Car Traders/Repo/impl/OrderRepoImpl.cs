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

        public string AddOrder(MainOrder mainOrder)
        {
            int ORDER_ID;
            MySqlTransaction transaction;
            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();
            transaction = dbConnection.conn.BeginTransaction();
            string returnValue = "";
            try
            {
                //int customerId = Global.UserID;
                int customerId = 1;
                command = new MySqlCommand("INSERT INTO orders(CustomerId,Status,TotalAmount) VALUES('" + customerId + "','" + mainOrder.Status + "','" + mainOrder.TotalAmount + "')", dbConnection.conn)
                {
                    Transaction = transaction
                };
                int resp = command.ExecuteNonQuery();
                ORDER_ID = (int)command.LastInsertedId;
                if (resp == 1)
                {

                    string orderToken = "ODR0" + ORDER_ID;
                    command = new MySqlCommand("UPDATE orders SET OrderToken = '" + orderToken + "' WHERE OrderId = '" + ORDER_ID + "'", dbConnection.conn)
                    {
                        Transaction = transaction
                    };
                    int orderToeknResp = command.ExecuteNonQuery();
                    if (orderToeknResp == 0)
                    {
                        transaction.Rollback();
                        returnValue = "0";
                    }

                    foreach (var item in mainOrder.OrderDetailList)
                    {
                        command = new MySqlCommand("INSERT INTO order_detail(OrderId,UnitPrice,Qty,SubTotal,CarId,CarPartId)" +
                       "VALUES('" + ORDER_ID + "','" + item.UnitPrice + "','" + item.Qty + "','" + item.SubTotal + "','" + item.CarId + "','" + item.CarPartId + "')", dbConnection.conn)
                        {
                            Transaction = transaction
                        };
                        int resp1 = command.ExecuteNonQuery();

                        if (item.CarId != 0)
                        {
                            command = new MySqlCommand("UPDATE car SET Quantity = Quantity - '" + item.Qty + "' WHERE CarId = '" + item.CarId + "'", dbConnection.conn)
                            {
                                Transaction = transaction
                            };
                            int carQtyResp = command.ExecuteNonQuery();
                            if (carQtyResp == 0)
                            {
                                transaction.Rollback();
                                returnValue = "0";
                            }
                        }
                        else if (item.CarPartId != 0)
                        {
                            command = new MySqlCommand("UPDATE spare_part SET Quantity = Quantity - '" + item.Qty + "' WHERE SparePartId = '" + item.CarPartId + "'", dbConnection.conn)
                            {
                                Transaction = transaction
                            };
                            int carPartQtyResp = command.ExecuteNonQuery();
                            if (carPartQtyResp == 0)
                            {
                                transaction.Rollback();
                                returnValue = "0";
                            }
                        }

                        if (resp1 == 0)
                        {

                            transaction.Rollback();
                            returnValue = "0";
                        }
                    }
                    transaction.Commit();
                    command = new MySqlCommand("Select o.OrderToken FROM orders o WHERE o.OrderId = '" + ORDER_ID + "'", dbConnection.conn);
                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnValue = (string)reader["OrderToken"];
                    }

                    return returnValue;

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {

                dbConnection.CloseConnection();

            }
            return returnValue;
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
