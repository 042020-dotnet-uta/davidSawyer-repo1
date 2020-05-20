using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class OrderController : Controller
    {
        private readonly MvcMovieContext _context;
        
        public OrderController(MvcMovieContext context)
        {
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            IQueryable<int> genreQuery = from m in _context.Orders orderby m.Id select m.Id;

            var orders = from m in _context.Orders select m;

            var orderVM = new OrderViewModel
            {
                Orders = await orders.ToListAsync()
            };

            return View(orderVM);
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
            var movie = _context.Orders.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        [HttpGet]
        public IActionResult Create()
        {
            IQueryable<string> genreQuery = from m in _context.Stores orderby m.Name select m.Name;
            var Locales = new OrderViewModel
            {
                Locales = new SelectList(genreQuery.Distinct().ToList())
            };
            return View(Locales);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("OrderDate, Store, Item1, Item2, Item3, Customer")] Order order){
            
                     
            order.OrderDate = DateTime.Today;
            if (ModelState.IsValid)
            {
                _context.Add(order);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }
    }
}
