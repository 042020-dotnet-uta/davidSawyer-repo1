using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class CustomerController : Controller
    {
        private readonly MvcMovieContext _context;

        public CustomerController(MvcMovieContext context)
        {
            _context = context;
        }
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
        [HttpPost]
        public string Index(string searchString, bool notUsed)
        {
            return $"From [HttpPost] Index Action Method: filtered on the substring, {searchString}";
        }
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add([Bind("Id,FirstName,LastName,Username,Password")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }
        public IActionResult Edit()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
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


        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
