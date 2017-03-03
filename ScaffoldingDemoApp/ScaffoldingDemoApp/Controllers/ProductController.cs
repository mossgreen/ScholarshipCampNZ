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
using ScaffoldingDemoApp.Models;

namespace ScaffoldingDemoApp.Controllers
{
    public class ProductController : Controller
    {
        private AWDataContext db = new AWDataContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Product> products = db.Products;
            DataSourceResult result = products.ToDataSourceResult(request, product => new {
                ProductID = product.ProductID,
                Name = product.Name,
                ProductNumber = product.ProductNumber,
                MakeFlag = product.MakeFlag,
                FinishedGoodsFlag = product.FinishedGoodsFlag,
                Color = product.Color,
                SafetyStockLevel = product.SafetyStockLevel,
                ReorderPoint = product.ReorderPoint,
                StandardCost = product.StandardCost,
                ListPrice = product.ListPrice,
                Size = product.Size,
                SizeUnitMeasureCode = product.SizeUnitMeasureCode,
                WeightUnitMeasureCode = product.WeightUnitMeasureCode,
                Weight = product.Weight,
                DaysToManufacture = product.DaysToManufacture,
                ProductLine = product.ProductLine,
                Class = product.Class,
                Style = product.Style,
                ProductSubcategoryID = product.ProductSubcategoryID,
                ProductModelID = product.ProductModelID,
                SellStartDate = product.SellStartDate,
                SellEndDate = product.SellEndDate,
                DiscontinuedDate = product.DiscontinuedDate,
                rowguid = product.rowguid,
                ModifiedDate = product.ModifiedDate
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
                    Name = product.Name,
                    ProductNumber = product.ProductNumber,
                    MakeFlag = product.MakeFlag,
                    FinishedGoodsFlag = product.FinishedGoodsFlag,
                    Color = product.Color,
                    SafetyStockLevel = product.SafetyStockLevel,
                    ReorderPoint = product.ReorderPoint,
                    StandardCost = product.StandardCost,
                    ListPrice = product.ListPrice,
                    Size = product.Size,
                    SizeUnitMeasureCode = product.SizeUnitMeasureCode,
                    WeightUnitMeasureCode = product.WeightUnitMeasureCode,
                    Weight = product.Weight,
                    DaysToManufacture = product.DaysToManufacture,
                    ProductLine = product.ProductLine,
                    Class = product.Class,
                    Style = product.Style,
                    ProductSubcategoryID = product.ProductSubcategoryID,
                    ProductModelID = product.ProductModelID,
                    SellStartDate = product.SellStartDate,
                    SellEndDate = product.SellEndDate,
                    DiscontinuedDate = product.DiscontinuedDate,
                    rowguid = product.rowguid,
                    ModifiedDate = product.ModifiedDate
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
                    Name = product.Name,
                    ProductNumber = product.ProductNumber,
                    MakeFlag = product.MakeFlag,
                    FinishedGoodsFlag = product.FinishedGoodsFlag,
                    Color = product.Color,
                    SafetyStockLevel = product.SafetyStockLevel,
                    ReorderPoint = product.ReorderPoint,
                    StandardCost = product.StandardCost,
                    ListPrice = product.ListPrice,
                    Size = product.Size,
                    SizeUnitMeasureCode = product.SizeUnitMeasureCode,
                    WeightUnitMeasureCode = product.WeightUnitMeasureCode,
                    Weight = product.Weight,
                    DaysToManufacture = product.DaysToManufacture,
                    ProductLine = product.ProductLine,
                    Class = product.Class,
                    Style = product.Style,
                    ProductSubcategoryID = product.ProductSubcategoryID,
                    ProductModelID = product.ProductModelID,
                    SellStartDate = product.SellStartDate,
                    SellEndDate = product.SellEndDate,
                    DiscontinuedDate = product.DiscontinuedDate,
                    rowguid = product.rowguid,
                    ModifiedDate = product.ModifiedDate
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
                    Name = product.Name,
                    ProductNumber = product.ProductNumber,
                    MakeFlag = product.MakeFlag,
                    FinishedGoodsFlag = product.FinishedGoodsFlag,
                    Color = product.Color,
                    SafetyStockLevel = product.SafetyStockLevel,
                    ReorderPoint = product.ReorderPoint,
                    StandardCost = product.StandardCost,
                    ListPrice = product.ListPrice,
                    Size = product.Size,
                    SizeUnitMeasureCode = product.SizeUnitMeasureCode,
                    WeightUnitMeasureCode = product.WeightUnitMeasureCode,
                    Weight = product.Weight,
                    DaysToManufacture = product.DaysToManufacture,
                    ProductLine = product.ProductLine,
                    Class = product.Class,
                    Style = product.Style,
                    ProductSubcategoryID = product.ProductSubcategoryID,
                    ProductModelID = product.ProductModelID,
                    SellStartDate = product.SellStartDate,
                    SellEndDate = product.SellEndDate,
                    DiscontinuedDate = product.DiscontinuedDate,
                    rowguid = product.rowguid,
                    ModifiedDate = product.ModifiedDate
                };

                db.Products.Attach(entity);
                db.Products.Remove(entity);
                db.SaveChanges();
            }

            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }
    
        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
