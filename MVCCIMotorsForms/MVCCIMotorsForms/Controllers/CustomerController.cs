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

        public ActionResult Index( string query = null)
        {
            var customers = db.People
                   .Where(c => c.PersonTypeId == 4)
                   .ToList();

            if (!String.IsNullOrWhiteSpace(query))
            {

                query = query.Trim();
                customers = customers
                     .Where(c =>
                             c.FirstName.Contains(query) ||
                             c.LastName.Contains(query) ||
                             c.Address1.Contains(query)  ||
                             c.PhoneNumber.Contains(query))
                    .ToList();
            }

            var ViewModel = new CustomerViewModel
            {
                Customers  = customers,
                SearchTerm = query,
            };
            return View(ViewModel);
        }

        public ActionResult Create()
        {
            var viewModel = new CustomerFormViewModel
            {
                SuburbTypes = db.SuburbTypes.ToList()
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(CustomerFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.SuburbTypes = db.SuburbTypes.ToList();
                return View(viewModel);
            }

            var customer = new Person
            {
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


            //before delete people, we should first delete the order details, then orders
            db.People.Remove(customer);
            db.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Search(CustomerViewModel viewModel)
        {
            return RedirectToAction("Index", "Customer", new { query = viewModel.SearchTerm });
        }
    }
}