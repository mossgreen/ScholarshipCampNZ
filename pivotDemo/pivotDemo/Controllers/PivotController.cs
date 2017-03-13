using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pivotDemo.Controllers
{
    public class PivotController : Controller
    {
        // GET: Pivot
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetChild()
        {
            var context = new Entities();
            var children = context.Children.Select(c => new { c.Id, c.SchoolId, c.Name });
            return Json(children, JsonRequestBehavior.AllowGet);
        }
    }
}