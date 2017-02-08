using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Cart
    {
        public int CartId { get; set; }
        public double TotalPrice { get; set; }

        public IList<Product> Products { get; set; }

        public Boolean CartIsEmpty { get; set; }

        public double GetPrice()
        {
            if (Products == null) return 0;
            return Products.Sum(p => p.ProductPrice);
        }


        public IEnumerable<Product> AddProduct(int productId)
        {
            Product p = new Product
            {
                ProductId = productId,
            };

            Products.Add(p);


            return Products;

        }
    }
}
