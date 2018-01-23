using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;
namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movies

        private MyDbContext _context;

        public MovieController()
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
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public ActionResult Details(int Id)
        {

            var movies = _context.Movies.Include(c => c.Genre).ToList(); 
            foreach(var movie in movies)
            {
                if(movie.Id ==Id)
                {
                    return View(movie);
                }
            }



            return HttpNotFound();
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

    }
    
}