using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCIMotorsForms.Models;

namespace MVCCIMotorsForms.Controllers
{
    public class CustomerController : Controller
    {
        IC_MotersEntities db = new IC_MotersEntities();
        // GET: Customer
        public ActionResult Index()
        {
            var customers = db.People
                .Where(c => c.PersonTypeId == 4)
                .Select(c => new CustomerViewModel
                {
                    CustomerId = c.PersonId,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Address1 = c.Address1,
                    Address2 = c.Address2,
                    SelectedSuburb = c.SuburbId.ToString()
                })
                .ToList();

            
            return View(customers);
        }
    }
}