using ABC_Car_Traders.DB_Connection;
using ABC_Car_Traders.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo.impl
{
    class CarRepoImpl : ICarRepo
    {
        MySqlCommand command;

        public bool AddCar(Car car)
        {
            bool isSuccess;
            try
            {
                DBConnector dbConnection = new DBConnector();
                dbConnection.OpenConnection();
                command = new MySqlCommand("INSERT INTO car(Brand,Edition,Model,Transmission,FuelType," +
                "BodyType,EngineCapacity,Colour,ManufacturedYear,Description,Price,Quantity)" +
                "VALUES('" + car.Brand + "','" + car.Edition + "','" + car.Model + "','" + car.Transmission + "','" + car.FuelType + "'," +
                "'" + car.BodyType + "','" + car.EngineCapacity + "','" + car.Colour + "','" + car.ManufacturedYear + "','" + car.Description + "','" + car.Price + "','" + car.Quantity + "')", dbConnection.conn);
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
    }
}
