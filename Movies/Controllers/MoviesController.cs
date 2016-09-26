using Movies.Models;
using Movies.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var Movie = new Movie() { Name = "Shrek !" };
            //ViewData["Movie"] = movie;
            var customers = new List<Customer>()
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 1" },
            };
            RandomMoviesViewModel viewModel = new RandomMoviesViewModel()
            {
                movie = Movie,
                Customers = customers
            };
            return View(viewModel);
        }


        //public ActionResult Edit(int id)
        //{
        //    return Content("id "+id);
        //}
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue) { pageIndex = 1; }
        //    if (String.IsNullOrWhiteSpace(sortBy)) sortBy = "Name";
        //    return Content(string.Format(pageIndex + " " + sortBy));
        //}
        //[Route ("Movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        //public ActionResult ByReleaseDate(int year=0, int month=9)
        //{
        //    return Content(year+ " "+month);
        //}
    }
}