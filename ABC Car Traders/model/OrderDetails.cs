using System;
using System.Collections.Generic;
using System.Text;

namespace ABC_Car_Traders.model
{
    class OrderDetails
    {
        public OrderDetails(int orderDetailId, int orderId, double unitPrice, int qty, int subTotal, int carId, int carPartId)
        {
            OrderDetailId = orderDetailId;
            OrderId = orderId;
            UnitPrice = unitPrice;
            Qty = qty;
            SubTotal = subTotal;
            CarId = carId;
            CarPartId = carPartId;
        }

        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public double UnitPrice { get; set; }
        public int Qty { get; set; }
        public int SubTotal { get; set; }
        public int CarId { get; set; }
        public int CarPartId { get; set; }

    }
}
