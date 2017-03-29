using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ajax_Example.Models;

namespace Ajax_Example.Controllers
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

        public ActionResult BobChangedIt(string name)
        {
            var newname = Json(new { newname = "Hello " + name + " How Are You" });
            return newname;

        }

        public ActionResult GetCourses()
        {
            SchoolEntities db = new SchoolEntities();
            var courseList = db.Courses.Select(x => new CourseList { id = x.CourseID, Title = x.Title }).ToList();
            return Json(courseList, JsonRequestBehavior.AllowGet);
        }
            
    }
}