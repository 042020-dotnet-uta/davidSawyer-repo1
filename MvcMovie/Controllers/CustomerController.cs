using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using MvcMovie.Data;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class CustomerController : Controller
    {

        private readonly MvcMovieContext _context;
        private readonly ILogger<CustomerController> _logger;
        public CustomerController(MvcMovieContext context, ILogger<CustomerController> logger)
        {
            _context = context;
            _logger = logger;
        }
        readonly List<Order> Orders = new List<Order>();

        public async Task<IActionResult> Index(string searchString)
        {

            IQueryable<string> genreQuery = from m in _context.Customers orderby m.FirstName select m.FirstName;

            var customers = from m in _context.Customers select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.FirstName.Contains(searchString) || s.LastName.Contains(searchString));
            }

            var customerVM = new CustomerViewModel
            {
                Customers = await customers.ToListAsync()
            };

            return View(customerVM);
        }
        /*[HttpPost]
       public string Index(string searchString, bool notUsed)
       {
           return $"From [HttpPost] Index Action Method: filtered on the substring, {searchString}";
       }
              */
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add([Bind("FirstName","LastName","Username","Password")] Customer customer)
        {
            string Message = $"About page visited at {DateTime.UtcNow.ToLongTimeString()}";
            _logger.LogInformation(Message);
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
        [HttpGet]
        public IActionResult Details()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie = _context.Orders.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Username,Password")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
        public IActionResult CustHist(string? id)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Customer value is null", nameof(id));
            }

            // Create and execute raw SQL query.
            //var movies = from m in _context.Orders select m;
            //movies = movies.Where(s => s.Customer.Contains(Customer));
            string query = "SELECT * FROM Orders where Customer = @p0";
            var customVM = new OrderViewModel
            {
                Orders = _context.Orders.FromSqlRaw(query, id).ToList()
                //Customer = await movies.ToListAsync()
            };
            return View(customVM);
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
