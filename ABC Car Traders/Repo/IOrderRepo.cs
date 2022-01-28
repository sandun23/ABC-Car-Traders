using ABC_Car_Traders.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo
{
    interface IOrderRepo
    {
        string AddOrder(MainOrder mainOrder);

        List<Order> GetAllOrders();

        List<Order> FilterOrderList(string filterString);
    }
}
