﻿﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
 using System.Threading.Tasks;
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


        public async Task<ActionResult> Products_Read([DataSourceRequest]DataSourceRequest request)
        {
            using (var northwind = new NorthwindEntities())
            {
                IQueryable<Product> products = northwind.Products;
                //Convert the Product entities to ProductViewModel instances.
                DataSourceResult result = products.ToDataSourceResult(request);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Products_Create([DataSourceRequest]DataSourceRequest request, ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                using (var northwind = new NorthwindEntities())
                {
                    // Create a new Product entity and set its properties from the posted ProductViewModel.
                    var entity = new Product
                    {
                        ProductName = product.ProductName,
                        UnitsInStock = product.UnitsInStock
                    };
                    // Add the entity.
                    northwind.Products.Add(entity);
                    // Insert the entity in the database.
                    northwind.SaveChanges();
                    // Get the ProductID generated by the database.
                    product.ProductID = entity.ProductID;
                }
            }
            // Return the inserted product. The grid needs the generated ProductID. Also return any validation errors.
            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }
        public ActionResult Products_Update([DataSourceRequest]DataSourceRequest request, ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                using (var northwind = new NorthwindEntities())
                {
                    // Create a new Product entity and set its properties from the posted ProductViewModel.
                    var entity = new Product
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        UnitsInStock = product.UnitsInStock
                    };
                    // Attach the entity.
                    northwind.Products.Attach(entity);
                    // Change its state to Modified so Entity Framework can update the existing product instead of creating a new one.
                    northwind.Entry(entity).State = EntityState.Modified;
                    // Or use ObjectStateManager if using a previous version of Entity Framework.
                    // northwind.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                    // Update the entity in the database.
                    northwind.SaveChanges();
                }
            }
            // Return the updated product. Also return any validation errors.
            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }
        public ActionResult Products_Destroy([DataSourceRequest]DataSourceRequest request, ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                using (var northwind = new NorthwindEntities())
                {
                    // Create a new Product entity and set its properties from the posted ProductViewModel.
                    var entity = new Product
                    {
                        ProductID = product.ProductID,
                        ProductName = product.ProductName,
                        UnitsInStock = product.UnitsInStock
                    };
                    // Attach the entity.
                    northwind.Products.Attach(entity);
                    // Delete the entity.
                    northwind.Products.Remove(entity);
                    // Or use DeleteObject if using a previous versoin of Entity Framework.
                    // northwind.Products.DeleteObject(entity);
                    // Delete the entity in the database.
                    northwind.SaveChanges();
                }
            }
            // Return the removed product. Also return any validation errors.
            return Json(new[] { product }.ToDataSourceResult(request, ModelState));
        }
    }
}
