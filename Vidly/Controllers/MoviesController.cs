using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movieModel = new Movie()
            {
                Name = "Shrek"
            };

            var customer = new List<Customer>()
            {
                new Customer() {Name = "Customer 1"},
                new Customer() {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movieModel,
                Customers = customer

            };
            return View(viewModel);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (string.IsNullOrWhiteSpace((sortBy)))
            {
                sortBy = "Name";
            }

            return Content(String.Format("PageIndex={0}&SortBy={1}", pageIndex, sortBy));
        }

        [Route("Movies/Released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content( String.Format("Year = {0} & Month = {1}", year, month));
        }


    }
}