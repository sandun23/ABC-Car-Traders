using ABC_Car_Traders.DB_Connection;
using ABC_Car_Traders.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo.impl
{
    class SparePartRepoImpl : ISparePartRepo
    {
        MySqlCommand command;
        public bool AddSparePart(SparePart sparePart)
        {
            bool isSuccess;
            try
            {
                DBConnector dbConnection = new DBConnector();
                dbConnection.OpenConnection();
                command = new MySqlCommand("INSERT INTO spare_part(Brand,SparePartName,Model,Price,Quantity,Description)" +
                "VALUES('" + sparePart.Brand + "','" + sparePart.SparePartName + "','" + sparePart.Model + "','" + sparePart.Price + "','" + sparePart.Quantity + "'," +
                "'" + sparePart.Description + "')", dbConnection.conn);
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

        public List<SparePart> FilterSparePartList(string filterString)
        {
            List<SparePart> sparePartList = new List<SparePart>();
            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();
            command = new MySqlCommand("SELECT * FROM spare_part c WHERE (c.Brand LIKE '%" + filterString + "%' OR c.Model LIKE '%" + filterString + "%' OR c.SparePartName LIKE '%" + filterString + "%');", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SparePart sparePart = new SparePart(Convert.ToInt32(reader["SparePartId"]), (string)reader["Brand"], (string)reader["SparePartName"], (string)reader["Model"],
                   Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Quantity"]), (string)reader["Description"]);
                sparePartList.Add(sparePart);
            }
            dbConnection.CloseConnection();
            return sparePartList;
        }

        public List<SparePart> GetAllSpareParts()
        {
            List<SparePart> sparePartList = new List<SparePart>();
            DBConnector dbConnection = new DBConnector();
            dbConnection.OpenConnection();
            command = new MySqlCommand("SELECT * FROM spare_part", dbConnection.conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                SparePart sparePart = new SparePart(Convert.ToInt32(reader["SparePartId"]), (string)reader["Brand"], (string)reader["SparePartName"], (string)reader["Model"],
                   Convert.ToDouble(reader["Price"]), Convert.ToInt32(reader["Quantity"]), (string)reader["Description"]);
                sparePartList.Add(sparePart);
            }
            dbConnection.CloseConnection();
            return sparePartList;
        }
    }
}
