using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Order
    {
        public int OrderId { get; set; }
        public int CartId { get; set; }

        private readonly double Cupon = 0.9;

        public double OrderPrice { get; set; }

        public void checkout()
        {
        }

    }
}
