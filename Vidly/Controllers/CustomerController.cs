using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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

        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new CustomerFormViewModel()
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(CustomerFormViewModel newCustomer)
        {
            
                

            if (newCustomer.Customer.BirthDate != new DateTime())
            {
                newCustomer.Customer.IsBirthDateValid = true;
            }
            else
            {
                newCustomer.Customer.IsBirthDateValid = false;
                newCustomer.Customer.BirthDate = new DateTime(1800, 01, 01);

            }

            if (newCustomer.Customer.Id == 0)
            {
                _context.Customers.Add(newCustomer.Customer);
            } else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == newCustomer.Customer.Id);
                customerInDb.Name = newCustomer.Customer.Name;
                customerInDb.IsBirthDateValid = newCustomer.Customer.IsBirthDateValid;
                customerInDb.BirthDate = newCustomer.Customer.BirthDate;
                customerInDb.IsSubscribedToNewsLetter = newCustomer.Customer.IsSubscribedToNewsLetter;
                customerInDb.MembershipType = newCustomer.Customer.MembershipType;
            }



            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int Id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);
            
            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel()
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm",viewModel);
        }

        public ActionResult Details(int Id)
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            foreach (var customer in customers)
            {
                if (customer.Id == Id)
                {
                    return View(customer);
                }
            }

            return HttpNotFound();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}