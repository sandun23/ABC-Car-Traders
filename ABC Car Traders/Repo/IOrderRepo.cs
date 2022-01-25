using ABC_Car_Traders.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo
{
    interface IOrderRepo
    {
        bool AddOrder(Order order);

        List<Order> GetAllOrders();

        List<Order> FilterOrderList(string filterString);
    }
}
