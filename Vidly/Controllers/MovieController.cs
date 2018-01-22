using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie(){Name="Intersteller",Id=1},
                new Movie(){Name="Inception",Id=2}
            };
            return View(movies);
        }




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