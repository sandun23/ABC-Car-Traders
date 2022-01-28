using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.model
{
    class MainOrder
    {
        public MainOrder(int orderId, string orderToken, int customerId, string status, DateTime orderDate, double totalAmount, List<OrderDetails> orderDetailList)
        {
            OrderId = orderId;
            OrderToken = orderToken;
            CustomerId = customerId;
            Status = status;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            OrderDetailList = orderDetailList;
        }
        
        
        public MainOrder(int orderId, string orderToken, int customerId, string status, double totalAmount, List<OrderDetails> orderDetailList)
        {
            OrderId = orderId;
            OrderToken = orderToken;
            CustomerId = customerId;
            Status = status;
            TotalAmount = totalAmount;
            OrderDetailList = orderDetailList;
        }

        public int OrderId { get; set; }
        public string OrderToken { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }

        public List<OrderDetails> OrderDetailList { get; set; }
    }
}
