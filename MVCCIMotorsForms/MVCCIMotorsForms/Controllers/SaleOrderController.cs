using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCIMotorsForms.Models;

namespace MVCCIMotorsForms.Controllers
{
    public class SaleOrderController : Controller
    {

        IC_MotersEntities db = new IC_MotersEntities();
        // GET: Order
        public ActionResult Index(int id= 0)
        {
            if (id == 0)
            {
                var saleOrders = db.SalesOrders
                    .Select(so => new SaleOrderViewModel
                    {
                        SaleOrderId = so.SalesOrderId,
                        OrderDate = so.OrderDate,
                        PersonId = so.PersonId,
                        OrderNumber = so.OrderNumber
                    });

                return View(saleOrders);
            }
            else
            {
              var  saleOrders = db.SalesOrders
                    .Where(so => so.PersonId == id)
                   .Select(so => new SaleOrderViewModel
                   {
                       SaleOrderId = so.SalesOrderId,
                       OrderDate = so.OrderDate,
                       PersonId = so.PersonId,
                       OrderNumber = so.OrderNumber
                   });
                return View(saleOrders);
            }

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SaleOrderViewModel viewModel)
        {
            var saleorder = new SalesOrder
            {
                OrderDate = DateTime.Now,
                PersonId = viewModel.PersonId,
                OrderNumber = viewModel.OrderNumber
            };

            db.SalesOrders
                .Add(saleorder);
            db.SaveChanges();

            return RedirectToAction("Index", "SaleOrder");
        }

        public ActionResult Edit(int id)
        {
            var saleOrder = db.SalesOrders.Find(id);

            var viewModel = new SaleOrderViewModel
            {
                SaleOrderId = saleOrder.SalesOrderId,
                OrderDate = saleOrder.OrderDate,
                PersonId = saleOrder.PersonId,
                OrderNumber = saleOrder.OrderNumber.Trim()
            };

            return View(viewModel);
        }
    }
}