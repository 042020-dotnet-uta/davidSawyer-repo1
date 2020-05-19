using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using ProjectOneV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class StoreController : Controller
    {
        private readonly MvcMovieContext _context;
        readonly List<Order> Orders = new List<Order>();
        public StoreController(MvcMovieContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            IQueryable<string> genreQuery = from m in _context.Stores orderby m.Name select m.Name;

            var stores = from m in _context.Stores select m;

            var storeVM = new StoreListModel
            {
                Stores = await stores.ToListAsync()
            };

            return View(storeVM);
        }
        //     public IActionResult Inventory()
        //   {
        //     return View();
        //   }
        public IActionResult StoreInv(string? test)
        {
            if (test == null)
            {
                return NotFound();
            }
            string query = "SELECT * FROM Items where Store = @p0";
            var storeVM = new ItemListViewModel
            {
                Items = _context.Items.FromSqlRaw(query, test).ToList()
            };
            if (string.IsNullOrEmpty(test))
            {
                throw new ArgumentException("Item not found: ", nameof(test));
            }
            return View(storeVM);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var movie =  _context.Carts.FirstOrDefault(m => m.ID == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        public IActionResult StoreHist(string? id)
        {

            // Create and execute raw SQL query.
            string query = "SELECT * FROM Orders where Store = @p0";
            var storeVM = new OrderViewModel
            {
                Orders = _context.Orders.FromSqlRaw(query, id).ToList()
            };
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Item not found: ", nameof(id));
            }
            return View(storeVM);
        }
    }
}
