using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ups.OA.BLL;
using Ups.OA.Model;

namespace Ups.OA.UI.Portal.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        //CustomerService customerService = new CustomerService();
        public CustomerService customerService { get; set; }
        public ActionResult Index()
        {
            ViewData.Model = customerService.GetEntities(u => true);
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerService.Add(customer);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var customer = customerService.GetEntities(u => u.Id == id);
            ViewData.Model = customer.First();

            return View();
        }

        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                customerService.Update(customer);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                var customer = customerService.GetEntities(u => u.Id == id);
                customerService.Delete(customer.First());
            }

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var customer = customerService.GetEntities(u => u.Id == id);
            ViewData.Model = customer.First();

            return View();
        }
    }
}
