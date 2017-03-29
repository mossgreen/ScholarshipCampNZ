using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ICMVCJQuery.Models;

namespace ICMVCJQuery.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult StaffManagement()
        {
            return View();
        }

        public ActionResult GetStaffList()
        {
            IC_MotersEntities db = new IC_MotersEntities();
            var staffList = db.People.Select(x => new StaffData { staffId = x.PersonId, firstName = x.FirstName.Trim(), lastName = x.LastName.Trim() }).ToList();
            return View(staffList);

        }

        public ActionResult UpdateStaff(StaffData staffData)
        {

            // add code here to update the database with the changed staffid data
            return Json(new { success = true });
        }
    }
}