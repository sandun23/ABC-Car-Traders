using ABC_Car_Traders.model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.Repo
{
    interface ICustomerRepo
    {
        bool AddCustomer(Customer customer);

        List<Customer> GetAllCustomers();

        List<Customer> FilterCustomerList(string filterString);
    }
}
