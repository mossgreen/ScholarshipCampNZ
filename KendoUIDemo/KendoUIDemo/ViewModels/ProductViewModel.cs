using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIDemo.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public  int? ModelId { get; set; }
    }
}