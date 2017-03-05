using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoUIDemo.Models;
using KendoUIDemo.ViewModels;

namespace KendoUIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new AWEntities();
            var viewModel = context
                .Product
                .Select(p =>
                    new ProductViewModel
                    {
                       ProductId = p.ProductID,
                       ProductName = p.Name,
                       Color = p.Color,
                        ModelId = p.ProductModelID
                    });
            return View(viewModel);
        }

    }
}