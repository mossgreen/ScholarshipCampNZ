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
    }
}
