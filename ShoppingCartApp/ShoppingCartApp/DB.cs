using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class  DB
    {
        public Store store { get; set; }
        public Cart cart { get; set; }

        public DB()
        {

            Product p1 = new Product { ProductId = 11, ProductName = "p1 name", ProductPrice = 11.11 };
            Product p2 = new Product { ProductId = 22, ProductName = "p2 name", ProductPrice = 22.22 };
            Product p3 = new Product { ProductId = 33, ProductName = "p3 name", ProductPrice = 33.33 };

            Store s = new Store();
            s.Products = new List<Product>();
            s.StoreName = "Camp Store";
            s.Products.Add(p1);
            s.Products.Add(p2);
            s.Products.Add(p3);
            this.store = s;

            Cart c = new Cart();
            c.Products = new List<Product>();
            this.cart = c;
        }

    }
}
