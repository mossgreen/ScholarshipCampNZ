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

            //goes to the index.cshtml
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            //goes to the about.cshtml
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*will be called with /home/StaffManagement*/
        public ActionResult StaffManagement()
        {
            IC_MotersEntities db = new IC_MotersEntities();


            var stafflist = db.People
                .Where(x => x.PersonTypeId != 4)
                                    .Select(x =>
                                            new StaffClass
                                            {
                                                StaffId = x.PersonId,
                                                FirstName = x.FirstName,
                                                LastName = x.LastName,
                                                Address1 = x.Address1,
                                                Address2 = x.Address2,
                                            })
                                        .ToList();

            //StaffManagement.cshtml
            return View(stafflist);
        }


        public ActionResult EditStaffMember(int staffId)
        {
            IC_MotersEntities db = new IC_MotersEntities();

            var people = db.People.Find(staffId);
            var staffToEdit = new StaffClass
            {
                FirstName = people.FirstName,
                LastName = people.LastName,
                StaffId = people.PersonId,
                Address1 = people.Address1,
                Address2 = people.Address2,
                Salary = people.Salary
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
            newStaff.Address2 = staffData.Address2.Trim();
            newStaff.Salary = staffData.Salary;
            db.SaveChanges();
            return RedirectToAction("StaffManagement", "Home");
        }
    }
}