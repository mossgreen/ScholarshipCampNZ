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
        public int Quantity { get; set; }

        public void AddToCart(Product p)
        {
            p.InCart++;
            this.Products.Add(p);
            this.CartIsEmpty = false;

        }

        public void listCart()
        {
            Console.WriteLine( $"\nyou've got {this.Products.Count} items in your cart, see the following list:\n ");
            foreach (Product p in this.Products.Distinct())
            {
                Console.WriteLine(
                    $"product ID: {p.ProductId}, product name: {p.ProductName}, price: {p.ProductPrice}, quantity: {p.InCart}");
            }
        }
    }
}
