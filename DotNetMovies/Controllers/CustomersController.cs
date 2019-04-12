using DotNetMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotNetMovies.Controllers
{
    public class CustomersController : Controller
    {
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Fadil Karajic"},
                new Customer {Id = 2, Name = "Fadil1 Karajic1"}
            };

        }
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        
        // GET: Customers
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
      
        
    }
}