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
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        [Route("Customers")]
        public ActionResult Index()
        {
            RandomMovieViewModel viewModel = new RandomMovieViewModel()
            {
                Customers = _context.Customers.ToList()//GetCustomers().ToList()
            };
            return View(viewModel);
        }
        [Route("Customers/detail/{id:range(1,2)}")]
        public ActionResult Details(int id)
        {
            RandomMovieViewModel viewModel = new RandomMovieViewModel()
            {
                Customer = _context.Customers.ToList()[id-1]//GetCustomers().ToList()[id - 1]
            };
            return View(viewModel);
        }


    }
}