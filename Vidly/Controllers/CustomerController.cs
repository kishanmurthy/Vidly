using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();

        
        return View(customers);
        }


        public ActionResult Details(int Id)
        {
            var customers = GetCustomers();
            
            foreach(var customer in customers)
            {
                if (customer.Id == Id)
                {
                    return View(customer);
                }
            }

            return HttpNotFound();
        }



        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer(){Name = "Tony", Id = 1},
                new Customer(){Name = "Stark", Id = 2}
            };
        }
    }
}