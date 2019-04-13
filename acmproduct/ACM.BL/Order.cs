using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int OrderId { get; set; }
        public DateTimeOffset ? OrderDate { get; set; }

        public Order Retrive(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrive()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValide = true;
            if (OrderDate == null) isValide = false;
            return isValide;
        }
    }
}
