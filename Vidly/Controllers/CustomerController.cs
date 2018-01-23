using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer

        private MyDbContext _context;

        public CustomerController()
        {
            _context = new MyDbContext();
        }



        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

        
        return View(customers);
        }


        public ActionResult Details(int Id)
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            
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