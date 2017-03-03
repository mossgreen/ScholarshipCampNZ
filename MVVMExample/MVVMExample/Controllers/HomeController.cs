using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVVMExample.Models;

namespace MVVMExample.Controllers
{
    public class HomeController : Controller
    {

        private IC_MotersEntities db = new IC_MotersEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DisplayStaff()
        {
            return View();
        }

        public ActionResult GetStaffListJQuery()
        {
            var staffList = db.People
                .Where(x => x.PersonTypeId != 4)
                .Select(x => 
                    new StaffListModel { FirstName = x.FirstName, LastName = x.LastName })
                .ToList();

            return View(staffList);
        }

        public ActionResult GetStaffListKnockOutJS()
        {
            var staffList = db.People
                .Where(x => x.PersonTypeId != 4)
                .Select(x =>
                    new StaffListModel { FirstName = x.FirstName, LastName = x.LastName })
                .ToList();

            return Json(staffList,JsonRequestBehavior.AllowGet);
        }
        public ActionResult DisplayStaffKnockoutJS()
        {
            return View();
        }

        public ActionResult GetStaffPopupForm()
        {
            return View();
        }
    }
}