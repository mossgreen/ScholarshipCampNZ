using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCIMotorsForms.Models;

namespace MVCCIMotorsForms.Controllers
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
            IC_MotersEntities db = new IC_MotersEntities();
            var stafflist = db.People.Where(x => x.PersonTypeId != 4).Select(x => new StaffClass {  StaffId = x.PersonId, FirstName = x.FirstName,
                LastName = x.LastName, Address1 = x.Address1 }).ToList();
            return View(stafflist);
        }

        public ActionResult EditStaffMember(int staffId)
        {
             IC_MotersEntities db = new IC_MotersEntities();

            var bob = db.People.Find(staffId);
            var staffToEdit = new StaffClass
            {
                FirstName = bob.FirstName,
                LastName = bob.LastName,
                StaffId = bob.PersonId,
                Address1 = bob.Address1,
                Salary = bob.Salary
            };
                     
            return View(staffToEdit);
        }

        [HttpPost]
        public ActionResult EditStaffMember(StaffClass staffData)
        {
            IC_MotersEntities db = new IC_MotersEntities();
            var newStaff = db.People.Find(staffData.StaffId);
            
            newStaff.PersonId = staffData.StaffId;
            newStaff.FirstName = staffData.FirstName.Trim();
            newStaff.LastName = staffData.LastName.Trim();
            newStaff.Address1 = staffData.Address1.Trim();
            newStaff.Salary = staffData.Salary;          
            db.SaveChanges();
            return RedirectToAction("StaffManagement","Home");
        }
    }
}