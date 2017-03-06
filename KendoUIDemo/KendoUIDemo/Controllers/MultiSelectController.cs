using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using KendoUIDemo.Models;

namespace KendoUIDemo.Controllers
{
    public class MultiSelectController : Controller
    {
        // GET: MultiSelect
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Virtualization_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetProducts().ToDataSourceResult(request));
        }

        public ActionResult Orders_ValueMapper(int[] values)
        {
            var indices = new List<int>();

            if (values != null && values.Any())
            {
                var index = 0;

                foreach (var p in GetProducts())
                {
                    if (values.Contains(p.ProductID))
                    {
                        indices.Add(index);
                    }

                    index += 1;
                }
            }

            return Json(indices, JsonRequestBehavior.AllowGet);
        }

        private static IEnumerable<ProductViewModel> GetProducts()
        {
            var northwind = new NorthwindEntities();

            return northwind.Products.Select(p => new ProductViewModel
            {
                ProductName = p.ProductName,
                ProductID = p.ProductID,
                UnitsInStock = p.UnitsInStock
            });
        }
    }
}