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
                    PhoneNumber = c.PhoneNumber,
                    SelectedSuburb = c.SuburbId.ToString()
                })
                .ToList();
            return View(customers);
        }

        public ActionResult Create()
        {
            var viewModel = new CustomerViewModel
            {
                SuburbTypes = db.SuburbTypes.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(CustomerViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.SuburbTypes = db.SuburbTypes.ToList();
                return View(viewModel);
            }

            var customer = new Person
            {
                PersonId = viewModel.CustomerId,
                PersonTypeId = 4,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                Address1 = viewModel.Address1,
                Address2 = viewModel.Address2,
                PhoneNumber = viewModel.PhoneNumber,
                SuburbId = 3
            };

            db.People.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Delete(int id)
        {
            var customer = db.People.Find(id);
            db.People.Remove(customer);
            db.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }
    }
}