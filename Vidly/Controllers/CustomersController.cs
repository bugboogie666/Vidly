using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
                new Customer {Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams" }
        };


        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            RandomMovieViewModel viewModel = new RandomMovieViewModel()
            {
                Customers = customers
            };
            return View(viewModel);
        }
        [Route("Customers/detail/{id:range(1,2)}")]
        public ActionResult Details(int id)
        {
            RandomMovieViewModel viewModel = new RandomMovieViewModel()
            {
                Customer = customers[id - 1]
            };
            return View(viewModel);
        }
    }
}