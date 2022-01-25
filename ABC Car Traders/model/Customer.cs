using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.model
{
    class Customer
    {
        public Customer(int customerId, string customerName, string customerMobile, string customerEmail, string customerAddress, string customerUserName, string customerPassword)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            CustomerMobile = customerMobile;
            CustomerEmail = customerEmail;
            CustomerAddress = customerAddress;
            CustomerUserName = customerUserName;
            CustomerPassword = customerPassword;
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerMobile { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerUserName { get; set; }
        public string CustomerPassword { get; set; }
    }
}
