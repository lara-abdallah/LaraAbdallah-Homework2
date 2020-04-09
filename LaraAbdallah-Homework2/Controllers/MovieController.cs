using LaraAbdallah_Homework2.Models;
using LaraAbdallah_Homework2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace LaraAbdallah_Homework2.Controllers
{
    public class MovieController : Controller
    {
       
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Id=1, Name ="Toni"},
                new Customer {Id=2, Name="John"},
                new Customer {Id=3, Name="Michel"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            //ViewData["RandomMovie"] = movie;
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model


            return View(viewModel);

            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        public ActionResult Movie()
        {
            var MoviesList = new List<Movies>()

            {
                new Movies {Id=1, Name ="Star Wars"},
                new Movies {Id=2, Name="Titanic"},
                new Movies {Id=3, Name="Matrix"},
                new Movies {Id=3, Name="In Time"},
            };

            var viewModel = new RandomMovieViewModel
            {
              
                Movieslist = MoviesList
            };

            return View(viewModel);

        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("movie/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }
        public ActionResult GetCustomer(int id)
        { 
         
            if (id == 1)
            {
                return Content("Toni");
            }
            else if (id == 2)
            {
                return Content("John");
            }
            else
            {
                return Content("Michel");
            }

        }

        public ActionResult GetMovie(int id)
        {

            if (id == 1)
            {
                return Content("Star Wars");
            }
            else if (id == 2)
            {
                return Content("Titanic");
            }
            else if(id == 3)
            {
                return Content("Matrix");
            }
            else
            {
                return Content("In Time");
            }

        }
    }
}