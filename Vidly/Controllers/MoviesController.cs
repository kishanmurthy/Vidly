using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Padmavat" };
            var customers = new List<Customer>
            {
                new Customer{Name= "Customer 1" },
                new Customer{Name= "Customer 2"}
        };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
               Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int movieId)
        {
            return Content("MovieId=" + movieId);
        }


        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if(String.IsNullOrEmpty(sortBy))
            {
                sortBy = "name";
            }
            return Content(String.Format("Page Index = {0} SortBy {1}",pageIndex,sortBy));
        }


        [Route("movies/released/{year:regex(\\d{4}):min(1800):max(2018)}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year=2018,int month=01)
        {

            return Content(year+"/"+month);
        }



        public ActionResult Details()
        {

            return Content("");
        }
    }
    
}