﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIDemo.Models;

namespace KendoUIDemo.Controllers
{
    public class ProductController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Product> products = db.Products;
            DataSourceResult result = products.ToDataSourceResult(request, c => new ProductViewModel 
            {
                ProductID = c.ProductID,
                ProductName = c.ProductName,
                UnitsInStock = c.UnitsInStock
            });

            return Json(result);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
