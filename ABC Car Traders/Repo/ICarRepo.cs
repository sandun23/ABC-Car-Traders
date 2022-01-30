using ABC_Car_Traders.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo
{
    interface ICarRepo
    {
        bool AddCar(Car car);

        List<Car> GetAllCars();

        List<Car> FilterCarList(string filterString);

        Car FilterCarListCustomer(string carBrand,string carEdition, string carModel);

        bool UpdateCarDetails(int car_id,double newPrice, int new_Qty);


    }
}
