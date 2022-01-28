using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.model
{
    class Order
    {
        public Order()
        {
        }

        public Order(int orderId, string orderToken, int customerId, string status, string orderDate, double totalAmount)
        {
            OrderId = orderId;
            OrderToken = orderToken;
            CustomerId = customerId;
            Status = status;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
        }

        public int OrderId { get; set; }
        public string OrderToken { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public string OrderDate { get; set; }
        public double TotalAmount { get; set; }
      
    }
}
