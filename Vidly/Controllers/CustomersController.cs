using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private MyDbContext myDbContext;

        public CustomersController()
        {
            this.myDbContext = new MyDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            this.myDbContext.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customer = myDbContext.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }

        public ActionResult New()
        {
            var memberShipTypes = this.myDbContext.MembershipTypes;

            var newCustomerViewModel = new NewCustomerViewModel()
            {
                MembershipTypes = memberShipTypes
            };
            return View(newCustomerViewModel);
        }

        public ActionResult Details(int id)
        {
            //var customer = myDbContext.Customers.Include(c => c.MembershipType) .ToList();
            var customerName = this.myDbContext.Customers.Include(c => c.MembershipType).FirstOrDefault(x => x.Id == id);
            return View(customerName);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            return View();
        }
    }
}