using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }

        public int Sell(int sellQ)
        {
            if (Quantity - sellQ >= 0) return Quantity - sellQ;
            else return -1;
        }


    }
}
