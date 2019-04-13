using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            ProductId = productId;
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public Product Retrive(int productId)
        {
            return new Product();
        }

        public List<Product>  Retrive()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            bool isValide = true;
            if (string.IsNullOrWhiteSpace(Name)) isValide = false;
            if (Price == null) isValide = false;
            return isValide;
        }

    }
}
