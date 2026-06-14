using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCoffeeSystem
{
    public class RestoredOrderInfo : OrderInfo
    {
        public new int OrderNo { get; set; }
        public new DateTime OrderTime { get; set; }
        public new int TotalAmount { get; set; }

        public RestoredOrderInfo(int orderNo, DateTime orderTime, int totalAmount)
        {
            this.OrderNo = orderNo;
            this.OrderTime = orderTime;
            this.TotalAmount = totalAmount;
        }
    }
}
