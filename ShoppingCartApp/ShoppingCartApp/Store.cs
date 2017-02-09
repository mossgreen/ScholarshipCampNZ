using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Store
    {
        public string StoreName { get; set; }
        public IList<Product> Products { get; set; }
        public Boolean Checkout { get; set; }

        public void ShowStoreProducts ()

        {
            foreach (Product p in this.Products)
            {
                Console.WriteLine($"product ID: {p.ProductId}, product name: {p.ProductName}, price: {p.ProductPrice}, In Stock: {p.Quantity}");
            }
        }
    }
}
