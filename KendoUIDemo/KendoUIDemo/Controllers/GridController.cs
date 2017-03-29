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
    public class GridController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Product> products = db.Products;
            DataSourceResult result = products.ToDataSourceResult(request, product => new {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                SupplierID = product.SupplierID,
                CategoryID = product.CategoryID,
                QuantityPerUnit = product.QuantityPerUnit,
                UnitPrice = product.UnitPrice,
                UnitsInStock = product.UnitsInStock,
                UnitsOnOrder = product.UnitsOnOrder,
                ReorderLevel = product.ReorderLevel,
                Discontinued = product.Discontinued
            });

            return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Products_Create([DataSourceRequest]DataSourceRequest request, Product product)
        {
            if (ModelState.IsValid)
            {
                var entity = new Product
                {
                    ProductName = product.ProductName,
                    SupplierID = product.SupplierID,
                    CategoryID = product.CategoryID,
                    QuantityPerUnit = product.QuantityPerUnit,
                    UnitPrice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock,
                    UnitsOnOrder = product.UnitsOnOrder,
                    ReorderLevel = product.ReorderLevel,
                    Discontinued = product.Discontinued
                };

                db.Products.Add(entity);
                db.SaveChanges();
                product.ProductID = entity.ProductID;
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Products_Update([DataSourceRequest]DataSourceRequest request, Product product)
        {
            if (ModelState.IsValid)
            {
                var entity = new Product
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    SupplierID = product.SupplierID,
                    CategoryID = product.CategoryID,
                    QuantityPerUnit = product.QuantityPerUnit,
                    UnitPrice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock,
                    UnitsOnOrder = product.UnitsOnOrder,
                    ReorderLevel = product.ReorderLevel,
                    Discontinued = product.Discontinued
                };

                db.Products.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Products_Destroy([DataSourceRequest]DataSourceRequest request, Product product)
        {
            if (ModelState.IsValid)
            {
                var entity = new Product
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    SupplierID = product.SupplierID,
                    CategoryID = product.CategoryID,
                    QuantityPerUnit = product.QuantityPerUnit,
                    UnitPrice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock,
                    UnitsOnOrder = product.UnitsOnOrder,
                    ReorderLevel = product.ReorderLevel,
                    Discontinued = product.Discontinued
                };

                db.Products.Attach(entity);
                db.Products.Remove(entity);
                db.SaveChanges();
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
