using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
namespace Vidly.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return RedirectToAction("Customer","Home");
        }

        public ActionResult Customer()
        {
          
            var customers = new List<Customer>
            {
                new Customer(){Name = "Tony", Id = 1},
                new Customer(){Name = "Stark", Id = 2}
            };
           
            return View();
        }

        public ActionResult Movie()
        {
            var movies = new List<Movie>
            {
                new Movie(){Name = "InterStellar", Id = 1},
                new Movie(){Name = "Inception", Id = 2}
            };

            return View();

            
        }
    }
}