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
        public List<Car> GetAllCars()
        {
            List<Car> carList = new List<Car>();
            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();
            command = new MySqlCommand("SELECT * FROM car", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Car car = new Car(Convert.ToInt32(reader["CarId"]), (string)reader["Brand"], (string)reader["Edition"], (string)reader["Model"], (string)reader["Transmission"], (string)reader["FuelType"],
                   (string)reader["BodyType"], (string)reader["EngineCapacity"], (string)reader["Colour"], (string)reader["ManufacturedYear"], (string)reader["Description"],
                   Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Quantity"]));
                carList.Add(car);
            }
            dbConnection.CloseConnection();
            return carList;

        }

        public List<Car> FilterCarList(string filterString)
        {
            List<Car> carList = new List<Car>();
            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();
            command = new MySqlCommand("SELECT * FROM car c WHERE (c.Brand LIKE '%" + filterString + "%' OR c.Model LIKE '%" + filterString + "%');", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Car car = new Car(Convert.ToInt32(reader["CarId"]), (string)reader["Brand"], (string)reader["Edition"], (string)reader["Model"], (string)reader["Transmission"], (string)reader["FuelType"],
                   (string)reader["BodyType"], (string)reader["EngineCapacity"], (string)reader["Colour"], (string)reader["ManufacturedYear"], (string)reader["Description"],
                   Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Quantity"]));
                carList.Add(car);
            }
            dbConnection.CloseConnection();
            return carList;

        }
    }
}
