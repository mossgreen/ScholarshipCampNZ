﻿using System;
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
        public int InStock { get; set; }
        public int InCart { get; set; }

        public void Sell()
        {
            this.InStock--;
        }

    }
}
