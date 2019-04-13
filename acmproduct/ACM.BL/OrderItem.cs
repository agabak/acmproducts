using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public int Quantity{ get; set; }
        public decimal? Price { get; set; }
        public Product Product { get; set; }

        public OrderItem Retrive(int orderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrive()
        {
            return new List<OrderItem>();
        }

        public bool Validate()
        {
            return true;
        }

        public bool Save()
        {
            var isValide = true;
            if (Quantity <= 0) isValide = false;
            if (ProductId <= 0) isValide = false;
            if (Price == null) isValide = false;
            return isValide;
        }
    }
}
